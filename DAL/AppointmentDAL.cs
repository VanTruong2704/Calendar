using Calendar.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.DAL
{
    public class AppointmentDAL
    {
        private static DataClasses1DataContext db = new DataClasses1DataContext();

        public static List<Appointment> GetConflictsInRange(int userId, DateTime start, DateTime end)
        {
            var q = from p in db.Appointments
                    join u in db.Participants on p.Id equals u.AppointmentId
                    where u.UserId == userId && ((p.StartTime >= start && p.StartTime < end) || (p.EndTime > start && p.EndTime <= end) || (p.StartTime <= start && p.EndTime >= end))
                    select p;
            return q.ToList();
        }

        public static List<Appointment> GetGroupMeetings()
        {
            var q = db.Appointments.Where(p => p.Type == false);
            return q.ToList();
        }

        public static List<Appointment> GetAppointments(int userId)
        {
            var q = from p in db.Appointments
                    join u in db.Participants on p.Id equals u.AppointmentId
                    where u.UserId == userId 
                    select p;

            return q.ToList();
        }

        public static Appointment GetAppointment(int appId)
        {
            var q = db.Appointments.Where(p => p.Id == appId);

            return q.FirstOrDefault();
        }

        public static int AddAppointment(Appointment appointment)
        {
            try
            {
                db.Appointments.InsertOnSubmit(appointment);
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                db.SubmitChanges();
                ParticipantDAL.AddParticipant(new Participant { AppointmentId = appointment.Id, UserId = UserBLL.CurrentUser.Id });
            }

            return appointment.Id;
        }

        public static bool UpdateAppointment(Appointment appointment)
        {
            var q = db.Appointments.Where(p => p.Id == appointment.Id);
            Appointment app = q.FirstOrDefault();

            if (app == null) return false;

            app.Name = appointment.Name;
            app.Location = appointment.Location;
            app.StartTime = appointment.StartTime;
            app.EndTime = appointment.EndTime;
            app.Type = appointment.Type;

            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool DeleteAppointment(int appId)
        {
            //leave group meetings, only delete personal appointments

            var q = db.Appointments.Where(p => p.Id == appId);
            Appointment app = q.FirstOrDefault();

            if (app == null) return false;

            try
            {
                if (app.Type == true) { 
                    ReminderDAL.DeleteReminders(appId);
                    ParticipantDAL.DeleteParticipant(appId, UserBLL.CurrentUser.Id);
                    db.Appointments.DeleteOnSubmit(app);
                    db.SubmitChanges();
                } else
                {
                    ReminderDAL.DeleteReminders(appId, UserBLL.CurrentUser.Id);
                    ParticipantDAL.DeleteParticipant(appId, UserBLL.CurrentUser.Id);
                    if (app.Participants.Count == 0)
                    {
                        db.Appointments.DeleteOnSubmit(app);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public static int JoinGroupMeeting(int appId, int userId)
        {
            var q = db.Appointments.Where(p => p.Id == appId);

            Appointment app = q.FirstOrDefault();

            if (app == null || app.Type == true) return -1;

            var user = db.Users.Where(p => p.Id == userId).FirstOrDefault();
            if (user == null) return -1;

            if (!ParticipantDAL.AddParticipant(new Participant { AppointmentId = appId, UserId = userId }))
                return -1;
            
            return app.Id;
        }
    }
}
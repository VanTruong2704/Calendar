using Calendar.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    public class AppointmentDAL
    {

        public static List<Appointment> GetConflictsInRange(int userId, DateTime start, DateTime end)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = from p in db.Appointments
                        join u in db.Participants on p.Id equals u.AppointmentId
                        where u.UserId == userId && ((p.StartTime >= start && p.StartTime < end) || (p.EndTime > start && p.EndTime <= end) || (p.StartTime <= start && p.EndTime >= end))
                        select p;
                return q.ToList();
            }
        }

        public static List<Appointment> GetGroupMeetings()
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Appointments.Where(p => p.Type == false);
                return q.ToList();
            }
        }

        public static List<Appointment> GetAppointments(int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = from p in db.Appointments
                        join u in db.Participants on p.Id equals u.AppointmentId
                        where u.UserId == userId 
                        select p;

                return q.ToList();
            }
        }

        public static Appointment GetAppointment(int appId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Appointments.Where(p => p.Id == appId);
                return q.FirstOrDefault();
            }
        }

        public static int AddAppointment(Appointment appointment)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                try
                {
                    db.Appointments.InsertOnSubmit(appointment);
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    return -1;
                }

                ParticipantDAL.AddParticipant(new Participant { AppointmentId = appointment.Id, UserId = UserBLL.CurrentUser.Id });
                return appointment.Id;
            }
        }

        public static bool UpdateAppointment(Appointment appointment)
        {
            using (var db = DataContextFactory.CreateContext())
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
        }

        public static bool DeleteAppointment(int appId)
        {
            //leave group meetings, only delete personal appointments

            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Appointments.Where(p => p.Id == appId);
                Appointment app = q.FirstOrDefault();

                if (app == null) return false;

                try
                {
                    ReminderDAL.DeleteReminders(appId, UserBLL.CurrentUser.Id);
                    ParticipantDAL.DeleteParticipant(appId, UserBLL.CurrentUser.Id);

                    // Query mới bằng DataContext khác để lấy count chính xác (tránh cache stale)
                    int remainingCount = db.Participants.Count(p => p.AppointmentId == appId);
                    Console.WriteLine("Current user count left: " + remainingCount);

                    if (remainingCount == 0)
                    {
                        // Reload appointment từ db hiện tại để đảm bảo không cache stale
                        app = db.Appointments.Where(p => p.Id == appId).FirstOrDefault();
                        if (app != null)
                        {
                            db.Appointments.DeleteOnSubmit(app);
                            db.SubmitChanges();
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
        }

        public static int JoinGroupMeeting(int appId, int userId)
        {
            using (var db = DataContextFactory.CreateContext())
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
}
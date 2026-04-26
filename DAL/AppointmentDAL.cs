using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    public class AppointmentDAL
    {
        private static DataClasses1DataContext db = new DataClasses1DataContext();

        public static List<User> GetParticipants(int appId)
        {
            var q = from p in db.Users
                    from a in p.Appointments
                    where a.Id == appId 
                    select p;
            return q.ToList();
        }

        public static List<Appointment> GetConflictsInRange(int userId, DateTime start, DateTime end)
        {
            var q = from p in db.Appointments
                    where p.UserId == userId && ((p.StartTime >= start && p.StartTime < end) || (p.EndTime > start && p.EndTime <= end) || (p.StartTime <= start && p.EndTime >= end))
                    select p;
            return q.ToList();
        }

        public static List<Appointment> GetGroupMeetings(int name)
        {
            var q = from p in db.Appointments
                    where p.UserId == name && p.Type == false
                    select p;
            return q.ToList();
        }

        public static List<Appointment> GetAppointments(int userId)
        {
            var q = from p in db.Appointments
                    where p.UserId == userId
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
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                db.SubmitChanges();
            }

            return appointment.Id;
        }

        public static bool UpdateAppointment(Appointment appointment)
        {
            var q = db.Appointments.Where(p => p.Id == appointment.Id);
            Appointment app = q.FirstOrDefault();

            if (app == null) return false;

            app.AppointmentName = appointment.AppointmentName;
            app.Location = appointment.Location;
            app.StartTime = appointment.StartTime;
            app.EndTime = appointment.EndTime;
            app.Type = appointment.Type;

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static bool DeleteAppointment(int appId)
        {
            var q = db.Appointments.Where(p => p.Id == appId);
            Appointment app = q.FirstOrDefault();

            if (app == null) return false;

            try
            {
                db.Appointments.DeleteOnSubmit(app);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
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

            try
            {
                user.Appointments.Add(app);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }

            return app.Id;
        }
    }
}
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
    }
}
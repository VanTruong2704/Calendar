using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    public class ReminderDAL
    {
        public static List<Reminder> GetRemindersByUserId(int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = from p in db.Reminders
                        where p.UserId == userId
                        select p;
                return q.ToList();
            }
        }

        public static List<Reminder> GetReminders(int appId, int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = from p in db.Reminders
                        where p.AppointmentId == appId && p.UserId == userId
                        select p;
                return q.ToList();
            }
        }

        public static Reminder GetReminder(int remId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Reminders.Where(p => p.Id == remId);
                return q.FirstOrDefault();
            }
        }

        public static bool AddReminder(Reminder reminder)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                try
                {
                    db.Reminders.InsertOnSubmit(reminder);
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        public static bool UpdateReminder(Reminder reminder)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Reminders.Where(p => p.Id == reminder.Id);
                Reminder rem = q.FirstOrDefault();
                if (rem == null) return false;

                rem.ReminderTime = reminder.ReminderTime;

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
        }

        public static bool DeleteReminder(int remId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Reminders.Where(p => p.Id == remId);
                Reminder rem = q.FirstOrDefault();

                if (rem == null) return false;

                try
                {
                    db.Reminders.DeleteOnSubmit(rem);
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteReminders(int appId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Reminders.Where(p => p.AppointmentId == appId);
                List<Reminder> rems = q.ToList();
                if (rems.Count == 0) return true;
                try
                {
                    db.Reminders.DeleteAllOnSubmit(rems);
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteReminders(int appId, int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Reminders.Where(p => p.AppointmentId == appId && p.UserId == userId);
                List<Reminder> rems = q.ToList();
                if (rems.Count == 0) return true;
                try
                {
                    db.Reminders.DeleteAllOnSubmit(rems);
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
}

using Calendar.DAL;
using Calendar.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.BLL
{
    public class ReminderBLL
    {
        public static bool createReminders(List<CreateReminder> reminders)
        {
            foreach (var reminder in reminders)
            {
                Appointment app = AppointmentDAL.GetAppointment(reminder.AppointmentId);
                int minOffset;
                switch (reminder.RmdTimeId)
                {
                    case 1:
                        minOffset = -15;
                        break;
                    case 2:
                        minOffset = -30;
                        break;
                    case 3:
                        minOffset = -60;
                        break;
                    case 4:
                        minOffset = -120;
                        break;
                    case 5:
                        minOffset = -1440;
                        break;
                    case 6:
                        minOffset = -2880;
                        break;
                    default:
                        return false;
                }


                if (!ReminderDAL.AddReminder(new Reminder
                                                {
                                                    AppointmentId = reminder.AppointmentId,
                                                    UserId = UserBLL.CurrentUser.Id,
                                                    ReminderTime = app.StartTime.AddMinutes(minOffset)
                                                }))
                {
                    return false;
                }
            }

            return true;
        }
        public static List<String> GetReminderViews(int appId)
        {
            var reminders = ReminderDAL.GetReminders(appId, UserBLL.CurrentUser.Id);
            return reminders.Select(r => r.ReminderTime.ToString("dd/MM/yyyy hh:mm tt")).ToList();
        }
    }
}

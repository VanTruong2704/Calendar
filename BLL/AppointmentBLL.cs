using Calendar.DAL;
using Calendar.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.BLL
{
    public class AppointmentBLL
    {
        public static int createAppointment(CreateAppointment newApp)
        {
            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrEmpty(newApp.Name) || string.IsNullOrEmpty(newApp.Location) ||
                newApp.StartHour >= newApp.EndHour)
            {
                return -1;
            }

            Appointment appointment = new Appointment
            {
                Name = newApp.Name,
                Location = newApp.Location,
                StartTime = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.StartHour, 0, 0),
                EndTime = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.EndHour, 0, 0),
                Type = newApp.Type
            };

            return AppointmentDAL.AddAppointment(appointment);
        }

        public static bool DeleteAppointment(int appId)
        {
            return (AppointmentDAL.DeleteAppointment(appId));
        }

        public static List<AppointmentView> GetAppointmentViews()
        {
            var appointments = AppointmentDAL.GetAppointments(UserBLL.CurrentUser.Id);
            return appointments.Select(a => new AppointmentView
            {
                Id = a.Id,
                Name = a.Name,
                Location = a.Location,
                Date = a.StartTime.Date.ToString("dd/MM/yyyy"),
                StartHour = a.StartTime.ToString("hh:mm tt"),
                EndHour = a.EndTime.ToString("hh:mm tt"),
                Type = a.Type ? "Đơn" : "Nhóm"
            }).ToList();
        }

        public static AppointmentView GetAppointmentView(int appId)
        {
            var a = AppointmentDAL.GetAppointment(appId);
            return new AppointmentView
            {
                Name = a.Name,
                Location = a.Location,
                Date = a.StartTime.Date.ToString("dd/MM/yyyy"),
                StartHour = a.StartTime.ToString("hh:mm tt"),
                EndHour = a.EndTime.ToString("hh:mm tt"),
                Type = a.Type ? "Đơn" : "Nhóm"
            };
        }

        public static bool HasConflict(DateTime start, DateTime end)
        {
            var conflicts = AppointmentDAL.GetConflictsInRange(UserBLL.CurrentUser.Id, start, end);
            return conflicts.Count > 0;
        }

        public static int HasGroupMeeting(string name, DateTime start, DateTime end)
        {
            string duration = end.Subtract(start).TotalHours.ToString();

            var groupMeetings = AppointmentDAL.GetGroupMeetings();
            foreach (var meeting in groupMeetings)
            {
                if (meeting.Name == name && 
                    meeting.StartTime.ToShortDateString() == start.ToShortDateString() &&
                    meeting.EndTime.Subtract(meeting.StartTime).TotalHours.ToString() == duration)
                {
                    return meeting.Id;
                }
            }

            return -1;
        }

        public static bool DeleteConficts(CreateAppointment newApp)
        {
            DateTime start = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.StartHour, 0, 0);
            DateTime end = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.EndHour, 0, 0);
            var conflicts = AppointmentDAL.GetConflictsInRange(UserBLL.CurrentUser.Id, start, end);
            foreach (var conflict in conflicts)
            {
                if (!AppointmentDAL.DeleteAppointment(conflict.Id)) return false;
            }
            return true;
        }

        public static int JoinGroupMeeting(int meetingId)
        {
            if (ParticipantDAL.GetParticipant(meetingId, UserBLL.CurrentUser.Id) != null)
                return -1;
            return AppointmentDAL.JoinGroupMeeting(meetingId, UserBLL.CurrentUser.Id);
        }

        public static List<UserView> GetParticipants(int appId)
        {
            var participants = ParticipantDAL.GetParticipants(appId);
            return participants.Select(p => new UserView
            {
                Name = p.Name,
                Email = p.Email
            }).ToList();
        }
    }
}
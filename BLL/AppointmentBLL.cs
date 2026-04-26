using Calendar.DAL;
using Calendar.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.BLL
{
    public class AppointmentBLL
    {
        public static int createAppointment(CreateAppointment newApp)
        {
            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrEmpty(newApp.Name) || string.IsNullOrEmpty(newApp.Location))
            {
                return -1;
            }
            if (newApp.StartHour >= newApp.EndHour)
            {
                return -1;
            }

            Appointment appointment = new Appointment
            {
                AppointmentName = newApp.Name,
                Location = newApp.Location,
                StartTime = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.StartHour, 0, 0),
                EndTime = new DateTime(newApp.Date.Year, newApp.Date.Month, newApp.Date.Day, newApp.EndHour, 0, 0),
                UserId = UserBLL.CurrentUser.Id,
                Type = newApp.Type
            };

            return AppointmentDAL.AddAppointment(appointment);
        }

        public static List<AppointmentView> GetAppointmentViews()
        {
            var appointments = AppointmentDAL.GetAppointments(UserBLL.CurrentUser.Id);
            return appointments.Select(a => new AppointmentView
            {
                Name = a.AppointmentName,
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
                Name = a.AppointmentName,
                Location = a.Location,
                Date = a.StartTime.Date.ToString("dd/MM/yyyy"),
                StartHour = a.StartTime.ToString("hh:mm tt"),
                EndHour = a.EndTime.ToString("hh:mm tt"),
                Type = a.Type ? "Đơn" : "Nhóm"
            };
        }
    }
}

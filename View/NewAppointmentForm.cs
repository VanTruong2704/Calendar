using Calendar.BLL;
using Calendar.View;
using Calendar.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class NewAppointmentForm : Form
    {
        private DateTime selectedDate;
        public NewAppointmentForm(DateTime selectedDate)
        {
            InitializeComponent();

            this.selectedDate = selectedDate;
            rbSingle.Checked = true;
            UiTheme.ApplyFormTheme(this);
        
        }

        private bool promptConflict(DateTime start, DateTime end)
        {
            if (AppointmentBLL.HasConflict(start, end))
            {
                DialogResult result = MessageBox.Show("Cuộc hẹn này có xung đột với cuộc hẹn khác. Bạn có muốn thay thế bằng cuộc hẹn này không?", "Xung đột cuộc hẹn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }

                AppointmentBLL.DeleteConficts(start, end);
            }

            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CreateAppointment newApp = new CreateAppointment
            {
                Name = tbNameApp.Text,
                Location = tbLocation.Text,
                Date = selectedDate,
                StartHour = (int)nudStartHour.Value,
                EndHour = (int)nudEndHour.Value,
                Type = rbSingle.Checked ? true : false
            };

            if (newApp.Type == false)
            {
                Appointment meeting = AppointmentBLL.GetGroupMeeting(newApp.Name, new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, newApp.StartHour, 0, 0), new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, newApp.EndHour, 0, 0));

                if (meeting != null)
                {
                    DialogResult result = MessageBox.Show("Cuộc hẹn nhóm này đã tồn tại. Bạn có muốn tham gia cuộc hẹn nhóm này không?", "Cuộc hẹn nhóm đã tồn tại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (AppointmentBLL.GetParticipant(meeting.Id, UserBLL.CurrentUser.Id) != null)
                        {
                            MessageBox.Show("Bạn đã tham gia cuộc hẹn nhóm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (!promptConflict(meeting.StartTime, meeting.EndTime))
                        {
                            return;
                        }

                        AppointmentBLL.JoinGroupMeeting(meeting.Id);

                        ReminderForm fo = new ReminderForm(meeting.Id);
                        fo.ShowDialog();
                        this.Close();
                        return;
                    }
                }
            }

            // Kiểm tra conficts
            if (!promptConflict(new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, newApp.StartHour, 0, 0), new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, newApp.EndHour, 0, 0)))
            {
                return;
            }

            

            int newAppId = AppointmentBLL.createAppointment(newApp);

            if (newAppId == -1)
            {
                MessageBox.Show("Tạo cuộc hẹn thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            ReminderForm f = new ReminderForm(newAppId);
            f.ShowDialog();

            MessageBox.Show("Tạo cuộc hẹn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

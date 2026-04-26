using Calendar.BLL;
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

namespace Calendar.View
{
    public partial class ReminderForm : Form
    {
        private List<CreateReminder> reminders;
        private int appointmentId;
        public ReminderForm(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            Init();
        }

        public void Init()
        {
            cbbReminder.Items.Add(new CBBItem { Key = 1, Value = "Trước 15 phút" });
            cbbReminder.Items.Add(new CBBItem { Key = 2, Value = "Trước 30 phút" });
            cbbReminder.Items.Add(new CBBItem { Key = 3, Value = "Trước 1 giờ" });
            cbbReminder.Items.Add(new CBBItem { Key = 4, Value = "Trước 2 giờ" });
            cbbReminder.Items.Add(new CBBItem { Key = 5, Value = "Trước 1 ngày" });
            cbbReminder.Items.Add(new CBBItem { Key = 6, Value = "Trước 2 ngày" });

            reminders = new List<CreateReminder>();

            //listViewReminder.Columns.Add("Thời gian nhắc trước");
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            var selectedReminder = cbbReminder.SelectedItem as CBBItem;
            if (selectedReminder == null)             {
                MessageBox.Show("Vui lòng chọn thời gian nhắc trước.");
                return;
            }

            if (reminders.Any(r => r.RmdTimeId == selectedReminder.Key))
            {
                MessageBox.Show("Bạn đã thêm nhắc trước này.");
                return;
            }

            reminders.Add(new CreateReminder
            {
                RmdTimeId = selectedReminder.Key,
                AppointmentId = appointmentId
            });

            listViewReminder.Items.Add(selectedReminder.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ReminderBLL.createReminders(reminders)) return;
            this.Dispose();
        }
    }
}

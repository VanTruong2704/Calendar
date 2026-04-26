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
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int newAppId = AppointmentBLL.createAppointment(new CreateAppointment
            {
                Name = tbNameApp.Text,
                Location = tbLocation.Text,
                Date = selectedDate,
                StartHour = (int)nudStartHour.Value,
                EndHour = (int)nudEndHour.Value,
                Type = rbSingle.Checked ? true : false
            });

            if (newAppId == -1)
            {
                MessageBox.Show("Failed to create appointment. Please check your input.");
                return;
            }            

            ReminderForm f = new ReminderForm(newAppId);
            f.ShowDialog();

            this.Dispose();
        }

        private void cbbEndHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using Calendar.View;
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
        public NewAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ReminderForm f = new ReminderForm();
            f.ShowDialog();
        }

        private void cbbEndHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

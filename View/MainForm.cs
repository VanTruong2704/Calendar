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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UiTheme.ApplyFormTheme(this);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            NewAppointmentForm form = new NewAppointmentForm(monthCalendar.SelectionStart);
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMyAppointment_Click(object sender, EventArgs e)
        {
            Form f = new MyAppointmentForm();
            f.ShowDialog();
        }
    }
}

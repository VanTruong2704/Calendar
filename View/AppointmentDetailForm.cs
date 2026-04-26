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
    public partial class AppointmentDetailForm : Form
    {
        public AppointmentDetailForm(int appId)
        {
            InitializeComponent();
            Init(appId);
        }
        public void Init(int appId)
        {
            AppointmentView app = AppointmentBLL.GetAppointmentView(appId);
            labelAppName.Text = app.Name;
            labelAppLocation.Text = app.Location;
            labelAppDate.Text = app.Date;
            labelAppStartHour.Text = app.StartHour;
            labelAppEndhour.Text = app.EndHour;
            //labelType.Text = app.Type;

            listViewReminder.Items.AddRange(ReminderBLL.GetReminderViews(appId).Select(r => new ListViewItem(r)).ToArray());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

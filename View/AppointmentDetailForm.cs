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
            UiTheme.ApplyFormTheme(this);
            ApplyDynamicLabelStyle();
            Init(appId);
        }

        private void ApplyDynamicLabelStyle()
        {
            labelAppName.Font = new Font(labelAppName.Font, FontStyle.Regular);
            labelAppLocation.Font = new Font(labelAppLocation.Font, FontStyle.Regular);
            labelAppDate.Font = new Font(labelAppDate.Font, FontStyle.Regular);
            labelAppStartHour.Font = new Font(labelAppStartHour.Font, FontStyle.Regular);
            labelAppEndhour.Font = new Font(labelAppEndhour.Font, FontStyle.Regular);
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

            if (listViewReminder.Columns.Count == 0)
            {
                listViewReminder.Columns.Add("Thời gian nhắc");
            }

            listViewReminder.Items.Clear();
            listViewReminder.Items.AddRange(ReminderBLL.GetReminderViews(appId).Select(r => new ListViewItem(r)).ToArray());
            listViewReminder.Columns[0].Width = -2; //fill

            List<UserView> participants = AppointmentBLL.GetParticipants(appId);
            if (participants.Count > 0) 
            {
                dgvParticipants.DataSource = participants;
                dgvParticipants.Columns[0].HeaderText = "Tên";
                dgvParticipants.Columns[1].HeaderText = "Email";

                dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvParticipants.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvParticipants.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvParticipants.Columns[0].FillWeight = 50;
                dgvParticipants.Columns[1].FillWeight = 50;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

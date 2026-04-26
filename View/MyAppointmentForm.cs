using Calendar.DAL;
using Calendar.BLL;
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
    public partial class MyAppointmentForm : Form
    {
        public MyAppointmentForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            dgvAppointment.DataSource = AppointmentBLL.GetAppointmentViews();
            dgvAppointment.Columns[0].Visible = false;
            dgvAppointment.Columns[1].HeaderText = "Tên cuộc hẹn";
            dgvAppointment.Columns[2].HeaderText = "Ngày diễn ra";
            dgvAppointment.Columns[3].HeaderText = "Giờ bắt đầu";
            dgvAppointment.Columns[4].HeaderText = "Giờ kết thúc";
            dgvAppointment.Columns[5].HeaderText = "Loại";
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            Form f = new AppointmentDetailForm((int) dgvAppointment.SelectedRows[0].Cells[0].Value);
            f.ShowDialog();
        }

    }
}

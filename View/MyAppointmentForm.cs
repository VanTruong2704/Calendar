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
            UiTheme.ApplyFormTheme(this);
            Init();
        }

        public void Init()
        {
            dgvAppointment.DataSource = AppointmentBLL.GetAppointmentViews();
            dgvAppointment.Columns[0].Visible = false;
            dgvAppointment.Columns[1].HeaderText = "Tên cuộc hẹn";
            dgvAppointment.Columns[2].HeaderText = "Vị trí";
            dgvAppointment.Columns[3].HeaderText = "Ngày diễn ra";
            dgvAppointment.Columns[4].HeaderText = "Giờ bắt đầu";
            dgvAppointment.Columns[5].HeaderText = "Giờ kết thúc";
            dgvAppointment.Columns[6].HeaderText = "Loại";
            dgvAppointment.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            Form f = new AppointmentDetailForm((int) dgvAppointment.SelectedRows[0].Cells[0].Value);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa cuộc hẹn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int appId = (int)dgvAppointment.SelectedRows[0].Cells[0].Value;
                if (AppointmentBLL.DeleteAppointment(appId))
                {
                    MessageBox.Show("Xóa cuộc hẹn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Init();
                }
                else
                {
                    MessageBox.Show("Xóa cuộc hẹn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

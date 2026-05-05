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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UiTheme.ApplyFormTheme(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserBLL.login(tbName.Text.Trim(), tbEmail.Text.Trim()))
            {
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                tbName.Text = "";
                tbEmail.Text = "";

                this.Show();
            }
            else
            {
                //nếu sai thì prompt hỏi có muốn đăng ký không
                DialogResult result = MessageBox.Show("Tài khoản không tồn tại. Bạn có muốn đăng ký không?", "Đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (UserBLL.register(tbName.Text, tbEmail.Text))
                    {
                        MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}

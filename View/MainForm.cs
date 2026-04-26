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
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            NewAppointmentForm form = new NewAppointmentForm();
            form.ShowDialog();
        }
    }
}

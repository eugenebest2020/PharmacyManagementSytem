using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSytem
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();   
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible=false;
            uC_AddUsers1.Visible = false;
            btnDashBoard.PerformClick();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            uC_AddUsers1.Visible = true;
            uC_AddUsers1.BringToFront();
        }
    }
}

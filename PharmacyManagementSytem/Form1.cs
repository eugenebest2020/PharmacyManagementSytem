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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "programmer" && txtPassword.Text == "p@ssword")
            {
                Administrator adm = new Administrator();
                adm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password","Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }
    }
}

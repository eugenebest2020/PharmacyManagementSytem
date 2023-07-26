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
        function fn = new function();

        string query;
        DataSet ds;
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
            query = "select * from users";

             ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUserName.Text=="root" && txtPassword.Text == "root")
                {
                    Administrator admin = new Administrator();

                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUserName.Text +
                    "'and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();

                    if(role == "Administrator")
                    {
                        Administrator admin = new Administrator();
                        admin.Show();
                        this.Hide();
                    }

                    else if(role =="Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSytem.AdministractorUC
{
    public partial class UC_AddUsers : UserControl
    {
        function fn = new function();

        string query;

        public UC_AddUsers()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            string email = txtEmailAddress.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Sign up successful.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username Already exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtEmailAddress.Clear();
            txtUserName.Clear();
            txtMobileNo.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\PIIT\Desktop\PharmacyProject\Images\mark.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\PIIT\Desktop\PharmacyProject\Images\no.png";

            }


        }
    }
}

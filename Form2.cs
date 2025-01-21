using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutalibwinformapp
{
    public partial class FormChangeUser : Form
    {
        public string oldpassword { get; set; }
        public string oldusername { get; set; }
        public FormChangeUser()
        {
            InitializeComponent();
        }

        private void FormChangeUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxOldUsername.Text == oldusername && textBoxOldPassword.Text == oldpassword)
            {
                string newusername=textBoxNewUsername.Text;
                string newpassword=textBoxNewPassword.Text;
                FormSignIn form1 = new FormSignIn();
                form1.getUsername = newusername;
                form1.getPassword = newpassword;
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Old Username or Old Password is incorrect", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

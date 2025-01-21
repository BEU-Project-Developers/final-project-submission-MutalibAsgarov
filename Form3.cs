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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form3_KeyDown);
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignUp2.PerformClick();
            }
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName2.Text;
            string password = textBoxPassword2.Text;
            FormSignIn form1 = new FormSignIn();
            form1.getUsername = username;
            form1.getPassword = password;
            form1.Show();
            this.Hide();
            

        }
        private void checkBoxShowPassword2_CheckedChanged2(object sender, EventArgs e)
        {


        }

        private void checkBoxShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword2.Checked)
            {
                textBoxPassword2.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword2.PasswordChar = '*';
            }
        }
    }
}

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mutalibwinformapp
{
    public partial class FormSignIn : Form
    {
        public string getUsername { get; set; }
        public string getPassword { get; set; }
        public FormSignIn()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormSignIn_KeyDown);


        }
        private void FormSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {




        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (textBoxUserName.Text == getUsername && textBoxPassword.Text == getPassword)
            {
                formHome form2 = new formHome();
                form2.Show();
                this.Hide();
                if (textBoxUserName.Text != "" && textBoxPassword.Text != "")
                {
                    textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonResetUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormChangeUser form2 = new FormChangeUser();
            form2.oldpassword = getPassword;
            form2.oldusername= getUsername;
            form2.Show();
            this.Hide();
        }
    }
}

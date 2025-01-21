namespace mutalibwinformapp
{
    partial class FormSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            btnSignIn = new Button();
            checkBoxShowPassword = new CheckBox();
            btnSignUp = new Button();
            lblDontHaveAnAccount = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.FlatStyle = FlatStyle.Flat;
            lblLogin.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Navy;
            lblLogin.Location = new Point(119, 7);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(178, 55);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.FlatStyle = FlatStyle.Flat;
            lblUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.Navy;
            lblUserName.Location = new Point(18, 87);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(88, 17);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "UserName:";
            lblUserName.Click += lblUserName_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.FlatStyle = FlatStyle.Flat;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Navy;
            lblPassword.Location = new Point(18, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.Navy;
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Cursor = Cursors.IBeam;
            textBoxUserName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.ForeColor = Color.Transparent;
            textBoxUserName.Location = new Point(119, 87);
            textBoxUserName.Margin = new Padding(3, 2, 3, 2);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(287, 22);
            textBoxUserName.TabIndex = 4;
            textBoxUserName.Text = "Username";
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.Navy;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.Transparent;
            textBoxPassword.Location = new Point(119, 129);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(287, 22);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Navy;
            btnSignIn.BackgroundImageLayout = ImageLayout.None;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.Transparent;
            btnSignIn.Location = new Point(119, 200);
            btnSignIn.Margin = new Padding(3, 2, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(287, 28);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPassword.ForeColor = Color.Navy;
            checkBoxShowPassword.Location = new Point(119, 166);
            checkBoxShowPassword.Margin = new Padding(3, 2, 3, 2);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(139, 21);
            checkBoxShowPassword.TabIndex = 7;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Navy;
            btnSignUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Transparent;
            btnSignUp.Location = new Point(119, 271);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(287, 28);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblDontHaveAnAccount
            // 
            lblDontHaveAnAccount.AutoSize = true;
            lblDontHaveAnAccount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDontHaveAnAccount.ForeColor = Color.Navy;
            lblDontHaveAnAccount.Location = new Point(119, 244);
            lblDontHaveAnAccount.Name = "lblDontHaveAnAccount";
            lblDontHaveAnAccount.Size = new Size(183, 17);
            lblDontHaveAnAccount.TabIndex = 9;
            lblDontHaveAnAccount.Text = "Don't Have an Account?";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Navy;
            flowLayoutPanel1.Location = new Point(585, -6);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(18, 403);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(119, 316);
            label1.Name = "label1";
            label1.Size = new Size(451, 17);
            label1.TabIndex = 12;
            label1.Text = "Forgot your username or password? Click below to change it.";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(119, 345);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(287, 28);
            button1.TabIndex = 13;
            button1.Text = "Change ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(633, 384);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblDontHaveAnAccount);
            Controls.Add(btnSignUp);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(btnSignIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSignIn";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button btnSignIn;
        private CheckBox checkBoxShowPassword;
        private Button btnSignUp;
        private Label lblDontHaveAnAccount;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button1;
    }
}

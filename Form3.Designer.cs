namespace mutalibwinformapp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSignUp = new Label();
            lblUserName2 = new Label();
            textBoxUserName2 = new TextBox();
            lblPassword2 = new Label();
            textBoxPassword2 = new TextBox();
            btnSignUp2 = new Button();
            checkBoxShowPassword2 = new CheckBox();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = Color.Navy;
            lblSignUp.Location = new Point(133, 9);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(202, 55);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "Sign Up";
            // 
            // lblUserName2
            // 
            lblUserName2.AutoSize = true;
            lblUserName2.FlatStyle = FlatStyle.Flat;
            lblUserName2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName2.ForeColor = Color.Navy;
            lblUserName2.Location = new Point(29, 114);
            lblUserName2.Name = "lblUserName2";
            lblUserName2.Size = new Size(88, 17);
            lblUserName2.TabIndex = 3;
            lblUserName2.Text = "UserName:";
            // 
            // textBoxUserName2
            // 
            textBoxUserName2.BackColor = Color.Navy;
            textBoxUserName2.BorderStyle = BorderStyle.None;
            textBoxUserName2.Cursor = Cursors.IBeam;
            textBoxUserName2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName2.ForeColor = Color.Transparent;
            textBoxUserName2.Location = new Point(133, 114);
            textBoxUserName2.Margin = new Padding(3, 2, 3, 2);
            textBoxUserName2.Multiline = true;
            textBoxUserName2.Name = "textBoxUserName2";
            textBoxUserName2.Size = new Size(287, 22);
            textBoxUserName2.TabIndex = 5;
            textBoxUserName2.Text = "Username";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.FlatStyle = FlatStyle.Flat;
            lblPassword2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword2.ForeColor = Color.Navy;
            lblPassword2.Location = new Point(35, 166);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(82, 17);
            lblPassword2.TabIndex = 6;
            lblPassword2.Text = "Password:";
            // 
            // textBoxPassword2
            // 
            textBoxPassword2.BackColor = Color.Navy;
            textBoxPassword2.BorderStyle = BorderStyle.None;
            textBoxPassword2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword2.ForeColor = Color.Transparent;
            textBoxPassword2.Location = new Point(133, 166);
            textBoxPassword2.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword2.Multiline = true;
            textBoxPassword2.Name = "textBoxPassword2";
            textBoxPassword2.PasswordChar = '*';
            textBoxPassword2.Size = new Size(287, 22);
            textBoxPassword2.TabIndex = 7;
            textBoxPassword2.Text = "Password";
            // 
            // btnSignUp2
            // 
            btnSignUp2.BackColor = Color.Navy;
            btnSignUp2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp2.ForeColor = Color.Transparent;
            btnSignUp2.Location = new Point(133, 262);
            btnSignUp2.Margin = new Padding(3, 2, 3, 2);
            btnSignUp2.Name = "btnSignUp2";
            btnSignUp2.Size = new Size(287, 28);
            btnSignUp2.TabIndex = 9;
            btnSignUp2.Text = "Sign Up";
            btnSignUp2.UseVisualStyleBackColor = false;
            btnSignUp2.Click += btnSignUp2_Click;
            // 
            // checkBoxShowPassword2
            // 
            checkBoxShowPassword2.AutoSize = true;
            checkBoxShowPassword2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPassword2.ForeColor = Color.Navy;
            checkBoxShowPassword2.Location = new Point(133, 217);
            checkBoxShowPassword2.Margin = new Padding(3, 2, 3, 2);
            checkBoxShowPassword2.Name = "checkBoxShowPassword2";
            checkBoxShowPassword2.Size = new Size(139, 21);
            checkBoxShowPassword2.TabIndex = 10;
            checkBoxShowPassword2.Text = "Show Password";
            checkBoxShowPassword2.UseVisualStyleBackColor = true;
            checkBoxShowPassword2.CheckedChanged += checkBoxShowPassword2_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(526, 318);
            Controls.Add(checkBoxShowPassword2);
            Controls.Add(btnSignUp2);
            Controls.Add(textBoxPassword2);
            Controls.Add(lblPassword2);
            Controls.Add(textBoxUserName2);
            Controls.Add(lblUserName2);
            Controls.Add(lblSignUp);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUp;
        private Label lblUserName2;
        private TextBox textBoxUserName2;
        private Label lblPassword2;
        private TextBox textBoxPassword2;
        private Button btnSignUp2;
        private CheckBox checkBoxShowPassword2;
    }
}
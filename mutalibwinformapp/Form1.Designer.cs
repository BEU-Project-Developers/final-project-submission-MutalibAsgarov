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
            lbl_OpenProject = new Label();
            pictureBox1 = new PictureBox();
            lblUserName = new Label();
            lblPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            btnSignIn = new Button();
            checkBox1 = new CheckBox();
            btnSignUp = new Button();
            lblSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_OpenProject
            // 
            lbl_OpenProject.AutoSize = true;
            lbl_OpenProject.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OpenProject.Location = new Point(114, 77);
            lbl_OpenProject.Name = "lbl_OpenProject";
            lbl_OpenProject.Size = new Size(121, 39);
            lbl_OpenProject.TabIndex = 0;
            lbl_OpenProject.Text = "LOG IN";
            lbl_OpenProject.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pul;
            pictureBox1.Location = new Point(114, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(12, 153);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 18);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "UserName:";
            lblUserName.Click += lblUserName_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(12, 213);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 18);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(106, 137);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(248, 34);
            textBoxUserName.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(106, 204);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(248, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(6, 267);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(342, 38);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(6, 371);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(342, 38);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(12, 350);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(153, 18);
            lblSignUp.TabIndex = 9;
            lblSignUp.Text = "Don't have accont?";
            // 
            // FormSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(360, 440);
            Controls.Add(lblSignUp);
            Controls.Add(btnSignUp);
            Controls.Add(checkBox1);
            Controls.Add(btnSignIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_OpenProject);
            Name = "FormSignIn";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_OpenProject;
        private PictureBox pictureBox1;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button btnSignIn;
        private CheckBox checkBox1;
        private Button btnSignUp;
        private Label lblSignUp;
    }
}

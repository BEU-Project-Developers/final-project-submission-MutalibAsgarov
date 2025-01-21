namespace mutalibwinformapp
{
    partial class FormChangeUser
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
            btnSave = new Button();
            lblOldUserName = new Label();
            lblPassword = new Label();
            NewUserName = new Label();
            NewPassword = new Label();
            textBoxOldUsername = new TextBox();
            textBoxOldPassword = new TextBox();
            textBoxNewUsername = new TextBox();
            textBoxNewPassword = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(26, 224);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(339, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblOldUserName
            // 
            lblOldUserName.AutoSize = true;
            lblOldUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldUserName.ForeColor = Color.Navy;
            lblOldUserName.Location = new Point(26, 16);
            lblOldUserName.Name = "lblOldUserName";
            lblOldUserName.Size = new Size(33, 17);
            lblOldUserName.TabIndex = 1;
            lblOldUserName.Text = "Old";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Navy;
            lblPassword.Location = new Point(26, 57);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(33, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Old";
            // 
            // NewUserName
            // 
            NewUserName.AutoSize = true;
            NewUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewUserName.ForeColor = Color.Navy;
            NewUserName.Location = new Point(26, 136);
            NewUserName.Name = "NewUserName";
            NewUserName.Size = new Size(38, 17);
            NewUserName.TabIndex = 3;
            NewUserName.Text = "New";
            // 
            // NewPassword
            // 
            NewPassword.AutoSize = true;
            NewPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewPassword.ForeColor = Color.Navy;
            NewPassword.Location = new Point(26, 180);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(38, 17);
            NewPassword.TabIndex = 4;
            NewPassword.Text = "New";
            // 
            // textBoxOldUsername
            // 
            textBoxOldUsername.BackColor = Color.Navy;
            textBoxOldUsername.BorderStyle = BorderStyle.None;
            textBoxOldUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOldUsername.ForeColor = Color.Transparent;
            textBoxOldUsername.Location = new Point(126, 16);
            textBoxOldUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxOldUsername.Multiline = true;
            textBoxOldUsername.Name = "textBoxOldUsername";
            textBoxOldUsername.Size = new Size(239, 20);
            textBoxOldUsername.TabIndex = 5;
            textBoxOldUsername.Text = "Old Username";
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.BackColor = Color.Navy;
            textBoxOldPassword.BorderStyle = BorderStyle.None;
            textBoxOldPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOldPassword.ForeColor = Color.Transparent;
            textBoxOldPassword.Location = new Point(126, 57);
            textBoxOldPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxOldPassword.Multiline = true;
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.Size = new Size(239, 20);
            textBoxOldPassword.TabIndex = 6;
            textBoxOldPassword.Text = "Old Password";
            // 
            // textBoxNewUsername
            // 
            textBoxNewUsername.BackColor = Color.Navy;
            textBoxNewUsername.BorderStyle = BorderStyle.None;
            textBoxNewUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewUsername.ForeColor = Color.Transparent;
            textBoxNewUsername.Location = new Point(126, 136);
            textBoxNewUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxNewUsername.Multiline = true;
            textBoxNewUsername.Name = "textBoxNewUsername";
            textBoxNewUsername.Size = new Size(239, 20);
            textBoxNewUsername.TabIndex = 7;
            textBoxNewUsername.Text = "New Username";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BackColor = Color.Navy;
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.ForeColor = Color.Transparent;
            textBoxNewPassword.Location = new Point(126, 180);
            textBoxNewPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(239, 20);
            textBoxNewPassword.TabIndex = 8;
            textBoxNewPassword.Text = "New Password";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Navy;
            flowLayoutPanel1.Location = new Point(30, 104);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(335, 11);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Image = Properties.Resources._4122901;
            pictureBox1.Location = new Point(74, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = Properties.Resources.icon;
            pictureBox2.Location = new Point(74, 53);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Navy;
            pictureBox3.Image = Properties.Resources._4122901;
            pictureBox3.Location = new Point(74, 134);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Navy;
            pictureBox4.Image = Properties.Resources.icon;
            pictureBox4.Location = new Point(74, 177);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // FormChangeUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(412, 288);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxNewUsername);
            Controls.Add(textBoxOldPassword);
            Controls.Add(textBoxOldUsername);
            Controls.Add(NewPassword);
            Controls.Add(NewUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblOldUserName);
            Controls.Add(btnSave);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChangeUser";
            Text = "Change User";
            Load += FormChangeUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblOldUserName;
        private Label lblPassword;
        private Label NewUserName;
        private Label NewPassword;
        private TextBox textBoxOldUsername;
        private TextBox textBoxOldPassword;
        private TextBox textBoxNewUsername;
        private TextBox textBoxNewPassword;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
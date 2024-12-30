namespace mutalibwinformapp
{
    partial class formHome
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
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            listboxExpences = new ListBox();
            listBoxIncome = new ListBox();
            button2 = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(189, 85);
            lbl.Name = "lbl";
            lbl.Size = new Size(110, 20);
            lbl.TabIndex = 0;
            lbl.Text = "Total expences:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 301);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Total incomes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 85);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "total expence";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 301);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Total income";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 20);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(189, 53);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 8;
            button1.Text = "Add to Expences";
            button1.UseVisualStyleBackColor = true;
            // 
            // listboxExpences
            // 
            listboxExpences.FormattingEnabled = true;
            listboxExpences.Location = new Point(12, 20);
            listboxExpences.Name = "listboxExpences";
            listboxExpences.Size = new Size(146, 204);
            listboxExpences.TabIndex = 9;
            // 
            // listBoxIncome
            // 
            listBoxIncome.FormattingEnabled = true;
            listBoxIncome.Location = new Point(12, 230);
            listBoxIncome.Name = "listBoxIncome";
            listBoxIncome.Size = new Size(146, 204);
            listBoxIncome.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(189, 269);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 12;
            button2.Text = "Add to Incomes";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 414);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 13;
            label1.Text = "Total budget:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 414);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 14;
            label5.Text = "Total budget";
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(421, 450);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBoxIncome);
            Controls.Add(listboxExpences);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl);
            Name = "formHome";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button button1;
        private ListBox listboxExpences;
        private ListBox listBoxIncome;
        private Button button2;
        private Label label1;
        private Label label5;
    }
}
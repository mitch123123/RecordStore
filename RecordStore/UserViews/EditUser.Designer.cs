﻿namespace homework9
{
    partial class EditUser
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
            this.components = new System.ComponentModel.Container();
            this.submitchangesBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.ErrorLBL = new System.Windows.Forms.Label();
            this.TimeLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitchangesBtn
            // 
            this.submitchangesBtn.Location = new System.Drawing.Point(215, 220);
            this.submitchangesBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.submitchangesBtn.Name = "submitchangesBtn";
            this.submitchangesBtn.Size = new System.Drawing.Size(136, 30);
            this.submitchangesBtn.TabIndex = 24;
            this.submitchangesBtn.Text = "Submit Changes";
            this.submitchangesBtn.UseVisualStyleBackColor = true;
            this.submitchangesBtn.Click += new System.EventHandler(this.submitchangesBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(131, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username: ";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(230, 72);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(105, 23);
            this.PasswordBox.TabIndex = 13;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(230, 106);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(105, 23);
            this.AgeBox.TabIndex = 14;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(230, 37);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(105, 23);
            this.UserNameBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(131, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Account Balance";
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(230, 141);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.ReadOnly = true;
            this.AccountBox.Size = new System.Drawing.Size(105, 23);
            this.AccountBox.TabIndex = 27;
            // 
            // ErrorLBL
            // 
            this.ErrorLBL.AutoSize = true;
            this.ErrorLBL.Location = new System.Drawing.Point(5, 7);
            this.ErrorLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrorLBL.Name = "ErrorLBL";
            this.ErrorLBL.Size = new System.Drawing.Size(0, 15);
            this.ErrorLBL.TabIndex = 29;
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Location = new System.Drawing.Point(386, 4);
            this.TimeLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(31, 15);
            this.TimeLBL.TabIndex = 30;
            this.TimeLBL.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(131, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Location";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(230, 175);
            this.locationBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(105, 23);
            this.locationBox.TabIndex = 31;
            this.locationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 289);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.TimeLBL);
            this.Controls.Add(this.ErrorLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.submitchangesBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.UserNameBox);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitchangesBtn;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox PasswordBox;
        private TextBox AgeBox;
        private TextBox UserNameBox;
        private Label label8;
        private TextBox AccountBox;
        private Label ErrorLBL;
        private Label TimeLBL;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private TextBox locationBox;
    }
}
namespace homework9
{
    partial class NewUser
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
            this.submitchangesBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.BackLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitchangesBtn
            // 
            this.submitchangesBtn.Location = new System.Drawing.Point(626, 561);
            this.submitchangesBtn.Name = "submitchangesBtn";
            this.submitchangesBtn.Size = new System.Drawing.Size(286, 58);
            this.submitchangesBtn.TabIndex = 9;
            this.submitchangesBtn.Text = "submit";
            this.submitchangesBtn.UseVisualStyleBackColor = true;
            this.submitchangesBtn.Click += new System.EventHandler(this.submitchangesBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Account Balance:";
            // 
            // BalanceBox
            // 
            this.BalanceBox.Location = new System.Drawing.Point(643, 371);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.ReadOnly = true;
            this.BalanceBox.Size = new System.Drawing.Size(250, 23);
            this.BalanceBox.TabIndex = 7;
            this.BalanceBox.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username: ";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(643, 212);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 23);
            this.PasswordBox.TabIndex = 2;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(643, 295);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(250, 23);
            this.AgeBox.TabIndex = 6;
            this.AgeBox.TextChanged += new System.EventHandler(this.AgeBox_TextChanged);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(643, 138);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(250, 23);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Location = new System.Drawing.Point(62, 776);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.ErrorLbl.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Location:";
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(643, 447);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.ReadOnly = true;
            this.LocationBox.Size = new System.Drawing.Size(250, 23);
            this.LocationBox.TabIndex = 8;
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BackLbl.Location = new System.Drawing.Point(44, 676);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(79, 15);
            this.BackLbl.TabIndex = 45;
            this.BackLbl.Text = "Back to Login";
            this.BackLbl.Click += new System.EventHandler(this.BackLbl_Click);
            // 
            // NewUser
            // 
            this.ClientSize = new System.Drawing.Size(1476, 762);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.submitchangesBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BalanceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.UserNameBox);
            this.Name = "NewUser";
            this.Text = "new user";
            this.Load += new System.EventHandler(this.NewUser_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Button submitchangesBtn;
        private Label label6;
        private TextBox BalanceBox;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox PasswordBox;
        private TextBox AgeBox;
        private TextBox UserNameBox;
        private Label ErrorLbl;
        private Label label8;
        private TextBox LocationBox;
        private Label BackLbl;
    }
}
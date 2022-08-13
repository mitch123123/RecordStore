namespace homework9
{
    partial class login
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUserLBL = new System.Windows.Forms.Label();
            this.ErrorLBL = new System.Windows.Forms.Label();
            this.timeLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(345, 385);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(188, 58);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(324, 163);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(250, 47);
            this.UsernameTxtBox.TabIndex = 1;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Location = new System.Drawing.Point(324, 285);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '*';
            this.PassTxtBox.Size = new System.Drawing.Size(250, 47);
            this.PassTxtBox.TabIndex = 2;
            this.PassTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // NewUserLBL
            // 
            this.NewUserLBL.AutoSize = true;
            this.NewUserLBL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NewUserLBL.Location = new System.Drawing.Point(84, 463);
            this.NewUserLBL.Name = "NewUserLBL";
            this.NewUserLBL.Size = new System.Drawing.Size(159, 41);
            this.NewUserLBL.TabIndex = 6;
            this.NewUserLBL.Text = "New User?";
            this.NewUserLBL.Click += new System.EventHandler(this.NewUserLBL_Click);
            // 
            // ErrorLBL
            // 
            this.ErrorLBL.AutoSize = true;
            this.ErrorLBL.Location = new System.Drawing.Point(12, 9);
            this.ErrorLBL.Name = "ErrorLBL";
            this.ErrorLBL.Size = new System.Drawing.Size(0, 41);
            this.ErrorLBL.TabIndex = 7;
            // 
            // timeLBL
            // 
            this.timeLBL.AutoSize = true;
            this.timeLBL.Location = new System.Drawing.Point(620, 523);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(77, 41);
            this.timeLBL.TabIndex = 8;
            this.timeLBL.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 590);
            this.Controls.Add(this.timeLBL);
            this.Controls.Add(this.ErrorLBL);
            this.Controls.Add(this.NewUserLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.LoginBTN);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginBTN;
        private TextBox UsernameTxtBox;
        private TextBox PassTxtBox;
        private Label label1;
        private Label label2;
        private Label NewUserLBL;
        private Label ErrorLBL;
        private Label timeLBL;
        private System.Windows.Forms.Timer timer1;
    }
}
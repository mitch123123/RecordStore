namespace homework9
{
    partial class UserMenu
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
            this.TimeLBL = new System.Windows.Forms.Label();
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.EditPrfBtn = new System.Windows.Forms.Button();
            this.TransactionsBtn = new System.Windows.Forms.Button();
            this.InventoryBtn = new System.Windows.Forms.Button();
            this.LogOffBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ShopTvBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Location = new System.Drawing.Point(5, 3);
            this.TimeLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(33, 15);
            this.TimeLBL.TabIndex = 0;
            this.TimeLBL.Text = "Time";
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Location = new System.Drawing.Point(35, 37);
            this.welcomeLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(57, 15);
            this.welcomeLBL.TabIndex = 1;
            this.welcomeLBL.Text = "Welcome";
            // 
            // EditPrfBtn
            // 
            this.EditPrfBtn.Location = new System.Drawing.Point(88, 67);
            this.EditPrfBtn.Margin = new System.Windows.Forms.Padding(1);
            this.EditPrfBtn.Name = "EditPrfBtn";
            this.EditPrfBtn.Size = new System.Drawing.Size(131, 30);
            this.EditPrfBtn.TabIndex = 2;
            this.EditPrfBtn.Text = "Edit Profile";
            this.EditPrfBtn.UseVisualStyleBackColor = true;
            this.EditPrfBtn.Click += new System.EventHandler(this.EditPrfBtn_Click);
            // 
            // TransactionsBtn
            // 
            this.TransactionsBtn.Location = new System.Drawing.Point(88, 112);
            this.TransactionsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.TransactionsBtn.Name = "TransactionsBtn";
            this.TransactionsBtn.Size = new System.Drawing.Size(131, 30);
            this.TransactionsBtn.TabIndex = 3;
            this.TransactionsBtn.Text = "Check Transactions";
            this.TransactionsBtn.UseVisualStyleBackColor = true;
            this.TransactionsBtn.Click += new System.EventHandler(this.TransactionsBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Location = new System.Drawing.Point(88, 161);
            this.InventoryBtn.Margin = new System.Windows.Forms.Padding(1);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(131, 30);
            this.InventoryBtn.TabIndex = 4;
            this.InventoryBtn.Text = "Your Inventory";
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // LogOffBtn
            // 
            this.LogOffBtn.Location = new System.Drawing.Point(193, 224);
            this.LogOffBtn.Margin = new System.Windows.Forms.Padding(1);
            this.LogOffBtn.Name = "LogOffBtn";
            this.LogOffBtn.Size = new System.Drawing.Size(131, 36);
            this.LogOffBtn.TabIndex = 5;
            this.LogOffBtn.Text = "log out";
            this.LogOffBtn.UseVisualStyleBackColor = true;
            this.LogOffBtn.Click += new System.EventHandler(this.LogOffBtn_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(301, 67);
            this.ShopBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(131, 30);
            this.ShopBtn.TabIndex = 6;
            this.ShopBtn.Text = "Shop for Movies";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShopTvBtn
            // 
            this.ShopTvBtn.Location = new System.Drawing.Point(301, 112);
            this.ShopTvBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ShopTvBtn.Name = "ShopTvBtn";
            this.ShopTvBtn.Size = new System.Drawing.Size(131, 30);
            this.ShopTvBtn.TabIndex = 7;
            this.ShopTvBtn.Text = "Search Everything";
            this.ShopTvBtn.UseVisualStyleBackColor = true;
            this.ShopTvBtn.Click += new System.EventHandler(this.ShopTvBtn_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 311);
            this.Controls.Add(this.ShopTvBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.LogOffBtn);
            this.Controls.Add(this.InventoryBtn);
            this.Controls.Add(this.TransactionsBtn);
            this.Controls.Add(this.EditPrfBtn);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.TimeLBL);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimeLBL;
        private Label welcomeLBL;
        private Button EditPrfBtn;
        private Button TransactionsBtn;
        private Button InventoryBtn;
        private Button LogOffBtn;
        private Button ShopBtn;
        private System.Windows.Forms.Timer timer1;
        private Button ShopTvBtn;
    }
}
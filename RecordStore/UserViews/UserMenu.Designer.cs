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
            this.SearchMovieBtn = new System.Windows.Forms.Button();
            this.ReturnMovieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Location = new System.Drawing.Point(12, 9);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(83, 41);
            this.TimeLBL.TabIndex = 0;
            this.TimeLBL.Text = "Time";
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Location = new System.Drawing.Point(86, 100);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(142, 41);
            this.welcomeLBL.TabIndex = 1;
            this.welcomeLBL.Text = "Welcome";
            // 
            // EditPrfBtn
            // 
            this.EditPrfBtn.Location = new System.Drawing.Point(213, 208);
            this.EditPrfBtn.Name = "EditPrfBtn";
            this.EditPrfBtn.Size = new System.Drawing.Size(317, 58);
            this.EditPrfBtn.TabIndex = 2;
            this.EditPrfBtn.Text = "Edit Profile";
            this.EditPrfBtn.UseVisualStyleBackColor = true;
            this.EditPrfBtn.Click += new System.EventHandler(this.EditPrfBtn_Click);
            // 
            // TransactionsBtn
            // 
            this.TransactionsBtn.Location = new System.Drawing.Point(213, 305);
            this.TransactionsBtn.Name = "TransactionsBtn";
            this.TransactionsBtn.Size = new System.Drawing.Size(317, 58);
            this.TransactionsBtn.TabIndex = 3;
            this.TransactionsBtn.Text = "Check Transactions";
            this.TransactionsBtn.UseVisualStyleBackColor = true;
            this.TransactionsBtn.Click += new System.EventHandler(this.TransactionsBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Location = new System.Drawing.Point(213, 395);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(317, 58);
            this.InventoryBtn.TabIndex = 4;
            this.InventoryBtn.Text = "Your Inventory";
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // LogOffBtn
            // 
            this.LogOffBtn.Location = new System.Drawing.Point(468, 611);
            this.LogOffBtn.Name = "LogOffBtn";
            this.LogOffBtn.Size = new System.Drawing.Size(317, 58);
            this.LogOffBtn.TabIndex = 5;
            this.LogOffBtn.Text = "log out";
            this.LogOffBtn.UseVisualStyleBackColor = true;
            this.LogOffBtn.Click += new System.EventHandler(this.LogOffBtn_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(731, 208);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(317, 58);
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
            // SearchMovieBtn
            // 
            this.SearchMovieBtn.Location = new System.Drawing.Point(731, 305);
            this.SearchMovieBtn.Name = "SearchMovieBtn";
            this.SearchMovieBtn.Size = new System.Drawing.Size(317, 58);
            this.SearchMovieBtn.TabIndex = 7;
            this.SearchMovieBtn.Text = "Search Movies";
            this.SearchMovieBtn.UseVisualStyleBackColor = true;
            this.SearchMovieBtn.Click += new System.EventHandler(this.SearchMovieBtn_Click);
            // 
            // ReturnMovieBtn
            // 
            this.ReturnMovieBtn.Location = new System.Drawing.Point(731, 395);
            this.ReturnMovieBtn.Name = "ReturnMovieBtn";
            this.ReturnMovieBtn.Size = new System.Drawing.Size(317, 58);
            this.ReturnMovieBtn.TabIndex = 8;
            this.ReturnMovieBtn.Text = "Return Movies";
            this.ReturnMovieBtn.UseVisualStyleBackColor = true;
            this.ReturnMovieBtn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 850);
            this.Controls.Add(this.ReturnMovieBtn);
            this.Controls.Add(this.SearchMovieBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.LogOffBtn);
            this.Controls.Add(this.InventoryBtn);
            this.Controls.Add(this.TransactionsBtn);
            this.Controls.Add(this.EditPrfBtn);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.TimeLBL);
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
        private Button SearchMovieBtn;
        private Button ReturnMovieBtn;
    }
}
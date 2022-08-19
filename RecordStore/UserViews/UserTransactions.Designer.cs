namespace MovieStore
{
    partial class UserTransactions
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.FilterAscBtn = new System.Windows.Forms.Button();
            this.TransactionsList = new System.Windows.Forms.ListBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.LocationRdo = new System.Windows.Forms.RadioButton();
            this.PriceRdo = new System.Windows.Forms.RadioButton();
            this.DateRdo = new System.Windows.Forms.RadioButton();
            this.UserBalanceLbl = new System.Windows.Forms.Label();
            this.FilterDscBtn = new System.Windows.Forms.Button();
            this.Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(35, 961);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(188, 58);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FilterAscBtn
            // 
            this.FilterAscBtn.Location = new System.Drawing.Point(1135, 7);
            this.FilterAscBtn.Name = "FilterAscBtn";
            this.FilterAscBtn.Size = new System.Drawing.Size(275, 58);
            this.FilterAscBtn.TabIndex = 1;
            this.FilterAscBtn.Text = "Filter Ascending";
            this.FilterAscBtn.UseVisualStyleBackColor = true;
            this.FilterAscBtn.Click += new System.EventHandler(this.FilterAscBtn_Click);
            // 
            // TransactionsList
            // 
            this.TransactionsList.FormattingEnabled = true;
            this.TransactionsList.ItemHeight = 41;
            this.TransactionsList.Location = new System.Drawing.Point(12, 150);
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.Size = new System.Drawing.Size(2541, 742);
            this.TransactionsList.TabIndex = 3;
            this.TransactionsList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TransactionsList_Format);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(15, 24);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(97, 41);
            this.UserLbl.TabIndex = 4;
            this.UserLbl.Text = "label1";
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.LocationRdo);
            this.Filters.Controls.Add(this.PriceRdo);
            this.Filters.Controls.Add(this.DateRdo);
            this.Filters.Location = new System.Drawing.Point(567, -3);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(551, 120);
            this.Filters.TabIndex = 5;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filter By:";
            // 
            // LocationRdo
            // 
            this.LocationRdo.AutoSize = true;
            this.LocationRdo.Location = new System.Drawing.Point(342, 46);
            this.LocationRdo.Name = "LocationRdo";
            this.LocationRdo.Size = new System.Drawing.Size(168, 45);
            this.LocationRdo.TabIndex = 2;
            this.LocationRdo.Text = "Location";
            this.LocationRdo.UseVisualStyleBackColor = true;
            // 
            // PriceRdo
            // 
            this.PriceRdo.AutoSize = true;
            this.PriceRdo.Location = new System.Drawing.Point(177, 46);
            this.PriceRdo.Name = "PriceRdo";
            this.PriceRdo.Size = new System.Drawing.Size(119, 45);
            this.PriceRdo.TabIndex = 1;
            this.PriceRdo.Text = "Price";
            this.PriceRdo.UseVisualStyleBackColor = true;
            // 
            // DateRdo
            // 
            this.DateRdo.AutoSize = true;
            this.DateRdo.Checked = true;
            this.DateRdo.Location = new System.Drawing.Point(18, 46);
            this.DateRdo.Name = "DateRdo";
            this.DateRdo.Size = new System.Drawing.Size(117, 45);
            this.DateRdo.TabIndex = 0;
            this.DateRdo.TabStop = true;
            this.DateRdo.Text = "Date";
            this.DateRdo.UseVisualStyleBackColor = true;
            // 
            // UserBalanceLbl
            // 
            this.UserBalanceLbl.AutoSize = true;
            this.UserBalanceLbl.Location = new System.Drawing.Point(15, 71);
            this.UserBalanceLbl.Name = "UserBalanceLbl";
            this.UserBalanceLbl.Size = new System.Drawing.Size(97, 41);
            this.UserBalanceLbl.TabIndex = 13;
            this.UserBalanceLbl.Text = "label5";
            // 
            // FilterDscBtn
            // 
            this.FilterDscBtn.Location = new System.Drawing.Point(1135, 86);
            this.FilterDscBtn.Name = "FilterDscBtn";
            this.FilterDscBtn.Size = new System.Drawing.Size(275, 58);
            this.FilterDscBtn.TabIndex = 14;
            this.FilterDscBtn.Text = "Filter Descending";
            this.FilterDscBtn.UseVisualStyleBackColor = true;
            this.FilterDscBtn.Click += new System.EventHandler(this.FilterDscBtn_Click);
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2626, 1017);
            this.Controls.Add(this.FilterDscBtn);
            this.Controls.Add(this.UserBalanceLbl);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TransactionsList);
            this.Controls.Add(this.FilterAscBtn);
            this.Controls.Add(this.BackBtn);
            this.Name = "UserTransactions";
            this.Text = "UserTransactions";
            this.Load += new System.EventHandler(this.UserTransactions_Load);
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn;
        private Button FilterAscBtn;
        private ListBox TransactionsList;
        private Label UserLbl;
        private GroupBox Filters;
        private RadioButton LocationRdo;
        private RadioButton PriceRdo;
        private RadioButton DateRdo;
        private Label UserBalanceLbl;
        private Button FilterDscBtn;
    }
}
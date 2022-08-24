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
            this.BackBtn.Location = new System.Drawing.Point(10, 373);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(77, 21);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FilterAscBtn
            // 
            this.FilterAscBtn.Location = new System.Drawing.Point(467, 3);
            this.FilterAscBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FilterAscBtn.Name = "FilterAscBtn";
            this.FilterAscBtn.Size = new System.Drawing.Size(113, 21);
            this.FilterAscBtn.TabIndex = 1;
            this.FilterAscBtn.Text = "Filter Ascending";
            this.FilterAscBtn.UseVisualStyleBackColor = true;
            this.FilterAscBtn.Click += new System.EventHandler(this.FilterAscBtn_Click);
            // 
            // TransactionsList
            // 
            this.TransactionsList.FormattingEnabled = true;
            this.TransactionsList.ItemHeight = 15;
            this.TransactionsList.Location = new System.Drawing.Point(5, 55);
            this.TransactionsList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.Size = new System.Drawing.Size(1206, 304);
            this.TransactionsList.TabIndex = 3;
            this.TransactionsList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TransactionsList_Format);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(6, 9);
            this.UserLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(38, 15);
            this.UserLbl.TabIndex = 4;
            this.UserLbl.Text = "label1";
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.LocationRdo);
            this.Filters.Controls.Add(this.PriceRdo);
            this.Filters.Controls.Add(this.DateRdo);
            this.Filters.Location = new System.Drawing.Point(233, -1);
            this.Filters.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Filters.Name = "Filters";
            this.Filters.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Filters.Size = new System.Drawing.Size(227, 44);
            this.Filters.TabIndex = 5;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filter By:";
            // 
            // LocationRdo
            // 
            this.LocationRdo.AutoSize = true;
            this.LocationRdo.Location = new System.Drawing.Point(141, 17);
            this.LocationRdo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LocationRdo.Name = "LocationRdo";
            this.LocationRdo.Size = new System.Drawing.Size(71, 19);
            this.LocationRdo.TabIndex = 2;
            this.LocationRdo.Text = "Location";
            this.LocationRdo.UseVisualStyleBackColor = true;
            // 
            // PriceRdo
            // 
            this.PriceRdo.AutoSize = true;
            this.PriceRdo.Location = new System.Drawing.Point(73, 17);
            this.PriceRdo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PriceRdo.Name = "PriceRdo";
            this.PriceRdo.Size = new System.Drawing.Size(51, 19);
            this.PriceRdo.TabIndex = 1;
            this.PriceRdo.Text = "Price";
            this.PriceRdo.UseVisualStyleBackColor = true;
            // 
            // DateRdo
            // 
            this.DateRdo.AutoSize = true;
            this.DateRdo.Checked = true;
            this.DateRdo.Location = new System.Drawing.Point(7, 17);
            this.DateRdo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DateRdo.Name = "DateRdo";
            this.DateRdo.Size = new System.Drawing.Size(49, 19);
            this.DateRdo.TabIndex = 0;
            this.DateRdo.TabStop = true;
            this.DateRdo.Text = "Date";
            this.DateRdo.UseVisualStyleBackColor = true;
            // 
            // UserBalanceLbl
            // 
            this.UserBalanceLbl.AutoSize = true;
            this.UserBalanceLbl.Location = new System.Drawing.Point(6, 26);
            this.UserBalanceLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UserBalanceLbl.Name = "UserBalanceLbl";
            this.UserBalanceLbl.Size = new System.Drawing.Size(38, 15);
            this.UserBalanceLbl.TabIndex = 13;
            this.UserBalanceLbl.Text = "label5";
            // 
            // FilterDscBtn
            // 
            this.FilterDscBtn.Location = new System.Drawing.Point(467, 31);
            this.FilterDscBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FilterDscBtn.Name = "FilterDscBtn";
            this.FilterDscBtn.Size = new System.Drawing.Size(113, 21);
            this.FilterDscBtn.TabIndex = 14;
            this.FilterDscBtn.Text = "Filter Descending";
            this.FilterDscBtn.UseVisualStyleBackColor = true;
            this.FilterDscBtn.Click += new System.EventHandler(this.FilterDscBtn_Click);
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 442);
            this.Controls.Add(this.FilterDscBtn);
            this.Controls.Add(this.UserBalanceLbl);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TransactionsList);
            this.Controls.Add(this.FilterAscBtn);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
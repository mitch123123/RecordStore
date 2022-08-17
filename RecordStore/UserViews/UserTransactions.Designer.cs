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
            this.FilterBtn = new System.Windows.Forms.Button();
            this.TransactionsList = new System.Windows.Forms.ListBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.DateRdo = new System.Windows.Forms.RadioButton();
            this.PriceRdo = new System.Windows.Forms.RadioButton();
            this.LocationRdo = new System.Windows.Forms.RadioButton();
            this.Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(38, 926);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(188, 58);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(1401, 31);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(188, 58);
            this.FilterBtn.TabIndex = 1;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // TransactionsList
            // 
            this.TransactionsList.FormattingEnabled = true;
            this.TransactionsList.ItemHeight = 41;
            this.TransactionsList.Location = new System.Drawing.Point(1, 115);
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.Size = new System.Drawing.Size(1671, 742);
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
            this.Filters.Size = new System.Drawing.Size(751, 120);
            this.Filters.TabIndex = 5;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filter By:";
            // 
            // DateRdo
            // 
            this.DateRdo.AutoSize = true;
            this.DateRdo.Location = new System.Drawing.Point(8, 52);
            this.DateRdo.Name = "DateRdo";
            this.DateRdo.Size = new System.Drawing.Size(117, 45);
            this.DateRdo.TabIndex = 0;
            this.DateRdo.TabStop = true;
            this.DateRdo.Text = "Date";
            this.DateRdo.UseVisualStyleBackColor = true;
            // 
            // PriceRdo
            // 
            this.PriceRdo.AutoSize = true;
            this.PriceRdo.Location = new System.Drawing.Point(241, 52);
            this.PriceRdo.Name = "PriceRdo";
            this.PriceRdo.Size = new System.Drawing.Size(119, 45);
            this.PriceRdo.TabIndex = 1;
            this.PriceRdo.TabStop = true;
            this.PriceRdo.Text = "Price";
            this.PriceRdo.UseVisualStyleBackColor = true;
            // 
            // LocationRdo
            // 
            this.LocationRdo.AutoSize = true;
            this.LocationRdo.Location = new System.Drawing.Point(475, 52);
            this.LocationRdo.Name = "LocationRdo";
            this.LocationRdo.Size = new System.Drawing.Size(168, 45);
            this.LocationRdo.TabIndex = 2;
            this.LocationRdo.TabStop = true;
            this.LocationRdo.Text = "Location";
            this.LocationRdo.UseVisualStyleBackColor = true;
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1017);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TransactionsList);
            this.Controls.Add(this.FilterBtn);
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
        private Button FilterBtn;
        private ListBox TransactionsList;
        private Label UserLbl;
        private GroupBox Filters;
        private RadioButton LocationRdo;
        private RadioButton PriceRdo;
        private RadioButton DateRdo;
    }
}
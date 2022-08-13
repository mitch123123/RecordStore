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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TransactionsList = new System.Windows.Forms.ListBox();
            this.UserLbl = new System.Windows.Forms.Label();
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
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1401, 31);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(188, 58);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(1109, 37);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(250, 47);
            this.SearchBox.TabIndex = 2;
          
            // 
            // TransactionsList
            // 
            this.TransactionsList.FormattingEnabled = true;
            this.TransactionsList.ItemHeight = 41;
            this.TransactionsList.Location = new System.Drawing.Point(1, 115);
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.Size = new System.Drawing.Size(1671, 742);
            this.TransactionsList.TabIndex = 3;
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
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1017);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TransactionsList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BackBtn);
            this.Name = "UserTransactions";
            this.Text = "UserTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn;
        private Button SearchBtn;
        private TextBox SearchBox;
        private ListBox TransactionsList;
        private Label UserLbl;
    }
}
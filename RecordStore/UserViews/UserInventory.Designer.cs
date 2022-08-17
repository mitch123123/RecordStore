namespace MovieStore.UserViews
{
    partial class UserInventory
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
            this.UserLbl = new System.Windows.Forms.Label();
            this.InventoryList = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(137, 29);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(97, 41);
            this.UserLbl.TabIndex = 9;
            this.UserLbl.Text = "label1";
            // 
            // InventoryList
            // 
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.ItemHeight = 41;
            this.InventoryList.Location = new System.Drawing.Point(123, 120);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(3538, 742);
            this.InventoryList.TabIndex = 8;
            this.InventoryList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.InventoryList_Format);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(1231, 42);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(250, 47);
            this.SearchBox.TabIndex = 7;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1523, 36);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(188, 58);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(160, 931);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(188, 58);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3692, 1018);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.InventoryList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BackBtn);
            this.Name = "UserInventory";
            this.Text = "UserInventory";
            this.Load += new System.EventHandler(this.UserInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserLbl;
        private ListBox InventoryList;
        private TextBox SearchBox;
        private Button SearchBtn;
        private Button BackBtn;
    }
}
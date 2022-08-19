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
            this.DescLblHeader = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.Label();
            this.DescriptLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(37, 26);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(97, 41);
            this.UserLbl.TabIndex = 9;
            this.UserLbl.Text = "label1";
            // 
            // InventoryList
            // 
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.HorizontalScrollbar = true;
            this.InventoryList.ItemHeight = 41;
            this.InventoryList.Location = new System.Drawing.Point(23, 117);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.ScrollAlwaysVisible = true;
            this.InventoryList.Size = new System.Drawing.Size(1877, 742);
            this.InventoryList.TabIndex = 8;
            this.InventoryList.SelectedIndexChanged += new System.EventHandler(this.InventoryList_SelectedIndexChanged);
            this.InventoryList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.InventoryList_Format);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(1131, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(250, 47);
            this.SearchBox.TabIndex = 7;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1423, 33);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(188, 58);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(60, 928);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(188, 58);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DescLblHeader
            // 
            this.DescLblHeader.AutoSize = true;
            this.DescLblHeader.Location = new System.Drawing.Point(1906, 42);
            this.DescLblHeader.Name = "DescLblHeader";
            this.DescLblHeader.Size = new System.Drawing.Size(169, 41);
            this.DescLblHeader.TabIndex = 10;
            this.DescLblHeader.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSize = true;
            this.DescriptionBox.Location = new System.Drawing.Point(1925, 177);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(0, 41);
            this.DescriptionBox.TabIndex = 19;
            // 
            // DescriptLbl
            // 
            this.DescriptLbl.AutoSize = true;
            this.DescriptLbl.Location = new System.Drawing.Point(1906, 117);
            this.DescriptLbl.Name = "DescriptLbl";
            this.DescriptLbl.Size = new System.Drawing.Size(176, 41);
            this.DescriptLbl.TabIndex = 18;
            this.DescriptLbl.Text = "Description:";
            // 
            // UserInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2645, 1018);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DescriptLbl);
            this.Controls.Add(this.DescLblHeader);
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
        private Label DescLblHeader;
        private Label DescriptionBox;
        private Label DescriptLbl;
    }
}
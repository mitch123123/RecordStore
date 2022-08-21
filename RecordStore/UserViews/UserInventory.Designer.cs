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
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLbl.Location = new System.Drawing.Point(10, 3);
            this.UserLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(78, 32);
            this.UserLbl.TabIndex = 9;
            this.UserLbl.Text = "label1";
            // 
            // InventoryList
            // 
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.HorizontalScrollbar = true;
            this.InventoryList.ItemHeight = 15;
            this.InventoryList.Location = new System.Drawing.Point(9, 43);
            this.InventoryList.Margin = new System.Windows.Forms.Padding(1);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.ScrollAlwaysVisible = true;
            this.InventoryList.Size = new System.Drawing.Size(775, 334);
            this.InventoryList.TabIndex = 8;
            this.InventoryList.SelectedIndexChanged += new System.EventHandler(this.InventoryList_SelectedIndexChanged);
            this.InventoryList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.InventoryList_Format);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(466, 14);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(1);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(105, 23);
            this.SearchBox.TabIndex = 7;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(586, 12);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(77, 21);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(10, 591);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(135, 29);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back to Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DescLblHeader
            // 
            this.DescLblHeader.AutoSize = true;
            this.DescLblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescLblHeader.Location = new System.Drawing.Point(9, 388);
            this.DescLblHeader.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DescLblHeader.Name = "DescLblHeader";
            this.DescLblHeader.Size = new System.Drawing.Size(98, 21);
            this.DescLblHeader.TabIndex = 10;
            this.DescLblHeader.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSize = true;
            this.DescriptionBox.Location = new System.Drawing.Point(793, 65);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(0, 15);
            this.DescriptionBox.TabIndex = 19;
            // 
            // DescriptLbl
            // 
            this.DescriptLbl.AutoSize = true;
            this.DescriptLbl.Location = new System.Drawing.Point(9, 416);
            this.DescriptLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DescriptLbl.Name = "DescriptLbl";
            this.DescriptLbl.Size = new System.Drawing.Size(70, 15);
            this.DescriptLbl.TabIndex = 18;
            this.DescriptLbl.Text = "Description:";
            this.DescriptLbl.Click += new System.EventHandler(this.DescriptLbl_Click);
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(793, 10);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(573, 696);
            this.thumbnailBox.TabIndex = 20;
            this.thumbnailBox.TabStop = false;
            // 
            // UserInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 707);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DescriptLbl);
            this.Controls.Add(this.DescLblHeader);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.InventoryList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserInventory";
            this.Text = "UserInventory";
            this.Load += new System.EventHandler(this.UserInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
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
        private PictureBox thumbnailBox;
    }
}
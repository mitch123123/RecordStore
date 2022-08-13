namespace MovieStore.UserViews
{
    partial class UserCart
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
            this.CartItemsList = new System.Windows.Forms.ListBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.rtnBtn = new System.Windows.Forms.Button();
            this.RtnShopingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartItemsList
            // 
            this.CartItemsList.FormattingEnabled = true;
            this.CartItemsList.ItemHeight = 41;
            this.CartItemsList.Location = new System.Drawing.Point(25, 128);
            this.CartItemsList.Name = "CartItemsList";
            this.CartItemsList.Size = new System.Drawing.Size(949, 578);
            this.CartItemsList.TabIndex = 0;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(25, 20);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(212, 41);
            this.UserLbl.TabIndex = 1;
            this.UserLbl.Text = "Items in Users ";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(980, 128);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(217, 58);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove Item";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(980, 648);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(188, 58);
            this.CheckoutBtn.TabIndex = 3;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // rtnBtn
            // 
            this.rtnBtn.Location = new System.Drawing.Point(29, 774);
            this.rtnBtn.Name = "rtnBtn";
            this.rtnBtn.Size = new System.Drawing.Size(244, 58);
            this.rtnBtn.TabIndex = 4;
            this.rtnBtn.Text = "return to menu";
            this.rtnBtn.UseVisualStyleBackColor = true;
            this.rtnBtn.Click += new System.EventHandler(this.rtnBtn_Click);
            // 
            // RtnShopingBtn
            // 
            this.RtnShopingBtn.Location = new System.Drawing.Point(315, 774);
            this.RtnShopingBtn.Name = "RtnShopingBtn";
            this.RtnShopingBtn.Size = new System.Drawing.Size(234, 58);
            this.RtnShopingBtn.TabIndex = 5;
            this.RtnShopingBtn.Text = "Keep shopping";
            this.RtnShopingBtn.UseVisualStyleBackColor = true;
            this.RtnShopingBtn.Click += new System.EventHandler(this.RtnShopingBtn_Click);
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 879);
            this.Controls.Add(this.RtnShopingBtn);
            this.Controls.Add(this.rtnBtn);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.CartItemsList);
            this.Name = "UserCart";
            this.Text = "UserCart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox CartItemsList;
        private Label UserLbl;
        private Button RemoveBtn;
        private Button CheckoutBtn;
        private Button rtnBtn;
        private Button RtnShopingBtn;
    }
}
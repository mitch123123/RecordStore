namespace MovieStore.MovieStoreViews
{
    partial class CheckOut
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
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.CartItemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.errLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.UserBalanceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(9, 803);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(188, 58);
            this.CheckoutBtn.TabIndex = 0;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // CartItemList
            // 
            this.CartItemList.FormattingEnabled = true;
            this.CartItemList.ItemHeight = 41;
            this.CartItemList.Location = new System.Drawing.Point(12, 73);
            this.CartItemList.Name = "CartItemList";
            this.CartItemList.Size = new System.Drawing.Size(693, 578);
            this.CartItemList.TabIndex = 1;
            this.CartItemList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CartItemList_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(517, 657);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(188, 58);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(136, 657);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(66, 41);
            this.subtotalLbl.TabIndex = 7;
            this.subtotalLbl.Text = "sub";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(136, 696);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(57, 41);
            this.taxLbl.TabIndex = 8;
            this.taxLbl.Text = "tax";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(137, 737);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(56, 41);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "tot";
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.errLbl.Location = new System.Drawing.Point(437, 824);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(0, 41);
            this.errLbl.TabIndex = 10;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(717, 73);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(188, 58);
            this.RemoveBtn.TabIndex = 11;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // UserBalanceLbl
            // 
            this.UserBalanceLbl.AutoSize = true;
            this.UserBalanceLbl.Location = new System.Drawing.Point(231, 9);
            this.UserBalanceLbl.Name = "UserBalanceLbl";
            this.UserBalanceLbl.Size = new System.Drawing.Size(97, 41);
            this.UserBalanceLbl.TabIndex = 12;
            this.UserBalanceLbl.Text = "label5";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 873);
            this.Controls.Add(this.UserBalanceLbl);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.errLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.subtotalLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CartItemList);
            this.Controls.Add(this.CheckoutBtn);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CheckoutBtn;
        private ListBox CartItemList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CancelBtn;
        private Label subtotalLbl;
        private Label taxLbl;
        private Label totalLbl;
        private Label errLbl;
        private Button RemoveBtn;
        private Label UserBalanceLbl;
    }
}
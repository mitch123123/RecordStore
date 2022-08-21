namespace MovieStore.MovieStoreViews
{
    partial class SuccessNotice
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
            this.successLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // successLBL
            // 
            this.successLBL.AutoSize = true;
            this.successLBL.Location = new System.Drawing.Point(31, 37);
            this.successLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.successLBL.Name = "successLBL";
            this.successLBL.Size = new System.Drawing.Size(139, 15);
            this.successLBL.TabIndex = 0;
            this.successLBL.Text = "Successful checkout user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redirecting to menu.....";
            // 
            // SuccessNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.successLBL);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SuccessNotice";
            this.Text = "SuccessNotice";
            this.Load += new System.EventHandler(this.SuccessNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label successLBL;
        private Label label2;
    }
}
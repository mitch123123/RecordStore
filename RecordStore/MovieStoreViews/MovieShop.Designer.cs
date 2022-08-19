namespace MovieStore.MovieStoreViews
{
    partial class MovieShop
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.MoviesList = new System.Windows.Forms.ListBox();
            this.PopularBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchByActorRdo = new System.Windows.Forms.RadioButton();
            this.SearchByMovieRdo = new System.Windows.Forms.RadioButton();
            this.AddCartBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.RemoveFromCartBtn = new System.Windows.Forms.Button();
            this.CartList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.DescriptLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenresListbox = new System.Windows.Forms.CheckedListBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.HighestRateBtn = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.Label();
            this.ReleaseBtn = new System.Windows.Forms.Button();
            this.RevenueBtn = new System.Windows.Forms.Button();
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(518, 123);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(179, 49);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For Movies by:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(34, 63);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(478, 47);
            this.SearchBox.TabIndex = 2;
            // 
            // MoviesList
            // 
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.ItemHeight = 41;
            this.MoviesList.Location = new System.Drawing.Point(34, 268);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(1188, 660);
            this.MoviesList.TabIndex = 3;
            this.MoviesList.SelectedIndexChanged += new System.EventHandler(this.MoviesList_SelectedIndexChanged);
            this.MoviesList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.MoviesList_Format);
            this.MoviesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MoviesList_MouseDoubleClick);
            // 
            // PopularBtn
            // 
            this.PopularBtn.Location = new System.Drawing.Point(12, 191);
            this.PopularBtn.Name = "PopularBtn";
            this.PopularBtn.Size = new System.Drawing.Size(137, 58);
            this.PopularBtn.TabIndex = 4;
            this.PopularBtn.Text = "Popular";
            this.PopularBtn.UseVisualStyleBackColor = true;
            this.PopularBtn.Click += new System.EventHandler(this.PopularBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "explore by : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchByActorRdo);
            this.groupBox1.Controls.Add(this.SearchByMovieRdo);
            this.groupBox1.Location = new System.Drawing.Point(518, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SearchByActorRdo
            // 
            this.SearchByActorRdo.AutoSize = true;
            this.SearchByActorRdo.Location = new System.Drawing.Point(14, 64);
            this.SearchByActorRdo.Name = "SearchByActorRdo";
            this.SearchByActorRdo.Size = new System.Drawing.Size(126, 45);
            this.SearchByActorRdo.TabIndex = 8;
            this.SearchByActorRdo.Text = "Actor";
            this.SearchByActorRdo.UseVisualStyleBackColor = true;
            // 
            // SearchByMovieRdo
            // 
            this.SearchByMovieRdo.AutoSize = true;
            this.SearchByMovieRdo.Checked = true;
            this.SearchByMovieRdo.Location = new System.Drawing.Point(14, 17);
            this.SearchByMovieRdo.Name = "SearchByMovieRdo";
            this.SearchByMovieRdo.Size = new System.Drawing.Size(137, 45);
            this.SearchByMovieRdo.TabIndex = 7;
            this.SearchByMovieRdo.TabStop = true;
            this.SearchByMovieRdo.Text = "Movie";
            this.SearchByMovieRdo.UseVisualStyleBackColor = true;
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.Location = new System.Drawing.Point(1762, 796);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(316, 58);
            this.AddCartBtn.TabIndex = 7;
            this.AddCartBtn.Text = "Add to Cart";
            this.AddCartBtn.UseVisualStyleBackColor = true;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(1764, 1115);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(316, 58);
            this.MenuBtn.TabIndex = 8;
            this.MenuBtn.Text = "Back to menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // RemoveFromCartBtn
            // 
            this.RemoveFromCartBtn.Location = new System.Drawing.Point(1762, 737);
            this.RemoveFromCartBtn.Name = "RemoveFromCartBtn";
            this.RemoveFromCartBtn.Size = new System.Drawing.Size(316, 53);
            this.RemoveFromCartBtn.TabIndex = 9;
            this.RemoveFromCartBtn.Text = "Remove from cart";
            this.RemoveFromCartBtn.UseVisualStyleBackColor = true;
            this.RemoveFromCartBtn.Click += new System.EventHandler(this.RemoveFromCartBtn_Click);
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 41;
            this.CartList.Location = new System.Drawing.Point(1762, 320);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(318, 414);
            this.CartList.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1762, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "cart";
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.BackColor = System.Drawing.SystemColors.Info;
            this.CheckoutBtn.Location = new System.Drawing.Point(1764, 1012);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(316, 82);
            this.CheckoutBtn.TabIndex = 12;
            this.CheckoutBtn.Text = "Check Out";
            this.CheckoutBtn.UseVisualStyleBackColor = false;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // DescriptLbl
            // 
            this.DescriptLbl.AutoSize = true;
            this.DescriptLbl.Location = new System.Drawing.Point(39, 931);
            this.DescriptLbl.Name = "DescriptLbl";
            this.DescriptLbl.Size = new System.Drawing.Size(176, 41);
            this.DescriptLbl.TabIndex = 14;
            this.DescriptLbl.Text = "Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.GenresListbox);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(739, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1061, 250);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genres:";
            // 
            // GenresListbox
            // 
            this.GenresListbox.FormattingEnabled = true;
            this.GenresListbox.Location = new System.Drawing.Point(755, 31);
            this.GenresListbox.Name = "GenresListbox";
            this.GenresListbox.Size = new System.Drawing.Size(300, 224);
            this.GenresListbox.TabIndex = 2;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(145, 61);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(179, 47);
            this.DatePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "By year:";
            // 
            // HighestRateBtn
            // 
            this.HighestRateBtn.Location = new System.Drawing.Point(155, 191);
            this.HighestRateBtn.Name = "HighestRateBtn";
            this.HighestRateBtn.Size = new System.Drawing.Size(218, 58);
            this.HighestRateBtn.TabIndex = 16;
            this.HighestRateBtn.Text = "Highest Rated";
            this.HighestRateBtn.UseVisualStyleBackColor = true;
            this.HighestRateBtn.Click += new System.EventHandler(this.HighestRateBtn_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSize = true;
            this.DescriptionBox.Location = new System.Drawing.Point(39, 972);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(0, 41);
            this.DescriptionBox.TabIndex = 17;
            // 
            // ReleaseBtn
            // 
            this.ReleaseBtn.Location = new System.Drawing.Point(379, 191);
            this.ReleaseBtn.Name = "ReleaseBtn";
            this.ReleaseBtn.Size = new System.Drawing.Size(136, 58);
            this.ReleaseBtn.TabIndex = 18;
            this.ReleaseBtn.Text = "Release";
            this.ReleaseBtn.UseVisualStyleBackColor = true;
            this.ReleaseBtn.Click += new System.EventHandler(this.ReleaseBtn_Click);
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.Location = new System.Drawing.Point(521, 191);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Size = new System.Drawing.Size(160, 58);
            this.RevenueBtn.TabIndex = 19;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = true;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Location = new System.Drawing.Point(1238, 269);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(504, 501);
            this.ThumbnailBox.TabIndex = 20;
            this.ThumbnailBox.TabStop = false;
            // 
            // MovieShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2105, 1382);
            this.Controls.Add(this.ThumbnailBox);
            this.Controls.Add(this.RevenueBtn);
            this.Controls.Add(this.ReleaseBtn);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.HighestRateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DescriptLbl);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.RemoveFromCartBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.AddCartBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PopularBtn);
            this.Controls.Add(this.MoviesList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Name = "MovieShop";
            this.Text = "MovieShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchBtn;
        private Label label1;
        private TextBox SearchBox;
        private ListBox MoviesList;
        private Button PopularBtn;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton SearchByActorRdo;
        private RadioButton SearchByMovieRdo;
        private Button AddCartBtn;
        private Button MenuBtn;
        private Button RemoveFromCartBtn;
        private ListBox CartList;
        private Label label3;
        private Button CheckoutBtn;
        private Label DescriptLbl;
        private GroupBox groupBox2;
        private DateTimePicker DatePicker;
        private Label label4;
        private Button HighestRateBtn;
        private Label label5;
        private CheckedListBox GenresListbox;
        private Label DescriptionBox;
        private Button ReleaseBtn;
        private Button RevenueBtn;
        private PictureBox ThumbnailBox;
    }
}
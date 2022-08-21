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
            this.SearchBtn.Location = new System.Drawing.Point(11, 50);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(74, 22);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For Movies by:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(10, 25);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(1);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(199, 23);
            this.SearchBox.TabIndex = 2;
            // 
            // MoviesList
            // 
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.ItemHeight = 15;
            this.MoviesList.Location = new System.Drawing.Point(14, 114);
            this.MoviesList.Margin = new System.Windows.Forms.Padding(1);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(610, 244);
            this.MoviesList.TabIndex = 3;
            this.MoviesList.SelectedIndexChanged += new System.EventHandler(this.MoviesList_SelectedIndexChanged);
            this.MoviesList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.MoviesList_Format);
            this.MoviesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MoviesList_MouseDoubleClick);
            // 
            // PopularBtn
            // 
            this.PopularBtn.Location = new System.Drawing.Point(11, 89);
            this.PopularBtn.Margin = new System.Windows.Forms.Padding(1);
            this.PopularBtn.Name = "PopularBtn";
            this.PopularBtn.Size = new System.Drawing.Size(56, 21);
            this.PopularBtn.TabIndex = 4;
            this.PopularBtn.Text = "Popular";
            this.PopularBtn.UseVisualStyleBackColor = true;
            this.PopularBtn.Click += new System.EventHandler(this.PopularBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Explore by : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchByActorRdo);
            this.groupBox1.Controls.Add(this.SearchByMovieRdo);
            this.groupBox1.Location = new System.Drawing.Point(213, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(74, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SearchByActorRdo
            // 
            this.SearchByActorRdo.AutoSize = true;
            this.SearchByActorRdo.Location = new System.Drawing.Point(6, 27);
            this.SearchByActorRdo.Margin = new System.Windows.Forms.Padding(1);
            this.SearchByActorRdo.Name = "SearchByActorRdo";
            this.SearchByActorRdo.Size = new System.Drawing.Size(54, 19);
            this.SearchByActorRdo.TabIndex = 8;
            this.SearchByActorRdo.Text = "Actor";
            this.SearchByActorRdo.UseVisualStyleBackColor = true;
            // 
            // SearchByMovieRdo
            // 
            this.SearchByMovieRdo.AutoSize = true;
            this.SearchByMovieRdo.Checked = true;
            this.SearchByMovieRdo.Location = new System.Drawing.Point(6, 11);
            this.SearchByMovieRdo.Margin = new System.Windows.Forms.Padding(1);
            this.SearchByMovieRdo.Name = "SearchByMovieRdo";
            this.SearchByMovieRdo.Size = new System.Drawing.Size(58, 19);
            this.SearchByMovieRdo.TabIndex = 7;
            this.SearchByMovieRdo.TabStop = true;
            this.SearchByMovieRdo.Text = "Movie";
            this.SearchByMovieRdo.UseVisualStyleBackColor = true;
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.Location = new System.Drawing.Point(494, 360);
            this.AddCartBtn.Margin = new System.Windows.Forms.Padding(1);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(130, 21);
            this.AddCartBtn.TabIndex = 7;
            this.AddCartBtn.Text = "Add to Cart";
            this.AddCartBtn.UseVisualStyleBackColor = true;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(841, 472);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(1);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(130, 21);
            this.MenuBtn.TabIndex = 8;
            this.MenuBtn.Text = "Back to menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // RemoveFromCartBtn
            // 
            this.RemoveFromCartBtn.Location = new System.Drawing.Point(838, 270);
            this.RemoveFromCartBtn.Margin = new System.Windows.Forms.Padding(1);
            this.RemoveFromCartBtn.Name = "RemoveFromCartBtn";
            this.RemoveFromCartBtn.Size = new System.Drawing.Size(130, 23);
            this.RemoveFromCartBtn.TabIndex = 9;
            this.RemoveFromCartBtn.Text = "Remove from cart";
            this.RemoveFromCartBtn.UseVisualStyleBackColor = true;
            this.RemoveFromCartBtn.Click += new System.EventHandler(this.RemoveFromCartBtn_Click);
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 15;
            this.CartList.Location = new System.Drawing.Point(838, 114);
            this.CartList.Margin = new System.Windows.Forms.Padding(1);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(133, 154);
            this.CartList.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "cart";
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.BackColor = System.Drawing.SystemColors.Info;
            this.CheckoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckoutBtn.Location = new System.Drawing.Point(841, 434);
            this.CheckoutBtn.Margin = new System.Windows.Forms.Padding(1);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(130, 30);
            this.CheckoutBtn.TabIndex = 12;
            this.CheckoutBtn.Text = "Check Out";
            this.CheckoutBtn.UseVisualStyleBackColor = false;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // DescriptLbl
            // 
            this.DescriptLbl.AutoSize = true;
            this.DescriptLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptLbl.Location = new System.Drawing.Point(14, 359);
            this.DescriptLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DescriptLbl.Name = "DescriptLbl";
            this.DescriptLbl.Size = new System.Drawing.Size(93, 20);
            this.DescriptLbl.TabIndex = 14;
            this.DescriptLbl.Text = "Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.GenresListbox);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(304, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(523, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genres:";
            // 
            // GenresListbox
            // 
            this.GenresListbox.FormattingEnabled = true;
            this.GenresListbox.Location = new System.Drawing.Point(380, 18);
            this.GenresListbox.Margin = new System.Windows.Forms.Padding(1);
            this.GenresListbox.Name = "GenresListbox";
            this.GenresListbox.Size = new System.Drawing.Size(126, 76);
            this.GenresListbox.TabIndex = 2;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(60, 22);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(1);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(84, 23);
            this.DatePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "By year:";
            // 
            // HighestRateBtn
            // 
            this.HighestRateBtn.Location = new System.Drawing.Point(70, 89);
            this.HighestRateBtn.Margin = new System.Windows.Forms.Padding(1);
            this.HighestRateBtn.Name = "HighestRateBtn";
            this.HighestRateBtn.Size = new System.Drawing.Size(90, 21);
            this.HighestRateBtn.TabIndex = 16;
            this.HighestRateBtn.Text = "Highest Rated";
            this.HighestRateBtn.UseVisualStyleBackColor = true;
            this.HighestRateBtn.Click += new System.EventHandler(this.HighestRateBtn_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSize = true;
            this.DescriptionBox.Location = new System.Drawing.Point(14, 388);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(0, 15);
            this.DescriptionBox.TabIndex = 17;
            // 
            // ReleaseBtn
            // 
            this.ReleaseBtn.Location = new System.Drawing.Point(162, 89);
            this.ReleaseBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ReleaseBtn.Name = "ReleaseBtn";
            this.ReleaseBtn.Size = new System.Drawing.Size(56, 21);
            this.ReleaseBtn.TabIndex = 18;
            this.ReleaseBtn.Text = "Release";
            this.ReleaseBtn.UseVisualStyleBackColor = true;
            this.ReleaseBtn.Click += new System.EventHandler(this.ReleaseBtn_Click);
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.Location = new System.Drawing.Point(221, 89);
            this.RevenueBtn.Margin = new System.Windows.Forms.Padding(1);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Size = new System.Drawing.Size(66, 21);
            this.RevenueBtn.TabIndex = 19;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = true;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Location = new System.Drawing.Point(626, 114);
            this.ThumbnailBox.Margin = new System.Windows.Forms.Padding(1);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(201, 303);
            this.ThumbnailBox.TabIndex = 20;
            this.ThumbnailBox.TabStop = false;
            // 
            // MovieShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 506);
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
            this.Margin = new System.Windows.Forms.Padding(1);
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
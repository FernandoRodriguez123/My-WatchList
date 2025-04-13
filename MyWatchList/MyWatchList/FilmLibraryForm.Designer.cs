namespace MyWatchList
{
    partial class FilmLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmLibraryForm));
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.libraryLbl = new System.Windows.Forms.Label();
            this.brandPbx = new System.Windows.Forms.PictureBox();
            this.addLbl = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchPbx = new System.Windows.Forms.PictureBox();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemLbl = new System.Windows.Forms.Label();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.genreLbl = new System.Windows.Forms.Label();
            this.genreDropPbx = new System.Windows.Forms.PictureBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusDropPbx = new System.Windows.Forms.PictureBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterBtn = new System.Windows.Forms.Button();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.genrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDropPbx)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDropPbx)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navbarPanel.Controls.Add(this.searchTxb);
            this.navbarPanel.Controls.Add(this.searchPbx);
            this.navbarPanel.Controls.Add(this.searchPanel);
            this.navbarPanel.Controls.Add(this.addLbl);
            this.navbarPanel.Controls.Add(this.brandPbx);
            this.navbarPanel.Controls.Add(this.libraryLbl);
            this.navbarPanel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbarPanel.ForeColor = System.Drawing.Color.White;
            this.navbarPanel.Location = new System.Drawing.Point(-1, -2);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(801, 60);
            this.navbarPanel.TabIndex = 0;
            // 
            // libraryLbl
            // 
            this.libraryLbl.AutoSize = true;
            this.libraryLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLbl.Location = new System.Drawing.Point(337, 11);
            this.libraryLbl.Name = "libraryLbl";
            this.libraryLbl.Size = new System.Drawing.Size(154, 28);
            this.libraryLbl.TabIndex = 0;
            this.libraryLbl.Text = "DIRECTORIO SERIES";
            // 
            // brandPbx
            // 
            this.brandPbx.Image = ((System.Drawing.Image)(resources.GetObject("brandPbx.Image")));
            this.brandPbx.Location = new System.Drawing.Point(44, 4);
            this.brandPbx.Name = "brandPbx";
            this.brandPbx.Size = new System.Drawing.Size(100, 50);
            this.brandPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brandPbx.TabIndex = 1;
            this.brandPbx.TabStop = false;
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(497, 11);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(66, 28);
            this.addLbl.TabIndex = 2;
            this.addLbl.Text = "AÑADIR";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.Location = new System.Drawing.Point(569, 37);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(130, 2);
            this.searchPanel.TabIndex = 3;
            // 
            // searchPbx
            // 
            this.searchPbx.Image = ((System.Drawing.Image)(resources.GetObject("searchPbx.Image")));
            this.searchPbx.Location = new System.Drawing.Point(675, 11);
            this.searchPbx.Name = "searchPbx";
            this.searchPbx.Size = new System.Drawing.Size(24, 24);
            this.searchPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPbx.TabIndex = 4;
            this.searchPbx.TabStop = false;
            // 
            // searchTxb
            // 
            this.searchTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.searchTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxb.ForeColor = System.Drawing.Color.White;
            this.searchTxb.Location = new System.Drawing.Point(569, 14);
            this.searchTxb.Name = "searchTxb";
            this.searchTxb.Size = new System.Drawing.Size(100, 21);
            this.searchTxb.TabIndex = 5;
            this.searchTxb.Text = "Buscar...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(11, 251);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(91, 16);
            this.itemLbl.TabIndex = 2;
            this.itemLbl.Text = "Death Parade";
            // 
            // genrePanel
            // 
            this.genrePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.genrePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genrePanel.Controls.Add(this.genreDropPbx);
            this.genrePanel.Controls.Add(this.genreLbl);
            this.genrePanel.Location = new System.Drawing.Point(14, 64);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(90, 34);
            this.genrePanel.TabIndex = 3;
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.Location = new System.Drawing.Point(3, 3);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(50, 21);
            this.genreLbl.TabIndex = 0;
            this.genreLbl.Text = "Género";
            // 
            // genreDropPbx
            // 
            this.genreDropPbx.Image = global::MyWatchList.Properties.Resources.chevronDown;
            this.genreDropPbx.Location = new System.Drawing.Point(59, 1);
            this.genreDropPbx.Name = "genreDropPbx";
            this.genreDropPbx.Size = new System.Drawing.Size(24, 24);
            this.genreDropPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genreDropPbx.TabIndex = 1;
            this.genreDropPbx.TabStop = false;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanel.Controls.Add(this.statusDropPbx);
            this.statusPanel.Controls.Add(this.statusLbl);
            this.statusPanel.Location = new System.Drawing.Point(129, 64);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(90, 34);
            this.statusPanel.TabIndex = 4;
            // 
            // statusDropPbx
            // 
            this.statusDropPbx.Image = global::MyWatchList.Properties.Resources.chevronDown;
            this.statusDropPbx.Location = new System.Drawing.Point(59, 1);
            this.statusDropPbx.Name = "statusDropPbx";
            this.statusDropPbx.Size = new System.Drawing.Size(24, 24);
            this.statusDropPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusDropPbx.TabIndex = 1;
            this.statusDropPbx.TabStop = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(3, 3);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(46, 21);
            this.statusLbl.TabIndex = 0;
            this.statusLbl.Text = "Estado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ratingLbl);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(242, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 34);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyWatchList.Properties.Resources.chevronDown;
            this.pictureBox4.Location = new System.Drawing.Point(59, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 0;
            // 
            // ratingLbl
            // 
            this.ratingLbl.AutoSize = true;
            this.ratingLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLbl.Location = new System.Drawing.Point(3, 4);
            this.ratingLbl.Name = "ratingLbl";
            this.ratingLbl.Size = new System.Drawing.Size(46, 21);
            this.ratingLbl.TabIndex = 2;
            this.ratingLbl.Text = "Rating";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 163);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.Black;
            this.filterBtn.Location = new System.Drawing.Point(351, 64);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(84, 36);
            this.filterBtn.TabIndex = 6;
            this.filterBtn.Text = "FILTRAR";
            this.filterBtn.UseVisualStyleBackColor = false;
            // 
            // FilmLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.genrePanel);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navbarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilmLibraryForm";
            this.Text = "MyWatchList";
            this.Load += new System.EventHandler(this.FilmLibraryForm_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.genrePanel.ResumeLayout(false);
            this.genrePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDropPbx)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDropPbx)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Label libraryLbl;
        private System.Windows.Forms.PictureBox brandPbx;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchPbx;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Panel genrePanel;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.PictureBox genreDropPbx;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox statusDropPbx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label ratingLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button filterBtn;
    }
}
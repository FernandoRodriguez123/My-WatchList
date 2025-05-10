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
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.searchPbx = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.addLbl = new System.Windows.Forms.Label();
            this.brandPbx = new System.Windows.Forms.PictureBox();
            this.libraryLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemLbl = new System.Windows.Forms.Label();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.genreDropPbx = new System.Windows.Forms.PictureBox();
            this.genreLbl = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusDropPbx = new System.Windows.Forms.PictureBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ratingLbl = new System.Windows.Forms.Label();
            this.ratingDropPbx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSelectionPanel = new System.Windows.Forms.Panel();
            this.filterBtn = new System.Windows.Forms.Button();
            this.statusSelectionPanel = new System.Windows.Forms.Panel();
            this.ratingSelectionPanel = new System.Windows.Forms.Panel();
            this.orderSelectionPanel = new System.Windows.Forms.Panel();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderLbl = new System.Windows.Forms.Label();
            this.orderDropPbx = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.genrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDropPbx)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDropPbx)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDropPbx)).BeginInit();
            this.ratingSelectionPanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDropPbx)).BeginInit();
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
            this.navbarPanel.Size = new System.Drawing.Size(909, 60);
            this.navbarPanel.TabIndex = 0;
            // 
            // searchTxb
            // 
            this.searchTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.searchTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxb.ForeColor = System.Drawing.Color.White;
            this.searchTxb.Location = new System.Drawing.Point(750, 17);
            this.searchTxb.Name = "searchTxb";
            this.searchTxb.Size = new System.Drawing.Size(100, 21);
            this.searchTxb.TabIndex = 5;
            this.searchTxb.Text = "Buscar...";
            // 
            // searchPbx
            // 
            this.searchPbx.Image = System.Drawing.Image.FromFile(Images.Search);
            this.searchPbx.Location = new System.Drawing.Point(856, 14);
            this.searchPbx.Name = "searchPbx";
            this.searchPbx.Size = new System.Drawing.Size(24, 24);
            this.searchPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPbx.TabIndex = 4;
            this.searchPbx.TabStop = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.Location = new System.Drawing.Point(750, 40);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(130, 2);
            this.searchPanel.TabIndex = 3;
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(310, 10);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(66, 28);
            this.addLbl.TabIndex = 2;
            this.addLbl.Text = "AÑADIR";
            // 
            // brandPbx
            // 
            this.brandPbx.Image = System.Drawing.Image.FromFile(Images.MyWatchListTransparentIcon);
            this.brandPbx.Location = new System.Drawing.Point(44, 4);
            this.brandPbx.Name = "brandPbx";
            this.brandPbx.Size = new System.Drawing.Size(100, 50);
            this.brandPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brandPbx.TabIndex = 1;
            this.brandPbx.TabStop = false;
            // 
            // libraryLbl
            // 
            this.libraryLbl.AutoSize = true;
            this.libraryLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLbl.Location = new System.Drawing.Point(150, 11);
            this.libraryLbl.Name = "libraryLbl";
            this.libraryLbl.Size = new System.Drawing.Size(154, 28);
            this.libraryLbl.TabIndex = 0;
            this.libraryLbl.Text = "DIRECTORIO SERIES";
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
            // genreDropPbx
            // 
            this.genreDropPbx.Image = System.Drawing.Image.FromFile(Images.ChevronDown);
            this.genreDropPbx.Location = new System.Drawing.Point(59, 1);
            this.genreDropPbx.Name = "genreDropPbx";
            this.genreDropPbx.Size = new System.Drawing.Size(24, 24);
            this.genreDropPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genreDropPbx.TabIndex = 1;
            this.genreDropPbx.TabStop = false;
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
            this.statusDropPbx.Image = System.Drawing.Image.FromFile(Images.ChevronDown);
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
            this.panel3.Controls.Add(this.ratingDropPbx);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(236, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 34);
            this.panel3.TabIndex = 4;
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
            // ratingDropPbx
            // 
            this.ratingDropPbx.Image = System.Drawing.Image.FromFile(Images.ChevronDown);
            this.ratingDropPbx.Location = new System.Drawing.Point(59, 1);
            this.ratingDropPbx.Name = "ratingDropPbx";
            this.ratingDropPbx.Size = new System.Drawing.Size(24, 24);
            this.ratingDropPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ratingDropPbx.TabIndex = 1;
            this.ratingDropPbx.TabStop = false;
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
            // panelSelectionPanel
            // 
            this.panelSelectionPanel.BackColor = System.Drawing.Color.White;
            this.panelSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelectionPanel.Location = new System.Drawing.Point(14, 104);
            this.panelSelectionPanel.Name = "panelSelectionPanel";
            this.panelSelectionPanel.Size = new System.Drawing.Size(312, 252);
            this.panelSelectionPanel.TabIndex = 5;
            this.panelSelectionPanel.Visible = false;
            this.panelSelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.Black;
            this.filterBtn.Location = new System.Drawing.Point(458, 63);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(84, 36);
            this.filterBtn.TabIndex = 6;
            this.filterBtn.Text = "FILTRAR";
            this.filterBtn.UseVisualStyleBackColor = false;
            // 
            // statusSelectionPanel
            // 
            this.statusSelectionPanel.BackColor = System.Drawing.Color.White;
            this.statusSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusSelectionPanel.Location = new System.Drawing.Point(129, 104);
            this.statusSelectionPanel.Name = "statusSelectionPanel";
            this.statusSelectionPanel.Size = new System.Drawing.Size(312, 252);
            this.statusSelectionPanel.TabIndex = 6;
            // 
            // ratingSelectionPanel
            // 
            this.ratingSelectionPanel.BackColor = System.Drawing.Color.White;
            this.ratingSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingSelectionPanel.Controls.Add(this.orderSelectionPanel);
            this.ratingSelectionPanel.Location = new System.Drawing.Point(242, 100);
            this.ratingSelectionPanel.Name = "ratingSelectionPanel";
            this.ratingSelectionPanel.Size = new System.Drawing.Size(312, 252);
            this.ratingSelectionPanel.TabIndex = 6;
            this.ratingSelectionPanel.Visible = false;
            // 
            // orderSelectionPanel
            // 
            this.orderSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderSelectionPanel.Location = new System.Drawing.Point(108, 4);
            this.orderSelectionPanel.Name = "orderSelectionPanel";
            this.orderSelectionPanel.Size = new System.Drawing.Size(312, 252);
            this.orderSelectionPanel.TabIndex = 7;
            this.orderSelectionPanel.Visible = false;
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.orderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderPanel.Controls.Add(this.orderLbl);
            this.orderPanel.Controls.Add(this.orderDropPbx);
            this.orderPanel.Controls.Add(this.label5);
            this.orderPanel.Location = new System.Drawing.Point(351, 64);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(90, 34);
            this.orderPanel.TabIndex = 9;
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.Location = new System.Drawing.Point(3, 4);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(42, 21);
            this.orderLbl.TabIndex = 2;
            this.orderLbl.Text = "Order";
            // 
            // orderDropPbx
            // 
            this.orderDropPbx.Image = System.Drawing.Image.FromFile(Images.ChevronDown);
            this.orderDropPbx.Location = new System.Drawing.Point(59, 1);
            this.orderDropPbx.Name = "orderDropPbx";
            this.orderDropPbx.Size = new System.Drawing.Size(24, 24);
            this.orderDropPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderDropPbx.TabIndex = 1;
            this.orderDropPbx.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 0;
            // 
            // FilmLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.ratingSelectionPanel);
            this.Controls.Add(this.statusSelectionPanel);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.panelSelectionPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.genrePanel);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navbarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "FilmLibraryForm";
            this.Text = "MyWatchList";
            this.Load += new System.EventHandler(this.FilmLibraryForm_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.genrePanel.ResumeLayout(false);
            this.genrePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDropPbx)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDropPbx)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDropPbx)).EndInit();
            this.ratingSelectionPanel.ResumeLayout(false);
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDropPbx)).EndInit();
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
        private System.Windows.Forms.PictureBox ratingDropPbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox statusDropPbx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label ratingLbl;
        private System.Windows.Forms.Panel panelSelectionPanel;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Panel statusSelectionPanel;
        private System.Windows.Forms.Panel ratingSelectionPanel;
        private System.Windows.Forms.Panel orderSelectionPanel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.PictureBox orderDropPbx;
        private System.Windows.Forms.Label label5;
    }
}
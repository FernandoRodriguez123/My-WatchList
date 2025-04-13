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
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
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
            this.pictureBox1.Location = new System.Drawing.Point(13, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(12, 212);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(91, 16);
            this.itemLbl.TabIndex = 2;
            this.itemLbl.Text = "Death Parade";
            // 
            // FilmLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
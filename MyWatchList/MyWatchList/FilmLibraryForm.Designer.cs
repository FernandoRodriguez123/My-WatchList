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
            navbarPanel = new Panel();
            searchTxb = new TextBox();
            searchPbx = new PictureBox();
            searchPanel = new Panel();
            addLbl = new Label();
            brandPbx = new PictureBox();
            libraryLbl = new Label();
            genrePanel = new Panel();
            genreDropPbx = new PictureBox();
            genreLbl = new Label();
            statusPanel = new Panel();
            statusDropPbx = new PictureBox();
            statusLbl = new Label();
            filterBtn = new Button();
            orderPanel = new Panel();
            orderLbl = new Label();
            orderDropPbx = new PictureBox();
            label5 = new Label();
            genresFlowPanel = new FlowLayoutPanel();
            statusFlowPanel = new FlowLayoutPanel();
            orderFlowPanel = new FlowLayoutPanel();
            libraryFlowPanel = new FlowLayoutPanel();
            navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) searchPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize) brandPbx).BeginInit();
            genrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) genreDropPbx).BeginInit();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) statusDropPbx).BeginInit();
            orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) orderDropPbx).BeginInit();
            SuspendLayout();
            // 
            // navbarPanel
            // 
            navbarPanel.BackColor = Color.FromArgb(  64,   64,   64);
            navbarPanel.Controls.Add(searchTxb);
            navbarPanel.Controls.Add(searchPbx);
            navbarPanel.Controls.Add(searchPanel);
            navbarPanel.Controls.Add(addLbl);
            navbarPanel.Controls.Add(brandPbx);
            navbarPanel.Controls.Add(libraryLbl);
            navbarPanel.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            navbarPanel.ForeColor = Color.White;
            navbarPanel.Location = new Point(-1, -2);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(795, 56);
            navbarPanel.TabIndex = 0;
            // 
            // searchTxb
            // 
            searchTxb.BackColor = Color.FromArgb(  64,   64,   64);
            searchTxb.BorderStyle = BorderStyle.None;
            searchTxb.ForeColor = Color.White;
            searchTxb.Location = new Point(656, 16);
            searchTxb.Name = "searchTxb";
            searchTxb.Size = new Size(88, 17);
            searchTxb.TabIndex = 5;
            // 
            // searchPbx
            // 
            searchPbx.Location = new Point(749, 14);
            searchPbx.Name = "searchPbx";
            searchPbx.Size = new Size(21, 22);
            searchPbx.SizeMode = PictureBoxSizeMode.Zoom;
            searchPbx.TabIndex = 4;
            searchPbx.TabStop = false;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.BorderStyle = BorderStyle.Fixed3D;
            searchPanel.Location = new Point(656, 38);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(114, 2);
            searchPanel.TabIndex = 3;
            // 
            // addLbl
            // 
            addLbl.AutoSize = true;
            addLbl.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            addLbl.Location = new Point(271, 9);
            addLbl.Name = "addLbl";
            addLbl.Size = new Size(55, 23);
            addLbl.TabIndex = 2;
            addLbl.Text = "AÑADIR";
            // 
            // brandPbx
            // 
            brandPbx.Location = new Point(38, 4);
            brandPbx.Name = "brandPbx";
            brandPbx.Size = new Size(88, 46);
            brandPbx.SizeMode = PictureBoxSizeMode.Zoom;
            brandPbx.TabIndex = 1;
            brandPbx.TabStop = false;
            // 
            // libraryLbl
            // 
            libraryLbl.AutoSize = true;
            libraryLbl.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            libraryLbl.Location = new Point(131, 10);
            libraryLbl.Name = "libraryLbl";
            libraryLbl.Size = new Size(131, 23);
            libraryLbl.TabIndex = 0;
            libraryLbl.Text = "DIRECTORIO SERIES";
            // 
            // genrePanel
            // 
            genrePanel.BackColor = Color.Gainsboro;
            genrePanel.BorderStyle = BorderStyle.FixedSingle;
            genrePanel.Controls.Add(genreDropPbx);
            genrePanel.Controls.Add(genreLbl);
            genrePanel.Location = new Point(12, 60);
            genrePanel.Name = "genrePanel";
            genrePanel.Size = new Size(79, 32);
            genrePanel.TabIndex = 3;
            genrePanel.Click += genrePanel_Click;
            // 
            // genreDropPbx
            // 
            genreDropPbx.Location = new Point(52, 1);
            genreDropPbx.Name = "genreDropPbx";
            genreDropPbx.Size = new Size(21, 22);
            genreDropPbx.SizeMode = PictureBoxSizeMode.Zoom;
            genreDropPbx.TabIndex = 1;
            genreDropPbx.TabStop = false;
            // 
            // genreLbl
            // 
            genreLbl.AutoSize = true;
            genreLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            genreLbl.Location = new Point(3, 3);
            genreLbl.Name = "genreLbl";
            genreLbl.Size = new Size(39, 17);
            genreLbl.TabIndex = 0;
            genreLbl.Text = "Género";
            // 
            // statusPanel
            // 
            statusPanel.BackColor = Color.Gainsboro;
            statusPanel.BorderStyle = BorderStyle.FixedSingle;
            statusPanel.Controls.Add(statusDropPbx);
            statusPanel.Controls.Add(statusLbl);
            statusPanel.Location = new Point(97, 60);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(79, 32);
            statusPanel.TabIndex = 4;
            statusPanel.Click += statusPanel_Click;
            // 
            // statusDropPbx
            // 
            statusDropPbx.Location = new Point(52, 1);
            statusDropPbx.Name = "statusDropPbx";
            statusDropPbx.Size = new Size(21, 22);
            statusDropPbx.SizeMode = PictureBoxSizeMode.Zoom;
            statusDropPbx.TabIndex = 1;
            statusDropPbx.TabStop = false;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            statusLbl.Location = new Point(3, 3);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(39, 17);
            statusLbl.TabIndex = 0;
            statusLbl.Text = "Estado";
            // 
            // filterBtn
            // 
            filterBtn.BackColor = Color.Gainsboro;
            filterBtn.FlatStyle = FlatStyle.Popup;
            filterBtn.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            filterBtn.ForeColor = Color.Black;
            filterBtn.Location = new Point(267, 60);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(74, 32);
            filterBtn.TabIndex = 6;
            filterBtn.Text = "FILTRAR";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // orderPanel
            // 
            orderPanel.BackColor = Color.Gainsboro;
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Controls.Add(orderLbl);
            orderPanel.Controls.Add(orderDropPbx);
            orderPanel.Controls.Add(label5);
            orderPanel.Location = new Point(182, 59);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(79, 32);
            orderPanel.TabIndex = 9;
            orderPanel.Click += orderPanel_Click;
            // 
            // orderLbl
            // 
            orderLbl.AutoSize = true;
            orderLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            orderLbl.Location = new Point(3, 4);
            orderLbl.Name = "orderLbl";
            orderLbl.Size = new Size(33, 17);
            orderLbl.TabIndex = 2;
            orderLbl.Text = "Order";
            // 
            // orderDropPbx
            // 
            orderDropPbx.Location = new Point(52, 1);
            orderDropPbx.Name = "orderDropPbx";
            orderDropPbx.Size = new Size(21, 22);
            orderDropPbx.SizeMode = PictureBoxSizeMode.Zoom;
            orderDropPbx.TabIndex = 1;
            orderDropPbx.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 0;
            // 
            // genresFlowPanel
            // 
            genresFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            genresFlowPanel.Location = new Point(65, 98);
            genresFlowPanel.Name = "genresFlowPanel";
            genresFlowPanel.Size = new Size(260, 244);
            genresFlowPanel.TabIndex = 10;
            genresFlowPanel.Visible = false;
            // 
            // statusFlowPanel
            // 
            statusFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            statusFlowPanel.Location = new Point(150, 97);
            statusFlowPanel.Name = "statusFlowPanel";
            statusFlowPanel.Size = new Size(260, 244);
            statusFlowPanel.TabIndex = 11;
            statusFlowPanel.Visible = false;
            // 
            // orderFlowPanel
            // 
            orderFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            orderFlowPanel.Location = new Point(235, 97);
            orderFlowPanel.Name = "orderFlowPanel";
            orderFlowPanel.Size = new Size(260, 244);
            orderFlowPanel.TabIndex = 11;
            orderFlowPanel.Visible = false;
            // 
            // libraryFlowPanel
            // 
            libraryFlowPanel.AutoScroll = true;
            libraryFlowPanel.Location = new Point(12, 99);
            libraryFlowPanel.Name = "libraryFlowPanel";
            libraryFlowPanel.Size = new Size(782, 602);
            libraryFlowPanel.TabIndex = 12;
            // 
            // FilmLibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(794, 722);
            Controls.Add(libraryFlowPanel);
            Controls.Add(orderFlowPanel);
            Controls.Add(statusFlowPanel);
            Controls.Add(genresFlowPanel);
            Controls.Add(orderPanel);
            Controls.Add(filterBtn);
            Controls.Add(statusPanel);
            Controls.Add(genrePanel);
            Controls.Add(navbarPanel);
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "FilmLibraryForm";
            Text = "MyWatchList";
            navbarPanel.ResumeLayout(false);
            navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) searchPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize) brandPbx).EndInit();
            genrePanel.ResumeLayout(false);
            genrePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) genreDropPbx).EndInit();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) statusDropPbx).EndInit();
            orderPanel.ResumeLayout(false);
            orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) orderDropPbx).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Label libraryLbl;
        private System.Windows.Forms.PictureBox brandPbx;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchPbx;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.Panel genrePanel;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.PictureBox genreDropPbx;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox statusDropPbx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.PictureBox orderDropPbx;
        private System.Windows.Forms.Label label5;
        private FlowLayoutPanel genresFlowPanel;
        private FlowLayoutPanel statusFlowPanel;
        private FlowLayoutPanel orderFlowPanel;
        private FlowLayoutPanel libraryFlowPanel;
    }
}
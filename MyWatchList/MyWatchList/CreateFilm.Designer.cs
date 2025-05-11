namespace MyWatchList
{
    partial class CreateFilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilmForm));
            navbarPanel = new Panel();
            searchTxb = new TextBox();
            searchPbx = new PictureBox();
            searchPanel = new Panel();
            addLbl = new Label();
            brandPbx = new PictureBox();
            libraryLbl = new Label();
            titlePanel = new Panel();
            titleTxb = new TextBox();
            titleLbl = new Label();
            chaptersPanel = new Panel();
            chaptersTxb = new TextBox();
            chaptersLbl = new Label();
            sinopsisLbl = new Label();
            textBox1 = new TextBox();
            imageBtn = new Button();
            createBtn = new Button();
            genresPanel = new Panel();
            navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) searchPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize) brandPbx).BeginInit();
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
            navbarPanel.Location = new Point(1, 4);
            navbarPanel.Margin = new Padding(3, 4, 3, 4);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(909, 75);
            navbarPanel.TabIndex = 2;
            // 
            // searchTxb
            // 
            searchTxb.BackColor = Color.FromArgb(  59,   66,   72);
            searchTxb.BorderStyle = BorderStyle.None;
            searchTxb.ForeColor = Color.White;
            searchTxb.Location = new Point(750, 21);
            searchTxb.Margin = new Padding(3, 4, 3, 4);
            searchTxb.Name = "searchTxb";
            searchTxb.Size = new Size(100, 21);
            searchTxb.TabIndex = 5;
            searchTxb.Text = "Buscar...";
            // 
            // searchPbx
            // 
            searchPbx.Location = new Point(856, 18);
            searchPbx.Margin = new Padding(3, 4, 3, 4);
            searchPbx.Name = "searchPbx";
            searchPbx.Size = new Size(24, 30);
            searchPbx.SizeMode = PictureBoxSizeMode.Zoom;
            searchPbx.TabIndex = 4;
            searchPbx.TabStop = false;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.BorderStyle = BorderStyle.Fixed3D;
            searchPanel.Location = new Point(750, 50);
            searchPanel.Margin = new Padding(3, 4, 3, 4);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(130, 2);
            searchPanel.TabIndex = 3;
            // 
            // addLbl
            // 
            addLbl.AutoSize = true;
            addLbl.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            addLbl.Location = new Point(310, 12);
            addLbl.Name = "addLbl";
            addLbl.Size = new Size(66, 28);
            addLbl.TabIndex = 2;
            addLbl.Text = "AÑADIR";
            // 
            // brandPbx
            // 
            brandPbx.Location = new Point(44, 5);
            brandPbx.Margin = new Padding(3, 4, 3, 4);
            brandPbx.Name = "brandPbx";
            brandPbx.Size = new Size(100, 62);
            brandPbx.SizeMode = PictureBoxSizeMode.Zoom;
            brandPbx.TabIndex = 1;
            brandPbx.TabStop = false;
            // 
            // libraryLbl
            // 
            libraryLbl.AutoSize = true;
            libraryLbl.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            libraryLbl.Location = new Point(150, 14);
            libraryLbl.Name = "libraryLbl";
            libraryLbl.Size = new Size(154, 28);
            libraryLbl.TabIndex = 0;
            libraryLbl.Text = "DIRECTORIO SERIES";
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.Black;
            titlePanel.Location = new Point(12, 154);
            titlePanel.Margin = new Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(250, 2);
            titlePanel.TabIndex = 10;
            // 
            // titleTxb
            // 
            titleTxb.BackColor = Color.WhiteSmoke;
            titleTxb.BorderStyle = BorderStyle.None;
            titleTxb.Location = new Point(11, 128);
            titleTxb.Margin = new Padding(3, 4, 3, 4);
            titleTxb.Name = "titleTxb";
            titleTxb.Size = new Size(251, 20);
            titleTxb.TabIndex = 9;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            titleLbl.Location = new Point(8, 91);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(40, 21);
            titleLbl.TabIndex = 8;
            titleLbl.Text = "Título";
            // 
            // chaptersPanel
            // 
            chaptersPanel.BackColor = Color.Black;
            chaptersPanel.Location = new Point(12, 252);
            chaptersPanel.Margin = new Padding(3, 4, 3, 4);
            chaptersPanel.Name = "chaptersPanel";
            chaptersPanel.Size = new Size(250, 2);
            chaptersPanel.TabIndex = 16;
            // 
            // chaptersTxb
            // 
            chaptersTxb.BackColor = Color.WhiteSmoke;
            chaptersTxb.BorderStyle = BorderStyle.None;
            chaptersTxb.Location = new Point(11, 226);
            chaptersTxb.Margin = new Padding(3, 4, 3, 4);
            chaptersTxb.Name = "chaptersTxb";
            chaptersTxb.Size = new Size(251, 20);
            chaptersTxb.TabIndex = 15;
            // 
            // chaptersLbl
            // 
            chaptersLbl.AutoSize = true;
            chaptersLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            chaptersLbl.Location = new Point(8, 190);
            chaptersLbl.Name = "chaptersLbl";
            chaptersLbl.Size = new Size(61, 21);
            chaptersLbl.TabIndex = 14;
            chaptersLbl.Text = "Capítulos";
            // 
            // sinopsisLbl
            // 
            sinopsisLbl.AutoSize = true;
            sinopsisLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            sinopsisLbl.Location = new Point(13, 279);
            sinopsisLbl.Name = "sinopsisLbl";
            sinopsisLbl.Size = new Size(55, 21);
            sinopsisLbl.TabIndex = 17;
            sinopsisLbl.Text = "Sinopsis";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 309);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 344);
            textBox1.TabIndex = 17;
            // 
            // imageBtn
            // 
            imageBtn.BackColor = Color.FromArgb(  64,   64,   64);
            imageBtn.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            imageBtn.ForeColor = Color.White;
            imageBtn.Location = new Point(11, 661);
            imageBtn.Margin = new Padding(3, 4, 3, 4);
            imageBtn.Name = "imageBtn";
            imageBtn.Size = new Size(261, 52);
            imageBtn.TabIndex = 18;
            imageBtn.Text = "Seleccionar imagen";
            imageBtn.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.LightSeaGreen;
            createBtn.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(11, 721);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(261, 52);
            createBtn.TabIndex = 19;
            createBtn.Text = "Añadir serie";
            createBtn.UseVisualStyleBackColor = false;
            // 
            // genresPanel
            // 
            genresPanel.Location = new Point(401, 184);
            genresPanel.Margin = new Padding(3, 4, 3, 4);
            genresPanel.Name = "genresPanel";
            genresPanel.Size = new Size(480, 594);
            genresPanel.TabIndex = 20;
            // 
            // CreateFilmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1422, 954);
            Controls.Add(genresPanel);
            Controls.Add(createBtn);
            Controls.Add(imageBtn);
            Controls.Add(textBox1);
            Controls.Add(sinopsisLbl);
            Controls.Add(chaptersPanel);
            Controls.Add(chaptersTxb);
            Controls.Add(chaptersLbl);
            Controls.Add(titlePanel);
            Controls.Add(titleTxb);
            Controls.Add(titleLbl);
            Controls.Add(navbarPanel);
            Icon = (Icon) resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateFilmForm";
            Text = "CreateFilm";
            navbarPanel.ResumeLayout(false);
            navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) searchPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize) brandPbx).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.PictureBox searchPbx;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.PictureBox brandPbx;
        private System.Windows.Forms.Label libraryLbl;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TextBox titleTxb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel chaptersPanel;
        private System.Windows.Forms.TextBox chaptersTxb;
        private System.Windows.Forms.Label chaptersLbl;
        private System.Windows.Forms.Label sinopsisLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Panel genresPanel;
    }
}
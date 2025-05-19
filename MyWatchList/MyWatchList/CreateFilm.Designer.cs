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
            flowLayoutPanel1 = new FlowLayoutPanel();
            navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) brandPbx).BeginInit();
            SuspendLayout();
            // 
            // navbarPanel
            // 
            navbarPanel.BackColor = Color.FromArgb(  64,   64,   64);
            navbarPanel.Controls.Add(addLbl);
            navbarPanel.Controls.Add(brandPbx);
            navbarPanel.Controls.Add(libraryLbl);
            navbarPanel.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            navbarPanel.ForeColor = Color.White;
            navbarPanel.Location = new Point(1, 3);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(795, 56);
            navbarPanel.TabIndex = 2;
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
            // titlePanel
            // 
            titlePanel.BackColor = Color.Black;
            titlePanel.Location = new Point(10, 116);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(219, 2);
            titlePanel.TabIndex = 10;
            // 
            // titleTxb
            // 
            titleTxb.BackColor = Color.WhiteSmoke;
            titleTxb.BorderStyle = BorderStyle.None;
            titleTxb.Location = new Point(10, 96);
            titleTxb.Name = "titleTxb";
            titleTxb.Size = new Size(220, 16);
            titleTxb.TabIndex = 9;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            titleLbl.Location = new Point(7, 68);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(34, 17);
            titleLbl.TabIndex = 8;
            titleLbl.Text = "Título";
            // 
            // chaptersPanel
            // 
            chaptersPanel.BackColor = Color.Black;
            chaptersPanel.Location = new Point(10, 189);
            chaptersPanel.Name = "chaptersPanel";
            chaptersPanel.Size = new Size(219, 2);
            chaptersPanel.TabIndex = 16;
            // 
            // chaptersTxb
            // 
            chaptersTxb.BackColor = Color.WhiteSmoke;
            chaptersTxb.BorderStyle = BorderStyle.None;
            chaptersTxb.Location = new Point(10, 170);
            chaptersTxb.Name = "chaptersTxb";
            chaptersTxb.Size = new Size(220, 16);
            chaptersTxb.TabIndex = 15;
            // 
            // chaptersLbl
            // 
            chaptersLbl.AutoSize = true;
            chaptersLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            chaptersLbl.Location = new Point(7, 142);
            chaptersLbl.Name = "chaptersLbl";
            chaptersLbl.Size = new Size(52, 17);
            chaptersLbl.TabIndex = 14;
            chaptersLbl.Text = "Capítulos";
            // 
            // sinopsisLbl
            // 
            sinopsisLbl.AutoSize = true;
            sinopsisLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            sinopsisLbl.Location = new Point(11, 209);
            sinopsisLbl.Name = "sinopsisLbl";
            sinopsisLbl.Size = new Size(47, 17);
            sinopsisLbl.TabIndex = 17;
            sinopsisLbl.Text = "Sinopsis";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(10, 232);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 258);
            textBox1.TabIndex = 17;
            // 
            // imageBtn
            // 
            imageBtn.BackColor = Color.FromArgb(  64,   64,   64);
            imageBtn.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            imageBtn.ForeColor = Color.White;
            imageBtn.Location = new Point(10, 496);
            imageBtn.Name = "imageBtn";
            imageBtn.Size = new Size(228, 39);
            imageBtn.TabIndex = 18;
            imageBtn.Text = "Seleccionar imagen";
            imageBtn.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.LightSeaGreen;
            createBtn.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(10, 541);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(228, 39);
            createBtn.TabIndex = 19;
            createBtn.Text = "Añadir serie";
            createBtn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(330, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(415, 424);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // CreateFilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(796, 716);
            Controls.Add(flowLayoutPanel1);
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
            Name = "CreateFilmForm";
            Text = "CreateFilm";
            navbarPanel.ResumeLayout(false);
            navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) brandPbx).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
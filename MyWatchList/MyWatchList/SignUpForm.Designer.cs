namespace MyWatchList
{
    partial class SignInForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            titleLbl = new Label();
            userNameLbl = new Label();
            userNameTxb = new TextBox();
            changeSigningLbl = new Label();
            userNamePanel = new Panel();
            passwordPanel = new Panel();
            passwordTxb = new TextBox();
            passwordLbl = new Label();
            submitBtn = new Button();
            userNameErrorLbl = new Label();
            passwordErrorLbl = new Label();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point,  0);
            titleLbl.Location = new Point(95, 40);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(108, 27);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Iniciar Sesión";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            userNameLbl.Location = new Point(52, 95);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(43, 17);
            userNameLbl.TabIndex = 1;
            userNameLbl.Text = "Nombre";
            // 
            // userNameTxb
            // 
            userNameTxb.BorderStyle = BorderStyle.None;
            userNameTxb.Location = new Point(54, 122);
            userNameTxb.Name = "userNameTxb";
            userNameTxb.Size = new Size(220, 16);
            userNameTxb.TabIndex = 2;
            // 
            // changeSigningLbl
            // 
            changeSigningLbl.AutoSize = true;
            changeSigningLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Underline, GraphicsUnit.Point,  0);
            changeSigningLbl.ForeColor = SystemColors.Highlight;
            changeSigningLbl.Location = new Point(52, 282);
            changeSigningLbl.Name = "changeSigningLbl";
            changeSigningLbl.Size = new Size(133, 17);
            changeSigningLbl.TabIndex = 8;
            changeSigningLbl.Text = "¿Todavía no tienes cuenta?";
            changeSigningLbl.Click += ChangeSigningLbl_Click;
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = Color.Black;
            userNamePanel.Location = new Point(55, 142);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(219, 2);
            userNamePanel.TabIndex = 3;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Black;
            passwordPanel.Location = new Point(54, 218);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(219, 2);
            passwordPanel.TabIndex = 6;
            // 
            // passwordTxb
            // 
            passwordTxb.BorderStyle = BorderStyle.None;
            passwordTxb.Location = new Point(53, 198);
            passwordTxb.Name = "passwordTxb";
            passwordTxb.Size = new Size(220, 16);
            passwordTxb.TabIndex = 5;
            passwordTxb.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            passwordLbl.Location = new Point(51, 171);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(61, 17);
            passwordLbl.TabIndex = 4;
            passwordLbl.Text = "Contraseña";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(  25,   32,   201);
            submitBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point,  0);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(55, 242);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(218, 38);
            submitBtn.TabIndex = 7;
            submitBtn.Text = "Entrar";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += SubmitBtn_Click;
            // 
            // userNameErrorLbl
            // 
            userNameErrorLbl.AutoSize = true;
            userNameErrorLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            userNameErrorLbl.ForeColor = Color.Red;
            userNameErrorLbl.Location = new Point(55, 147);
            userNameErrorLbl.Name = "userNameErrorLbl";
            userNameErrorLbl.Size = new Size(43, 17);
            userNameErrorLbl.TabIndex = 9;
            userNameErrorLbl.Text = "Nombre";
            userNameErrorLbl.Visible = false;
            // 
            // passwordErrorLbl
            // 
            passwordErrorLbl.AutoSize = true;
            passwordErrorLbl.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
            passwordErrorLbl.ForeColor = Color.Red;
            passwordErrorLbl.Location = new Point(54, 222);
            passwordErrorLbl.Name = "passwordErrorLbl";
            passwordErrorLbl.Size = new Size(43, 17);
            passwordErrorLbl.TabIndex = 10;
            passwordErrorLbl.Text = "Nombre";
            passwordErrorLbl.Visible = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 331);
            Controls.Add(passwordErrorLbl);
            Controls.Add(userNameErrorLbl);
            Controls.Add(submitBtn);
            Controls.Add(passwordPanel);
            Controls.Add(passwordTxb);
            Controls.Add(userNamePanel);
            Controls.Add(passwordLbl);
            Controls.Add(changeSigningLbl);
            Controls.Add(userNameTxb);
            Controls.Add(userNameLbl);
            Controls.Add(titleLbl);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon) resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyWatchList";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userNameTxb;
        private System.Windows.Forms.Label changeSigningLbl;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button submitBtn;
        private Label userNameErrorLbl;
        private Label passwordErrorLbl;
    }
}


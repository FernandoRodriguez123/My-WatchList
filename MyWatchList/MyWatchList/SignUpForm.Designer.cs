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
            this.titleLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userNameTxb = new System.Windows.Forms.TextBox();
            this.changeSigningLbl = new System.Windows.Forms.Label();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(109, 43);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(143, 34);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Iniciar Sesión";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(59, 101);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(54, 21);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Nombre";
            // 
            // userNameTxb
            // 
            this.userNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxb.Location = new System.Drawing.Point(62, 130);
            this.userNameTxb.Name = "userNameTxb";
            this.userNameTxb.Size = new System.Drawing.Size(251, 15);
            this.userNameTxb.TabIndex = 2;
            // 
            // changeSigningLbl
            // 
            this.changeSigningLbl.AutoSize = true;
            this.changeSigningLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSigningLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.changeSigningLbl.Location = new System.Drawing.Point(59, 301);
            this.changeSigningLbl.Name = "changeSigningLbl";
            this.changeSigningLbl.Size = new System.Drawing.Size(158, 21);
            this.changeSigningLbl.TabIndex = 8;
            this.changeSigningLbl.Text = "¿Todavía no tienes cuenta?";
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.Black;
            this.userNamePanel.Location = new System.Drawing.Point(63, 151);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(250, 2);
            this.userNamePanel.TabIndex = 3;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.Black;
            this.passwordPanel.Location = new System.Drawing.Point(62, 232);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(250, 2);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordtxb
            // 
            this.passwordtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxb.Location = new System.Drawing.Point(61, 211);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(251, 15);
            this.passwordtxb.TabIndex = 5;
            this.passwordtxb.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(58, 182);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(73, 21);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Contraseña";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(201)))));
            this.submitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(63, 258);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(249, 40);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Entrar";
            this.submitBtn.UseVisualStyleBackColor = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.userNamePanel);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.changeSigningLbl);
            this.Controls.Add(this.userNameTxb);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.titleLbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWatchList";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userNameTxb;
        private System.Windows.Forms.Label changeSigningLbl;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button submitBtn;
    }
}


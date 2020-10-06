namespace GestionBiblio
{
    partial class formConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConnexion));
            this.headerConnexion = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInformation = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.txtLogin = new ns1.BunifuCustomLabel();
            this.Login = new ns1.BunifuMaterialTextbox();
            this.Password = new ns1.BunifuMaterialTextbox();
            this.Connexion = new ns1.BunifuThinButton2();
            this.Annuler = new ns1.BunifuThinButton2();
            this.Deplacement = new ns1.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.headerConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerConnexion
            // 
            this.headerConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            this.headerConnexion.Controls.Add(this.bunifuImageButton1);
            this.headerConnexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerConnexion.Location = new System.Drawing.Point(0, 0);
            this.headerConnexion.Name = "headerConnexion";
            this.headerConnexion.Size = new System.Drawing.Size(628, 196);
            this.headerConnexion.TabIndex = 0;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInformation.Location = new System.Drawing.Point(111, 72);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(401, 375);
            this.panelInformation.TabIndex = 1;
            this.panelInformation.TabStop = false;
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(278, 99);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(55, 52);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLogin.Location = new System.Drawing.Point(181, 163);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 18);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "CONNEXION ADMINISTRATEUR";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Login.ForeColor = System.Drawing.Color.DarkGray;
            this.Login.HintForeColor = System.Drawing.Color.Empty;
            this.Login.HintText = "";
            this.Login.isPassword = false;
            this.Login.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Login.LineIdleColor = System.Drawing.Color.Gray;
            this.Login.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Login.LineThickness = 3;
            this.Login.Location = new System.Drawing.Point(139, 221);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(348, 44);
            this.Login.TabIndex = 4;
            this.Login.Text = "Saisir le Login";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login.MouseEnter += new System.EventHandler(this.Login_MouseEnter);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(139, 290);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(348, 44);
            this.Password.TabIndex = 5;
            this.Password.Text = "Saisir le Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.MouseEnter += new System.EventHandler(this.Password_MouseEnter);
            // 
            // Connexion
            // 
            this.Connexion.ActiveBorderThickness = 1;
            this.Connexion.ActiveCornerRadius = 20;
            this.Connexion.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Connexion.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Connexion.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Connexion.BackColor = System.Drawing.Color.Gainsboro;
            this.Connexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Connexion.BackgroundImage")));
            this.Connexion.ButtonText = "Connexion";
            this.Connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Connexion.IdleBorderThickness = 1;
            this.Connexion.IdleCornerRadius = 20;
            this.Connexion.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.Connexion.IdleForecolor = System.Drawing.Color.White;
            this.Connexion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.Connexion.Location = new System.Drawing.Point(326, 369);
            this.Connexion.Margin = new System.Windows.Forms.Padding(5);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(117, 41);
            this.Connexion.TabIndex = 6;
            this.Connexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Annuler
            // 
            this.Annuler.ActiveBorderThickness = 1;
            this.Annuler.ActiveCornerRadius = 20;
            this.Annuler.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.BackColor = System.Drawing.Color.Gainsboro;
            this.Annuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Annuler.BackgroundImage")));
            this.Annuler.ButtonText = "Annuler";
            this.Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.IdleBorderThickness = 1;
            this.Annuler.IdleCornerRadius = 20;
            this.Annuler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(109)))), ((int)(((byte)(74)))));
            this.Annuler.IdleForecolor = System.Drawing.Color.White;
            this.Annuler.IdleLineColor = System.Drawing.Color.Tomato;
            this.Annuler.Location = new System.Drawing.Point(174, 369);
            this.Annuler.Margin = new System.Windows.Forms.Padding(5);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(117, 41);
            this.Annuler.TabIndex = 7;
            this.Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Deplacement
            // 
            this.Deplacement.Fixed = true;
            this.Deplacement.Horizontal = true;
            this.Deplacement.TargetControl = this.headerConnexion;
            this.Deplacement.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(285, 18);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(285, 18, 0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // formConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.headerConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.headerConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel headerConnexion;
        private System.Windows.Forms.PictureBox panelInformation;
        private System.Windows.Forms.PictureBox ImgLogo;
        private ns1.BunifuCustomLabel txtLogin;
        private ns1.BunifuMaterialTextbox Login;
        private ns1.BunifuMaterialTextbox Password;
        private ns1.BunifuThinButton2 Connexion;
        private ns1.BunifuThinButton2 Annuler;
        private ns1.BunifuDragControl Deplacement;
        private ns1.BunifuImageButton bunifuImageButton1;
    }
}


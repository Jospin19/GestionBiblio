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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConnexion));
            this.headerConnexion = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.panelInformation = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.txtLogin = new ns1.BunifuCustomLabel();
            this.Login = new ns1.BunifuMaterialTextbox();
            this.Password = new ns1.BunifuMaterialTextbox();
            this.Connexion = new ns1.BunifuThinButton2();
            this.Annuler = new ns1.BunifuThinButton2();
            this.Deplacement = new ns1.BunifuDragControl(this.components);
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Erreur = new System.Windows.Forms.Panel();
            this.txt = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transitionErreur = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.headerConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.Erreur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerConnexion
            // 
            this.headerConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            this.headerConnexion.Controls.Add(this.bunifuImageButton1);
            this.transitionErreur.SetDecoration(this.headerConnexion, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.headerConnexion, BunifuAnimatorNS.DecorationType.None);
            this.headerConnexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerConnexion.Location = new System.Drawing.Point(0, 0);
            this.headerConnexion.Name = "headerConnexion";
            this.headerConnexion.Size = new System.Drawing.Size(628, 196);
            this.headerConnexion.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            this.transitionErreur.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
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
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Transition.SetDecoration(this.panelInformation, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.panelInformation, BunifuAnimatorNS.DecorationType.None);
            this.panelInformation.Location = new System.Drawing.Point(111, 72);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(401, 375);
            this.panelInformation.TabIndex = 1;
            this.panelInformation.TabStop = false;
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Transition.SetDecoration(this.ImgLogo, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.ImgLogo, BunifuAnimatorNS.DecorationType.None);
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
            this.Transition.SetDecoration(this.txtLogin, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.txtLogin, BunifuAnimatorNS.DecorationType.None);
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
            this.transitionErreur.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
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
            this.Login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionErreur.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
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
            this.Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_MouseClick);
            // 
            // Connexion
            // 
            this.Connexion.ActiveBorderThickness = 1;
            this.Connexion.ActiveCornerRadius = 20;
            this.Connexion.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Connexion.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Connexion.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Connexion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Connexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Connexion.BackgroundImage")));
            this.Connexion.ButtonText = "Connexion";
            this.Connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionErreur.SetDecoration(this.Connexion, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.Connexion, BunifuAnimatorNS.DecorationType.None);
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
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // Annuler
            // 
            this.Annuler.ActiveBorderThickness = 1;
            this.Annuler.ActiveCornerRadius = 20;
            this.Annuler.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Annuler.BackgroundImage")));
            this.Annuler.ButtonText = "Annuler";
            this.Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionErreur.SetDecoration(this.Annuler, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.Annuler, BunifuAnimatorNS.DecorationType.None);
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
            this.Deplacement.TargetControl = this;
            this.Deplacement.Vertical = true;
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.Transition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation2;
            this.Transition.TimeStep = 0.04F;
            // 
            // Erreur
            // 
            this.Erreur.BackColor = System.Drawing.Color.Gainsboro;
            this.Erreur.Controls.Add(this.txt);
            this.Erreur.Controls.Add(this.pictureBox1);
            this.transitionErreur.SetDecoration(this.Erreur, BunifuAnimatorNS.DecorationType.None);
            this.Transition.SetDecoration(this.Erreur, BunifuAnimatorNS.DecorationType.None);
            this.Erreur.Location = new System.Drawing.Point(111, 453);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(401, 48);
            this.Erreur.TabIndex = 8;
            this.Erreur.Visible = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Gainsboro;
            this.Transition.SetDecoration(this.txt, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.txt, BunifuAnimatorNS.DecorationType.None);
            this.txt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Tomato;
            this.txt.Location = new System.Drawing.Point(67, 16);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(304, 18);
            this.txt.TabIndex = 4;
            this.txt.Text = "Cet utiliateur n\'existe pas. Veuillez reessayer!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // transitionErreur
            // 
            this.transitionErreur.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transitionErreur.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transitionErreur.DefaultAnimation = animation1;
            // 
            // formConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.Erreur);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.headerConnexion);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.headerConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.Erreur.ResumeLayout(false);
            this.Erreur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private BunifuAnimatorNS.BunifuTransition Transition;
        private System.Windows.Forms.Panel Erreur;
        private ns1.BunifuCustomLabel txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition transitionErreur;
    }
}


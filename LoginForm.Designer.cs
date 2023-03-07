namespace PetShopOtomation
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ForgetPassLink = new System.Windows.Forms.LinkLabel();
            this.RememberCheck = new System.Windows.Forms.CheckBox();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegisterQuesLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.VisiblePic = new System.Windows.Forms.PictureBox();
            this.NonVisiblePic = new System.Windows.Forms.PictureBox();
            this.PasswordTextb = new System.Windows.Forms.TextBox();
            this.UserNameTextb = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonVisiblePic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.LogoBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(419, 101);
            this.TopPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveBorderThickness = 1;
            this.CloseButton.ActiveCornerRadius = 20;
            this.CloseButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CloseButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.ButtonText = "X";
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.IdleBorderThickness = 1;
            this.CloseButton.IdleCornerRadius = 20;
            this.CloseButton.IdleFillColor = System.Drawing.Color.White;
            this.CloseButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.Location = new System.Drawing.Point(381, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(32, 41);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImage = global::PetShopOtomation.Properties.Resources.Logo_Circula;
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoBox.Location = new System.Drawing.Point(162, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(97, 94);
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ForgetPassLink
            // 
            this.ForgetPassLink.ActiveLinkColor = System.Drawing.Color.NavajoWhite;
            this.ForgetPassLink.AutoSize = true;
            this.ForgetPassLink.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPassLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPassLink.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForgetPassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ForgetPassLink.Location = new System.Drawing.Point(132, 390);
            this.ForgetPassLink.Name = "ForgetPassLink";
            this.ForgetPassLink.Size = new System.Drawing.Size(200, 25);
            this.ForgetPassLink.TabIndex = 8;
            this.ForgetPassLink.TabStop = true;
            this.ForgetPassLink.Text = "forget your password?";
            this.ForgetPassLink.VisitedLinkColor = System.Drawing.Color.BlanchedAlmond;
            this.ForgetPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassLink_LinkClicked);
            // 
            // RememberCheck
            // 
            this.RememberCheck.AutoSize = true;
            this.RememberCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberCheck.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RememberCheck.Location = new System.Drawing.Point(100, 298);
            this.RememberCheck.Name = "RememberCheck";
            this.RememberCheck.Size = new System.Drawing.Size(132, 26);
            this.RememberCheck.TabIndex = 9;
            this.RememberCheck.Text = "Beni hatırla";
            this.RememberCheck.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LoginButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Giriş";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginButton.IdleForecolor = System.Drawing.Color.White;
            this.LoginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginButton.Location = new System.Drawing.Point(121, 332);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(177, 42);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UserNameLabel.Location = new System.Drawing.Point(91, 145);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(131, 23);
            this.UserNameLabel.TabIndex = 13;
            this.UserNameLabel.Text = "Kullanıcı Adı";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(91, 226);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(50, 23);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Şifre";
            // 
            // RegisterQuesLabel
            // 
            this.RegisterQuesLabel.AutoSize = true;
            this.RegisterQuesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterQuesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterQuesLabel.Location = new System.Drawing.Point(117, 451);
            this.RegisterQuesLabel.Name = "RegisterQuesLabel";
            this.RegisterQuesLabel.Size = new System.Drawing.Size(236, 23);
            this.RegisterQuesLabel.TabIndex = 15;
            this.RegisterQuesLabel.Text = "Hala kayıt olmadın mı?";
            // 
            // RegisterButton
            // 
            this.RegisterButton.ActiveBorderThickness = 1;
            this.RegisterButton.ActiveCornerRadius = 20;
            this.RegisterButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RegisterButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RegisterButton.BackColor = System.Drawing.Color.White;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.ButtonText = "Kayıt Ol";
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterButton.IdleBorderThickness = 1;
            this.RegisterButton.IdleCornerRadius = 20;
            this.RegisterButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterButton.IdleForecolor = System.Drawing.Color.White;
            this.RegisterButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterButton.Location = new System.Drawing.Point(121, 475);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(177, 42);
            this.RegisterButton.TabIndex = 16;
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // VisiblePic
            // 
            this.VisiblePic.BackgroundImage = global::PetShopOtomation.Properties.Resources.visibil;
            this.VisiblePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisiblePic.Location = new System.Drawing.Point(331, 256);
            this.VisiblePic.Name = "VisiblePic";
            this.VisiblePic.Size = new System.Drawing.Size(29, 25);
            this.VisiblePic.TabIndex = 17;
            this.VisiblePic.TabStop = false;
            this.VisiblePic.Click += new System.EventHandler(this.VisiblePic_Click);
            // 
            // NonVisiblePic
            // 
            this.NonVisiblePic.BackgroundImage = global::PetShopOtomation.Properties.Resources.nonVisibil;
            this.NonVisiblePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NonVisiblePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NonVisiblePic.Location = new System.Drawing.Point(331, 256);
            this.NonVisiblePic.Name = "NonVisiblePic";
            this.NonVisiblePic.Size = new System.Drawing.Size(29, 25);
            this.NonVisiblePic.TabIndex = 18;
            this.NonVisiblePic.TabStop = false;
            this.NonVisiblePic.Visible = false;
            this.NonVisiblePic.Click += new System.EventHandler(this.NonVisiblePic_Click);
            // 
            // PasswordTextb
            // 
            this.PasswordTextb.Location = new System.Drawing.Point(95, 254);
            this.PasswordTextb.Name = "PasswordTextb";
            this.PasswordTextb.Size = new System.Drawing.Size(230, 32);
            this.PasswordTextb.TabIndex = 3;
            this.PasswordTextb.UseSystemPasswordChar = true;
            // 
            // UserNameTextb
            // 
            this.UserNameTextb.Location = new System.Drawing.Point(95, 174);
            this.UserNameTextb.Name = "UserNameTextb";
            this.UserNameTextb.Size = new System.Drawing.Size(230, 32);
            this.UserNameTextb.TabIndex = 19;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 538);
            this.Controls.Add(this.UserNameTextb);
            this.Controls.Add(this.NonVisiblePic);
            this.Controls.Add(this.VisiblePic);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegisterQuesLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RememberCheck);
            this.Controls.Add(this.ForgetPassLink);
            this.Controls.Add(this.PasswordTextb);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonVisiblePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.LinkLabel ForgetPassLink;
        private System.Windows.Forms.CheckBox RememberCheck;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RegisterQuesLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 RegisterButton;
        private System.Windows.Forms.PictureBox VisiblePic;
        private System.Windows.Forms.PictureBox NonVisiblePic;
        private System.Windows.Forms.TextBox PasswordTextb;
        private System.Windows.Forms.TextBox UserNameTextb;
    }
}
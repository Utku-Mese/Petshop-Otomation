using System.Windows.Forms;

namespace PetShopOtomation
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchProButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchProTextb = new Bunifu.Framework.UI.BunifuTextbox();
            this.SearchProLabel = new System.Windows.Forms.Label();
            this.SellBackPan = new System.Windows.Forms.Panel();
            this.SellPic = new System.Windows.Forms.PictureBox();
            this.SellLabel = new System.Windows.Forms.Label();
            this.ProfitBackPan = new System.Windows.Forms.Panel();
            this.ProfitPic = new System.Windows.Forms.PictureBox();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PetsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SellingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeSButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PPhotoPic = new System.Windows.Forms.PictureBox();
            this.TotalSelling = new System.Windows.Forms.Label();
            this.TotalProfit = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SellBackPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellPic)).BeginInit();
            this.ProfitBackPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.MainPanel;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.SearchProButton);
            this.MainPanel.Controls.Add(this.SearchProTextb);
            this.MainPanel.Controls.Add(this.SearchProLabel);
            this.MainPanel.Controls.Add(this.SellBackPan);
            this.MainPanel.Controls.Add(this.ProfitBackPan);
            this.MainPanel.Controls.Add(this.LogoPic);
            this.MainPanel.Location = new System.Drawing.Point(155, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(736, 518);
            this.MainPanel.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveBorderThickness = 1;
            this.CloseButton.ActiveCornerRadius = 20;
            this.CloseButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CloseButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CloseButton.BackColor = System.Drawing.Color.White;
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
            this.CloseButton.Location = new System.Drawing.Point(698, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(32, 41);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchProButton
            // 
            this.SearchProButton.ActiveBorderThickness = 1;
            this.SearchProButton.ActiveCornerRadius = 20;
            this.SearchProButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SearchProButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchProButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SearchProButton.BackColor = System.Drawing.Color.White;
            this.SearchProButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchProButton.BackgroundImage")));
            this.SearchProButton.ButtonText = "Ara";
            this.SearchProButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchProButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchProButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchProButton.IdleBorderThickness = 1;
            this.SearchProButton.IdleCornerRadius = 20;
            this.SearchProButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchProButton.IdleForecolor = System.Drawing.Color.White;
            this.SearchProButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchProButton.Location = new System.Drawing.Point(302, 392);
            this.SearchProButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchProButton.Name = "SearchProButton";
            this.SearchProButton.Size = new System.Drawing.Size(139, 42);
            this.SearchProButton.TabIndex = 9;
            this.SearchProButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchProButton.Click += new System.EventHandler(this.SearchProButton_Click);
            // 
            // SearchProTextb
            // 
            this.SearchProTextb.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.SearchProTextb.BackColor = System.Drawing.Color.White;
            this.SearchProTextb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchProTextb.BackgroundImage")));
            this.SearchProTextb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchProTextb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchProTextb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchProTextb.Icon = ((System.Drawing.Image)(resources.GetObject("SearchProTextb.Icon")));
            this.SearchProTextb.Location = new System.Drawing.Point(236, 337);
            this.SearchProTextb.Margin = new System.Windows.Forms.Padding(5);
            this.SearchProTextb.Name = "SearchProTextb";
            this.SearchProTextb.Size = new System.Drawing.Size(277, 45);
            this.SearchProTextb.TabIndex = 8;
            this.SearchProTextb.TabStop = false;
            this.SearchProTextb.text = "Ürün kodu";
            // 
            // SearchProLabel
            // 
            this.SearchProLabel.AutoSize = true;
            this.SearchProLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchProLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchProLabel.Location = new System.Drawing.Point(317, 281);
            this.SearchProLabel.Name = "SearchProLabel";
            this.SearchProLabel.Size = new System.Drawing.Size(140, 37);
            this.SearchProLabel.TabIndex = 6;
            this.SearchProLabel.Text = "Ürün ara";
            // 
            // SellBackPan
            // 
            this.SellBackPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellBackPan.Controls.Add(this.TotalSelling);
            this.SellBackPan.Controls.Add(this.SellPic);
            this.SellBackPan.Controls.Add(this.SellLabel);
            this.SellBackPan.Location = new System.Drawing.Point(42, 125);
            this.SellBackPan.Name = "SellBackPan";
            this.SellBackPan.Size = new System.Drawing.Size(300, 86);
            this.SellBackPan.TabIndex = 5;
            // 
            // SellPic
            // 
            this.SellPic.BackgroundImage = global::PetShopOtomation.Properties.Resources.tl;
            this.SellPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SellPic.Location = new System.Drawing.Point(13, 19);
            this.SellPic.Name = "SellPic";
            this.SellPic.Size = new System.Drawing.Size(41, 44);
            this.SellPic.TabIndex = 1;
            this.SellPic.TabStop = false;
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellLabel.ForeColor = System.Drawing.Color.White;
            this.SellLabel.Location = new System.Drawing.Point(113, 9);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(107, 23);
            this.SellLabel.TabIndex = 0;
            this.SellLabel.Text = "Aylık satış";
            // 
            // ProfitBackPan
            // 
            this.ProfitBackPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProfitBackPan.Controls.Add(this.TotalProfit);
            this.ProfitBackPan.Controls.Add(this.ProfitPic);
            this.ProfitBackPan.Controls.Add(this.ProfitLabel);
            this.ProfitBackPan.Location = new System.Drawing.Point(398, 125);
            this.ProfitBackPan.Name = "ProfitBackPan";
            this.ProfitBackPan.Size = new System.Drawing.Size(300, 86);
            this.ProfitBackPan.TabIndex = 3;
            // 
            // ProfitPic
            // 
            this.ProfitPic.BackgroundImage = global::PetShopOtomation.Properties.Resources.tlPlus;
            this.ProfitPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfitPic.Location = new System.Drawing.Point(13, 19);
            this.ProfitPic.Name = "ProfitPic";
            this.ProfitPic.Size = new System.Drawing.Size(41, 44);
            this.ProfitPic.TabIndex = 1;
            this.ProfitPic.TabStop = false;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProfitLabel.ForeColor = System.Drawing.Color.White;
            this.ProfitLabel.Location = new System.Drawing.Point(99, 9);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(137, 23);
            this.ProfitLabel.TabIndex = 0;
            this.ProfitLabel.Text = "Aylık kazanç";
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::PetShopOtomation.Properties.Resources.Logo_Circula;
            this.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPic.Location = new System.Drawing.Point(324, 0);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(94, 94);
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(55, 20);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(74, 23);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Admin";
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 5;
            this.bunifuElipse7.TargetControl = this;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 5;
            this.bunifuElipse8.TargetControl = this;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 5;
            this.bunifuElipse9.TargetControl = this.SellBackPan;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 5;
            this.bunifuElipse10.TargetControl = this.ProfitBackPan;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 5;
            // 
            // PetsButton
            // 
            this.PetsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PetsButton.BackColor = System.Drawing.Color.White;
            this.PetsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PetsButton.BorderRadius = 5;
            this.PetsButton.ButtonText = "      Hayvanlar";
            this.PetsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PetsButton.DisabledColor = System.Drawing.Color.Gray;
            this.PetsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PetsButton.Iconimage = global::PetShopOtomation.Properties.Resources.Pets;
            this.PetsButton.Iconimage_right = null;
            this.PetsButton.Iconimage_right_Selected = null;
            this.PetsButton.Iconimage_Selected = null;
            this.PetsButton.IconMarginLeft = 5;
            this.PetsButton.IconMarginRight = 0;
            this.PetsButton.IconRightVisible = true;
            this.PetsButton.IconRightZoom = 0D;
            this.PetsButton.IconVisible = true;
            this.PetsButton.IconZoom = 42D;
            this.PetsButton.IsTab = false;
            this.PetsButton.Location = new System.Drawing.Point(13, 307);
            this.PetsButton.Margin = new System.Windows.Forms.Padding(0);
            this.PetsButton.Name = "PetsButton";
            this.PetsButton.Normalcolor = System.Drawing.Color.White;
            this.PetsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsButton.selected = false;
            this.PetsButton.Size = new System.Drawing.Size(136, 35);
            this.PetsButton.TabIndex = 20;
            this.PetsButton.Text = "      Hayvanlar";
            this.PetsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PetsButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PetsButton.Click += new System.EventHandler(this.PetsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.BackColor = System.Drawing.Color.White;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.BorderRadius = 5;
            this.LogOutButton.ButtonText = "   Çıkış";
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogOutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogOutButton.Iconimage = global::PetShopOtomation.Properties.Resources.logOut;
            this.LogOutButton.Iconimage_right = null;
            this.LogOutButton.Iconimage_right_Selected = null;
            this.LogOutButton.Iconimage_Selected = null;
            this.LogOutButton.IconMarginLeft = 5;
            this.LogOutButton.IconMarginRight = 0;
            this.LogOutButton.IconRightVisible = true;
            this.LogOutButton.IconRightZoom = 0D;
            this.LogOutButton.IconVisible = true;
            this.LogOutButton.IconZoom = 42D;
            this.LogOutButton.IsTab = false;
            this.LogOutButton.Location = new System.Drawing.Point(13, 480);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Normalcolor = System.Drawing.Color.White;
            this.LogOutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogOutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogOutButton.selected = false;
            this.LogOutButton.Size = new System.Drawing.Size(137, 36);
            this.LogOutButton.TabIndex = 18;
            this.LogOutButton.Text = "   Çıkış";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogOutButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SellingButton
            // 
            this.SellingButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SellingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SellingButton.BackColor = System.Drawing.Color.White;
            this.SellingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SellingButton.BorderRadius = 5;
            this.SellingButton.ButtonText = "      Satış Yap";
            this.SellingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellingButton.DisabledColor = System.Drawing.Color.Gray;
            this.SellingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SellingButton.Iconimage = global::PetShopOtomation.Properties.Resources.receipt1;
            this.SellingButton.Iconimage_right = null;
            this.SellingButton.Iconimage_right_Selected = null;
            this.SellingButton.Iconimage_Selected = null;
            this.SellingButton.IconMarginLeft = 5;
            this.SellingButton.IconMarginRight = 0;
            this.SellingButton.IconRightVisible = true;
            this.SellingButton.IconRightZoom = 0D;
            this.SellingButton.IconVisible = true;
            this.SellingButton.IconZoom = 42D;
            this.SellingButton.IsTab = false;
            this.SellingButton.Location = new System.Drawing.Point(13, 367);
            this.SellingButton.Margin = new System.Windows.Forms.Padding(0);
            this.SellingButton.Name = "SellingButton";
            this.SellingButton.Normalcolor = System.Drawing.Color.White;
            this.SellingButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SellingButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.selected = false;
            this.SellingButton.Size = new System.Drawing.Size(137, 36);
            this.SellingButton.TabIndex = 17;
            this.SellingButton.Text = "      Satış Yap";
            this.SellingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SellingButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellingButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButton.BackColor = System.Drawing.Color.White;
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomersButton.BorderRadius = 5;
            this.CustomersButton.ButtonText = "       Müşteriler";
            this.CustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersButton.DisabledColor = System.Drawing.Color.Gray;
            this.CustomersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CustomersButton.Iconimage = global::PetShopOtomation.Properties.Resources.customers1;
            this.CustomersButton.Iconimage_right = null;
            this.CustomersButton.Iconimage_right_Selected = null;
            this.CustomersButton.Iconimage_Selected = null;
            this.CustomersButton.IconMarginLeft = 5;
            this.CustomersButton.IconMarginRight = 0;
            this.CustomersButton.IconRightVisible = true;
            this.CustomersButton.IconRightZoom = 0D;
            this.CustomersButton.IconVisible = true;
            this.CustomersButton.IconZoom = 42D;
            this.CustomersButton.IsTab = false;
            this.CustomersButton.Location = new System.Drawing.Point(13, 247);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Normalcolor = System.Drawing.Color.White;
            this.CustomersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.selected = false;
            this.CustomersButton.Size = new System.Drawing.Size(137, 36);
            this.CustomersButton.TabIndex = 15;
            this.CustomersButton.Text = "       Müşteriler";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomersButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductButton.BackColor = System.Drawing.Color.White;
            this.ProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductButton.BorderRadius = 5;
            this.ProductButton.ButtonText = "      Ürünler";
            this.ProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductButton.DisabledColor = System.Drawing.Color.Gray;
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ProductButton.Iconimage = global::PetShopOtomation.Properties.Resources.inventory1;
            this.ProductButton.Iconimage_right = null;
            this.ProductButton.Iconimage_right_Selected = null;
            this.ProductButton.Iconimage_Selected = null;
            this.ProductButton.IconMarginLeft = 5;
            this.ProductButton.IconMarginRight = 0;
            this.ProductButton.IconRightVisible = true;
            this.ProductButton.IconRightZoom = 0D;
            this.ProductButton.IconVisible = true;
            this.ProductButton.IconZoom = 42D;
            this.ProductButton.IsTab = false;
            this.ProductButton.Location = new System.Drawing.Point(13, 187);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Normalcolor = System.Drawing.Color.White;
            this.ProductButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProductButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductButton.selected = false;
            this.ProductButton.Size = new System.Drawing.Size(137, 36);
            this.ProductButton.TabIndex = 14;
            this.ProductButton.Text = "      Ürünler";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // HomeSButton
            // 
            this.HomeSButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomeSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomeSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeSButton.BorderRadius = 5;
            this.HomeSButton.ButtonText = "Ana Sayfa ";
            this.HomeSButton.Cursor = System.Windows.Forms.Cursors.No;
            this.HomeSButton.DisabledColor = System.Drawing.Color.Gray;
            this.HomeSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeSButton.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeSButton.Iconimage = global::PetShopOtomation.Properties.Resources.homeEnd1;
            this.HomeSButton.Iconimage_right = null;
            this.HomeSButton.Iconimage_right_Selected = null;
            this.HomeSButton.Iconimage_Selected = null;
            this.HomeSButton.IconMarginLeft = 3;
            this.HomeSButton.IconMarginRight = 0;
            this.HomeSButton.IconRightVisible = true;
            this.HomeSButton.IconRightZoom = 0D;
            this.HomeSButton.IconVisible = true;
            this.HomeSButton.IconZoom = 47D;
            this.HomeSButton.IsTab = false;
            this.HomeSButton.Location = new System.Drawing.Point(13, 127);
            this.HomeSButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeSButton.Name = "HomeSButton";
            this.HomeSButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomeSButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomeSButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeSButton.selected = false;
            this.HomeSButton.Size = new System.Drawing.Size(137, 36);
            this.HomeSButton.TabIndex = 13;
            this.HomeSButton.Text = "Ana Sayfa ";
            this.HomeSButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeSButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeSButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // PPhotoPic
            // 
            this.PPhotoPic.BackgroundImage = global::PetShopOtomation.Properties.Resources.profilePhotos;
            this.PPhotoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PPhotoPic.Location = new System.Drawing.Point(12, 12);
            this.PPhotoPic.Name = "PPhotoPic";
            this.PPhotoPic.Size = new System.Drawing.Size(34, 33);
            this.PPhotoPic.TabIndex = 6;
            this.PPhotoPic.TabStop = false;
            // 
            // TotalSelling
            // 
            this.TotalSelling.AutoSize = true;
            this.TotalSelling.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalSelling.ForeColor = System.Drawing.Color.White;
            this.TotalSelling.Location = new System.Drawing.Point(57, 40);
            this.TotalSelling.MinimumSize = new System.Drawing.Size(200, 0);
            this.TotalSelling.Name = "TotalSelling";
            this.TotalSelling.Size = new System.Drawing.Size(200, 34);
            this.TotalSelling.TabIndex = 2;
            this.TotalSelling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalProfit
            // 
            this.TotalProfit.AutoSize = true;
            this.TotalProfit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalProfit.ForeColor = System.Drawing.Color.White;
            this.TotalProfit.Location = new System.Drawing.Point(57, 40);
            this.TotalProfit.MinimumSize = new System.Drawing.Size(200, 0);
            this.TotalProfit.Name = "TotalProfit";
            this.TotalProfit.Size = new System.Drawing.Size(200, 34);
            this.TotalProfit.TabIndex = 3;
            this.TotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.PetsButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SellingButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.HomeSButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PPhotoPic);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SellBackPan.ResumeLayout(false);
            this.SellBackPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellPic)).EndInit();
            this.ProfitBackPan.ResumeLayout(false);
            this.ProfitBackPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private PictureBox PPhotoPic;
        private Label UserNameLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Panel MainPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchProButton;
        private Label SearchProLabel;
        private Panel SellBackPan;
        private PictureBox SellPic;
        private Label SellLabel;
        private Panel ProfitBackPan;
        private PictureBox ProfitPic;
        private Label ProfitLabel;
        private PictureBox LogoPic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuFlatButton HomeSButton;
        private Bunifu.Framework.UI.BunifuFlatButton ProductButton;
        private Bunifu.Framework.UI.BunifuFlatButton CustomersButton;
        private Bunifu.Framework.UI.BunifuFlatButton SellingButton;
        private Bunifu.Framework.UI.BunifuFlatButton LogOutButton;
        private Bunifu.Framework.UI.BunifuFlatButton PetsButton;
        private Bunifu.Framework.UI.BunifuTextbox SearchProTextb;
        private Label TotalSelling;
        private Label TotalProfit;
    }
}
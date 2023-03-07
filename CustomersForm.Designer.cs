namespace PetShopOtomation
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CustomerDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.PetsNameLabel = new System.Windows.Forms.Label();
            this.NumberTextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PetsNameTextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.EditButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddressTextb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PetsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PPhotoPic = new System.Windows.Forms.PictureBox();
            this.CustomersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeSButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SellingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.petShopDbDataSet = new PetShopOtomation.PetShopDbDataSet();
            this.petShopDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petShopDbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSetBindingSource1)).BeginInit();
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
            this.MainPanel.Controls.Add(this.CustomerDataGrid);
            this.MainPanel.Controls.Add(this.bunifuSeparator1);
            this.MainPanel.Controls.Add(this.bunifuGradientPanel2);
            this.MainPanel.Controls.Add(this.bunifuGradientPanel1);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Location = new System.Drawing.Point(207, 15);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(981, 638);
            this.MainPanel.TabIndex = 30;
            // 
            // CustomerDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDataGrid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomerDataGrid.Location = new System.Drawing.Point(11, 297);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.RowHeadersVisible = false;
            this.CustomerDataGrid.RowHeadersWidth = 51;
            this.CustomerDataGrid.RowTemplate.Height = 24;
            this.CustomerDataGrid.Size = new System.Drawing.Size(957, 328);
            this.CustomerDataGrid.TabIndex = 16;
            this.CustomerDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomerDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.CustomerDataGrid.ThemeStyle.ReadOnly = false;
            this.CustomerDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.CustomerDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomerDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGrid_CellContentClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(74, 282);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(834, 10);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.AddressLabel);
            this.bunifuGradientPanel2.Controls.Add(this.NumberLabel);
            this.bunifuGradientPanel2.Controls.Add(this.PetsNameLabel);
            this.bunifuGradientPanel2.Controls.Add(this.NumberTextb);
            this.bunifuGradientPanel2.Controls.Add(this.PetsNameTextb);
            this.bunifuGradientPanel2.Controls.Add(this.NameLabel);
            this.bunifuGradientPanel2.Controls.Add(this.NameTextb);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 45);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(981, 117);
            this.bunifuGradientPanel2.TabIndex = 14;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddressLabel.Location = new System.Drawing.Point(55, 91);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 23);
            this.AddressLabel.TabIndex = 20;
            this.AddressLabel.Text = "Adres";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumberLabel.Location = new System.Drawing.Point(667, 4);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(178, 23);
            this.NumberLabel.TabIndex = 19;
            this.NumberLabel.Text = "Telefon Numarası";
            // 
            // PetsNameLabel
            // 
            this.PetsNameLabel.AutoSize = true;
            this.PetsNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PetsNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PetsNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsNameLabel.Location = new System.Drawing.Point(362, 5);
            this.PetsNameLabel.Name = "PetsNameLabel";
            this.PetsNameLabel.Size = new System.Drawing.Size(135, 23);
            this.PetsNameLabel.TabIndex = 19;
            this.PetsNameLabel.Text = "Evcil Hayvan";
            // 
            // NumberTextb
            // 
            this.NumberTextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberTextb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberTextb.HintForeColor = System.Drawing.Color.Empty;
            this.NumberTextb.HintText = "";
            this.NumberTextb.isPassword = false;
            this.NumberTextb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NumberTextb.LineIdleColor = System.Drawing.Color.Gray;
            this.NumberTextb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NumberTextb.LineThickness = 3;
            this.NumberTextb.Location = new System.Drawing.Point(671, 31);
            this.NumberTextb.Margin = new System.Windows.Forms.Padding(4);
            this.NumberTextb.Name = "NumberTextb";
            this.NumberTextb.Size = new System.Drawing.Size(278, 43);
            this.NumberTextb.TabIndex = 20;
            this.NumberTextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PetsNameTextb
            // 
            this.PetsNameTextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetsNameTextb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PetsNameTextb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PetsNameTextb.HintForeColor = System.Drawing.Color.Empty;
            this.PetsNameTextb.HintText = "";
            this.PetsNameTextb.isPassword = false;
            this.PetsNameTextb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PetsNameTextb.LineIdleColor = System.Drawing.Color.Gray;
            this.PetsNameTextb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PetsNameTextb.LineThickness = 3;
            this.PetsNameTextb.Location = new System.Drawing.Point(366, 31);
            this.PetsNameTextb.Margin = new System.Windows.Forms.Padding(4);
            this.PetsNameTextb.Name = "PetsNameTextb";
            this.PetsNameTextb.Size = new System.Drawing.Size(253, 43);
            this.PetsNameTextb.TabIndex = 20;
            this.PetsNameTextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NameLabel.Location = new System.Drawing.Point(55, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(119, 23);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Ad - Soyad";
            // 
            // NameTextb
            // 
            this.NameTextb.BackColor = System.Drawing.Color.White;
            this.NameTextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameTextb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTextb.HintForeColor = System.Drawing.Color.Empty;
            this.NameTextb.HintText = "";
            this.NameTextb.isPassword = false;
            this.NameTextb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NameTextb.LineIdleColor = System.Drawing.Color.Gray;
            this.NameTextb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NameTextb.LineThickness = 3;
            this.NameTextb.Location = new System.Drawing.Point(59, 31);
            this.NameTextb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextb.Name = "NameTextb";
            this.NameTextb.Size = new System.Drawing.Size(253, 43);
            this.NameTextb.TabIndex = 18;
            this.NameTextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.EditButton);
            this.bunifuGradientPanel1.Controls.Add(this.SearchButton);
            this.bunifuGradientPanel1.Controls.Add(this.DeleteButton);
            this.bunifuGradientPanel1.Controls.Add(this.AddButton);
            this.bunifuGradientPanel1.Controls.Add(this.AddressTextb);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 163);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(981, 117);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // EditButton
            // 
            this.EditButton.ActiveBorderThickness = 1;
            this.EditButton.ActiveCornerRadius = 20;
            this.EditButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EditButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.ButtonText = "Düzenle";
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditButton.IdleBorderThickness = 1;
            this.EditButton.IdleCornerRadius = 20;
            this.EditButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditButton.IdleForecolor = System.Drawing.Color.White;
            this.EditButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditButton.Location = new System.Drawing.Point(523, 36);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(125, 55);
            this.EditButton.TabIndex = 19;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.ActiveBorderThickness = 1;
            this.SearchButton.ActiveCornerRadius = 20;
            this.SearchButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SearchButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.ButtonText = "Ara";
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchButton.IdleBorderThickness = 1;
            this.SearchButton.IdleCornerRadius = 20;
            this.SearchButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchButton.IdleForecolor = System.Drawing.Color.White;
            this.SearchButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchButton.Location = new System.Drawing.Point(823, 36);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 55);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ActiveBorderThickness = 1;
            this.DeleteButton.ActiveCornerRadius = 20;
            this.DeleteButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.ButtonText = "Sil";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteButton.IdleBorderThickness = 1;
            this.DeleteButton.IdleCornerRadius = 20;
            this.DeleteButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteButton.IdleForecolor = System.Drawing.Color.White;
            this.DeleteButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteButton.Location = new System.Drawing.Point(678, 36);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 55);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.ActiveBorderThickness = 1;
            this.AddButton.ActiveCornerRadius = 20;
            this.AddButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.ButtonText = "Ekle";
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleCornerRadius = 20;
            this.AddButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton.IdleForecolor = System.Drawing.Color.White;
            this.AddButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton.Location = new System.Drawing.Point(369, 36);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 55);
            this.AddButton.TabIndex = 16;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressTextb
            // 
            this.AddressTextb.BorderColor = System.Drawing.Color.SeaGreen;
            this.AddressTextb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressTextb.Location = new System.Drawing.Point(59, 3);
            this.AddressTextb.Multiline = true;
            this.AddressTextb.Name = "AddressTextb";
            this.AddressTextb.Size = new System.Drawing.Size(253, 107);
            this.AddressTextb.TabIndex = 15;
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
            this.CloseButton.Location = new System.Drawing.Point(931, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(43, 50);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 5;
            this.bunifuElipse7.TargetControl = this;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 5;
            this.bunifuElipse11.TargetControl = this;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 5;
            this.bunifuElipse10.TargetControl = this;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 5;
            this.bunifuElipse9.TargetControl = this;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(73, 25);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(74, 23);
            this.UserNameLabel.TabIndex = 28;
            this.UserNameLabel.Text = "Admin";
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 5;
            this.bunifuElipse8.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 15;
            this.bunifuElipse6.TargetControl = this;
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
            this.PetsButton.IconZoom = 70D;
            this.PetsButton.IsTab = false;
            this.PetsButton.Location = new System.Drawing.Point(17, 378);
            this.PetsButton.Margin = new System.Windows.Forms.Padding(0);
            this.PetsButton.Name = "PetsButton";
            this.PetsButton.Normalcolor = System.Drawing.Color.White;
            this.PetsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsButton.selected = false;
            this.PetsButton.Size = new System.Drawing.Size(183, 44);
            this.PetsButton.TabIndex = 37;
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
            this.LogOutButton.IconZoom = 67D;
            this.LogOutButton.IsTab = false;
            this.LogOutButton.Location = new System.Drawing.Point(17, 591);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Normalcolor = System.Drawing.Color.White;
            this.LogOutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogOutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogOutButton.selected = false;
            this.LogOutButton.Size = new System.Drawing.Size(183, 44);
            this.LogOutButton.TabIndex = 36;
            this.LogOutButton.Text = "   Çıkış";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogOutButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // PPhotoPic
            // 
            this.PPhotoPic.BackgroundImage = global::PetShopOtomation.Properties.Resources.profilePhotos;
            this.PPhotoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PPhotoPic.Location = new System.Drawing.Point(16, 15);
            this.PPhotoPic.Margin = new System.Windows.Forms.Padding(4);
            this.PPhotoPic.Name = "PPhotoPic";
            this.PPhotoPic.Size = new System.Drawing.Size(45, 41);
            this.PPhotoPic.TabIndex = 29;
            this.PPhotoPic.TabStop = false;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomersButton.BorderRadius = 5;
            this.CustomersButton.ButtonText = "       Müşteriler";
            this.CustomersButton.Cursor = System.Windows.Forms.Cursors.No;
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
            this.CustomersButton.IconZoom = 70D;
            this.CustomersButton.IsTab = false;
            this.CustomersButton.Location = new System.Drawing.Point(17, 304);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.selected = false;
            this.CustomersButton.Size = new System.Drawing.Size(183, 44);
            this.CustomersButton.TabIndex = 33;
            this.CustomersButton.Text = "       Müşteriler";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomersButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.ProductButton.IconZoom = 70D;
            this.ProductButton.IsTab = false;
            this.ProductButton.Location = new System.Drawing.Point(17, 230);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Normalcolor = System.Drawing.Color.White;
            this.ProductButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProductButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductButton.selected = false;
            this.ProductButton.Size = new System.Drawing.Size(183, 44);
            this.ProductButton.TabIndex = 32;
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
            this.HomeSButton.BackColor = System.Drawing.Color.White;
            this.HomeSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeSButton.BorderRadius = 5;
            this.HomeSButton.ButtonText = "Ana Sayfa ";
            this.HomeSButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.HomeSButton.IconZoom = 75D;
            this.HomeSButton.IsTab = false;
            this.HomeSButton.Location = new System.Drawing.Point(17, 156);
            this.HomeSButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeSButton.Name = "HomeSButton";
            this.HomeSButton.Normalcolor = System.Drawing.Color.White;
            this.HomeSButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomeSButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeSButton.selected = false;
            this.HomeSButton.Size = new System.Drawing.Size(183, 44);
            this.HomeSButton.TabIndex = 31;
            this.HomeSButton.Text = "Ana Sayfa ";
            this.HomeSButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeSButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeSButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeSButton.Click += new System.EventHandler(this.HomeSButton_Click);
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
            this.SellingButton.IconZoom = 67D;
            this.SellingButton.IsTab = false;
            this.SellingButton.Location = new System.Drawing.Point(17, 452);
            this.SellingButton.Margin = new System.Windows.Forms.Padding(0);
            this.SellingButton.Name = "SellingButton";
            this.SellingButton.Normalcolor = System.Drawing.Color.White;
            this.SellingButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SellingButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.selected = false;
            this.SellingButton.Size = new System.Drawing.Size(183, 44);
            this.SellingButton.TabIndex = 35;
            this.SellingButton.Text = "      Satış Yap";
            this.SellingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SellingButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellingButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // petShopDbDataSet
            // 
            this.petShopDbDataSet.DataSetName = "PetShopDbDataSet";
            this.petShopDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petShopDbDataSetBindingSource
            // 
            this.petShopDbDataSetBindingSource.DataSource = this.petShopDbDataSet;
            this.petShopDbDataSetBindingSource.Position = 0;
            // 
            // petShopDbDataSetBindingSource1
            // 
            this.petShopDbDataSetBindingSource1.DataSource = this.petShopDbDataSet;
            this.petShopDbDataSetBindingSource1.Position = 0;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.PetsButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.PPhotoPic);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.HomeSButton);
            this.Controls.Add(this.SellingButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton LogOutButton;
        private System.Windows.Forms.PictureBox PPhotoPic;
        private Bunifu.Framework.UI.BunifuFlatButton CustomersButton;
        private Bunifu.Framework.UI.BunifuFlatButton ProductButton;
        private Bunifu.Framework.UI.BunifuFlatButton HomeSButton;
        private Bunifu.Framework.UI.BunifuFlatButton SellingButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuFlatButton PetsButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label NameLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTextb;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label PetsNameLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NumberTextb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PetsNameTextb;
        private System.Windows.Forms.Label AddressLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AddressTextb;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.BindingSource petShopDbDataSetBindingSource;
        private PetShopDbDataSet petShopDbDataSet;
        private System.Windows.Forms.BindingSource petShopDbDataSetBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 EditButton;
    }
}
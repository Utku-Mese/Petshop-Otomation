namespace PetShopOtomation
{
    partial class PetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetsForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PetsDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BirtDayLabel = new System.Windows.Forms.Label();
            this.BirtdayPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.TypeDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.OtherLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.OwnerTextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.EditButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OtherTextb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PPhotoPic = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeSButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SellingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetsDataGrid)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.PetsDataGrid);
            this.MainPanel.Controls.Add(this.bunifuSeparator1);
            this.MainPanel.Controls.Add(this.bunifuGradientPanel2);
            this.MainPanel.Controls.Add(this.bunifuGradientPanel1);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Location = new System.Drawing.Point(207, 15);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(981, 638);
            this.MainPanel.TabIndex = 39;
            // 
            // PetsDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PetsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PetsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PetsDataGrid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PetsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PetsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PetsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsDataGrid.Location = new System.Drawing.Point(11, 297);
            this.PetsDataGrid.Name = "PetsDataGrid";
            this.PetsDataGrid.RowHeadersVisible = false;
            this.PetsDataGrid.RowHeadersWidth = 51;
            this.PetsDataGrid.RowTemplate.Height = 24;
            this.PetsDataGrid.Size = new System.Drawing.Size(957, 328);
            this.PetsDataGrid.TabIndex = 20;
            this.PetsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PetsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PetsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PetsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PetsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PetsDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PetsDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PetsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PetsDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PetsDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PetsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PetsDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.PetsDataGrid.ThemeStyle.ReadOnly = false;
            this.PetsDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PetsDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PetsDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PetsDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PetsDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.PetsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PetsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PetsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PetsDataGrid_CellContentClick);
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
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BirtDayLabel);
            this.bunifuGradientPanel2.Controls.Add(this.BirtdayPicker);
            this.bunifuGradientPanel2.Controls.Add(this.TypeDrop);
            this.bunifuGradientPanel2.Controls.Add(this.TypeLabel);
            this.bunifuGradientPanel2.Controls.Add(this.OtherLabel);
            this.bunifuGradientPanel2.Controls.Add(this.OwnerLabel);
            this.bunifuGradientPanel2.Controls.Add(this.OwnerTextb);
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
            this.bunifuGradientPanel2.TabIndex = 18;
            // 
            // BirtDayLabel
            // 
            this.BirtDayLabel.AutoSize = true;
            this.BirtDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.BirtDayLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirtDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BirtDayLabel.Location = new System.Drawing.Point(726, 5);
            this.BirtDayLabel.Name = "BirtDayLabel";
            this.BirtDayLabel.Size = new System.Drawing.Size(106, 18);
            this.BirtDayLabel.TabIndex = 25;
            this.BirtDayLabel.Text = "Doğum Günü";
            // 
            // BirtdayPicker
            // 
            this.BirtdayPicker.BackColor = System.Drawing.Color.White;
            this.BirtdayPicker.BorderRadius = 0;
            this.BirtdayPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BirtdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirtdayPicker.FormatCustom = null;
            this.BirtdayPicker.Location = new System.Drawing.Point(730, 31);
            this.BirtdayPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirtdayPicker.Name = "BirtdayPicker";
            this.BirtdayPicker.Size = new System.Drawing.Size(218, 44);
            this.BirtdayPicker.TabIndex = 24;
            this.BirtdayPicker.Value = new System.DateTime(2022, 12, 28, 15, 39, 32, 0);
            // 
            // TypeDrop
            // 
            this.TypeDrop.BackColor = System.Drawing.Color.Transparent;
            this.TypeDrop.BorderRadius = 0;
            this.TypeDrop.DisabledColor = System.Drawing.Color.Gray;
            this.TypeDrop.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TypeDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeDrop.Items = new string[] {
        "Köpek",
        "Kedi",
        "Kuş",
        "Balık",
        "Kemirgen",
        "Sürüngen"};
            this.TypeDrop.Location = new System.Drawing.Point(244, 31);
            this.TypeDrop.Margin = new System.Windows.Forms.Padding(4);
            this.TypeDrop.Name = "TypeDrop";
            this.TypeDrop.NomalColor = System.Drawing.SystemColors.Window;
            this.TypeDrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TypeDrop.selectedIndex = -1;
            this.TypeDrop.Size = new System.Drawing.Size(173, 43);
            this.TypeDrop.TabIndex = 23;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TypeLabel.Location = new System.Drawing.Point(240, 4);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 23);
            this.TypeLabel.TabIndex = 22;
            this.TypeLabel.Text = "Tür";
            // 
            // OtherLabel
            // 
            this.OtherLabel.AutoSize = true;
            this.OtherLabel.BackColor = System.Drawing.Color.Transparent;
            this.OtherLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OtherLabel.Location = new System.Drawing.Point(39, 92);
            this.OtherLabel.Name = "OtherLabel";
            this.OtherLabel.Size = new System.Drawing.Size(131, 23);
            this.OtherLabel.TabIndex = 20;
            this.OtherLabel.Text = "Diğer Bilgiler";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.OwnerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OwnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OwnerLabel.Location = new System.Drawing.Point(448, 4);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(102, 23);
            this.OwnerLabel.TabIndex = 19;
            this.OwnerLabel.Text = "Sahip Adı";
            // 
            // OwnerTextb
            // 
            this.OwnerTextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerTextb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OwnerTextb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OwnerTextb.HintForeColor = System.Drawing.Color.Empty;
            this.OwnerTextb.HintText = "";
            this.OwnerTextb.isPassword = false;
            this.OwnerTextb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.OwnerTextb.LineIdleColor = System.Drawing.Color.Gray;
            this.OwnerTextb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.OwnerTextb.LineThickness = 3;
            this.OwnerTextb.Location = new System.Drawing.Point(452, 31);
            this.OwnerTextb.Margin = new System.Windows.Forms.Padding(4);
            this.OwnerTextb.Name = "OwnerTextb";
            this.OwnerTextb.Size = new System.Drawing.Size(243, 43);
            this.OwnerTextb.TabIndex = 20;
            this.OwnerTextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NameLabel.Location = new System.Drawing.Point(39, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 23);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "İsim";
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
            this.NameTextb.Location = new System.Drawing.Point(43, 31);
            this.NameTextb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextb.Name = "NameTextb";
            this.NameTextb.Size = new System.Drawing.Size(170, 43);
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
            this.bunifuGradientPanel1.Controls.Add(this.OtherTextb);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 163);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(981, 117);
            this.bunifuGradientPanel1.TabIndex = 17;
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
            this.EditButton.Location = new System.Drawing.Point(512, 36);
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
            this.SearchButton.Location = new System.Drawing.Point(809, 36);
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
            this.DeleteButton.Location = new System.Drawing.Point(660, 36);
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
            // OtherTextb
            // 
            this.OtherTextb.BorderColor = System.Drawing.Color.SeaGreen;
            this.OtherTextb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtherTextb.Location = new System.Drawing.Point(43, 2);
            this.OtherTextb.Multiline = true;
            this.OtherTextb.Name = "OtherTextb";
            this.OtherTextb.Size = new System.Drawing.Size(253, 107);
            this.OtherTextb.TabIndex = 15;
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
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(73, 25);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(74, 23);
            this.UserNameLabel.TabIndex = 37;
            this.UserNameLabel.Text = "Admin";
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
            this.LogOutButton.TabIndex = 45;
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
            this.PPhotoPic.TabIndex = 38;
            this.PPhotoPic.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "      Hayvanlar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.No;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PetShopOtomation.Properties.Resources.Pets;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 5;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(17, 378);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(183, 44);
            this.bunifuFlatButton1.TabIndex = 43;
            this.bunifuFlatButton1.Text = "      Hayvanlar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.CustomersButton.IconZoom = 70D;
            this.CustomersButton.IsTab = false;
            this.CustomersButton.Location = new System.Drawing.Point(17, 304);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Normalcolor = System.Drawing.Color.White;
            this.CustomersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustomersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomersButton.selected = false;
            this.CustomersButton.Size = new System.Drawing.Size(183, 44);
            this.CustomersButton.TabIndex = 42;
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
            this.ProductButton.TabIndex = 41;
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
            this.HomeSButton.TabIndex = 40;
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
            this.SellingButton.TabIndex = 44;
            this.SellingButton.Text = "      Satış Yap";
            this.SellingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SellingButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellingButton.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellingButton.Click += new System.EventHandler(this.InvoiceButton_Click);
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
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.PPhotoPic);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.HomeSButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SellingButton);
            this.Controls.Add(this.UserNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetsForm";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PetsDataGrid)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPhotoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton LogOutButton;
        private System.Windows.Forms.PictureBox PPhotoPic;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton CustomersButton;
        private Bunifu.Framework.UI.BunifuFlatButton ProductButton;
        private Bunifu.Framework.UI.BunifuFlatButton HomeSButton;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuFlatButton SellingButton;
        private System.Windows.Forms.Label UserNameLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label OtherLabel;
        private System.Windows.Forms.Label NameLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTextb;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteButton;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox OtherTextb;
        private System.Windows.Forms.Label BirtDayLabel;
        private Bunifu.Framework.UI.BunifuDatepicker BirtdayPicker;
        private Bunifu.Framework.UI.BunifuDropdown TypeDrop;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OwnerTextb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2DataGridView PetsDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 EditButton;
    }
}
namespace WarehouseAndSales
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LogoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompanyName = new System.Windows.Forms.Label();
            this.SubName = new System.Windows.Forms.Label();
            this.BtnsPanel = new System.Windows.Forms.Panel();
            this.Backup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProviderReport = new System.Windows.Forms.Button();
            this.CustomerReport = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.PrinterNameSettingBtn = new System.Windows.Forms.Button();
            this.InvoicePrint = new System.Windows.Forms.Button();
            this.Warehouses = new System.Windows.Forms.Button();
            this.Mats = new System.Windows.Forms.Button();
            this.sellings = new System.Windows.Forms.Button();
            this.ProvidersAndBuyers = new System.Windows.Forms.Button();
            this.ProvidersAndBuyers2 = new System.Windows.Forms.Button();
            this.Buyings = new System.Windows.Forms.Button();
            this.CompanyInfo = new System.Windows.Forms.Button();
            this.UsersManagment = new System.Windows.Forms.Button();
            this.EmpManagment = new System.Windows.Forms.Button();
            this.SalaryManagment = new System.Windows.Forms.Button();
            this.Expense = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserFullNameLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.BtnsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Location = new System.Drawing.Point(9, 7);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(209, 64);
            this.LogoPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.SubName);
            this.panel1.Controls.Add(this.CompanyName);
            this.panel1.Controls.Add(this.LogoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 81);
            this.panel1.TabIndex = 5;
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.ForeColor = System.Drawing.Color.White;
            this.CompanyName.Location = new System.Drawing.Point(748, 7);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyName.Size = new System.Drawing.Size(159, 25);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "CompanyName";
            this.CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompanyName.Click += new System.EventHandler(this.CompanyName_Click);
            // 
            // SubName
            // 
            this.SubName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubName.AutoSize = true;
            this.SubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubName.Location = new System.Drawing.Point(748, 51);
            this.SubName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.SubName.Name = "SubName";
            this.SubName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubName.Size = new System.Drawing.Size(95, 24);
            this.SubName.TabIndex = 1;
            this.SubName.Text = "SubName";
            this.SubName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubName.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnsPanel
            // 
            this.BtnsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BtnsPanel.Controls.Add(this.Backup);
            this.BtnsPanel.Controls.Add(this.button1);
            this.BtnsPanel.Controls.Add(this.ProviderReport);
            this.BtnsPanel.Controls.Add(this.CustomerReport);
            this.BtnsPanel.Controls.Add(this.Reports);
            this.BtnsPanel.Controls.Add(this.PrinterNameSettingBtn);
            this.BtnsPanel.Controls.Add(this.InvoicePrint);
            this.BtnsPanel.Controls.Add(this.Warehouses);
            this.BtnsPanel.Controls.Add(this.Mats);
            this.BtnsPanel.Controls.Add(this.sellings);
            this.BtnsPanel.Controls.Add(this.ProvidersAndBuyers);
            this.BtnsPanel.Controls.Add(this.ProvidersAndBuyers2);
            this.BtnsPanel.Controls.Add(this.Buyings);
            this.BtnsPanel.Controls.Add(this.CompanyInfo);
            this.BtnsPanel.Controls.Add(this.UsersManagment);
            this.BtnsPanel.Controls.Add(this.EmpManagment);
            this.BtnsPanel.Controls.Add(this.SalaryManagment);
            this.BtnsPanel.Controls.Add(this.Expense);
            this.BtnsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnsPanel.Location = new System.Drawing.Point(0, 81);
            this.BtnsPanel.Name = "BtnsPanel";
            this.BtnsPanel.Size = new System.Drawing.Size(1119, 624);
            this.BtnsPanel.TabIndex = 6;
            // 
            // Backup
            // 
            this.Backup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Backup.FlatAppearance.BorderSize = 0;
            this.Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backup.ForeColor = System.Drawing.Color.Black;
            this.Backup.Location = new System.Drawing.Point(188, 543);
            this.Backup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(482, 50);
            this.Backup.TabIndex = 30;
            this.Backup.Text = "انشاء نسخة احتياطية";
            this.Backup.UseVisualStyleBackColor = false;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(695, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "تسجيل خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // ProviderReport
            // 
            this.ProviderReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProviderReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ProviderReport.FlatAppearance.BorderSize = 0;
            this.ProviderReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProviderReport.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProviderReport.ForeColor = System.Drawing.Color.White;
            this.ProviderReport.Location = new System.Drawing.Point(695, 461);
            this.ProviderReport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ProviderReport.Name = "ProviderReport";
            this.ProviderReport.Size = new System.Drawing.Size(212, 50);
            this.ProviderReport.TabIndex = 28;
            this.ProviderReport.Text = "سحب كشف مزود";
            this.ProviderReport.UseVisualStyleBackColor = false;
            this.ProviderReport.Click += new System.EventHandler(this.ProviderReport_Click);
            // 
            // CustomerReport
            // 
            this.CustomerReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.CustomerReport.FlatAppearance.BorderSize = 0;
            this.CustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerReport.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport.ForeColor = System.Drawing.Color.White;
            this.CustomerReport.Location = new System.Drawing.Point(695, 388);
            this.CustomerReport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CustomerReport.Name = "CustomerReport";
            this.CustomerReport.Size = new System.Drawing.Size(212, 50);
            this.CustomerReport.TabIndex = 27;
            this.CustomerReport.Text = "سحب كشف عميل";
            this.CustomerReport.UseVisualStyleBackColor = false;
            this.CustomerReport.Click += new System.EventHandler(this.CustomerReport_Click);
            // 
            // Reports
            // 
            this.Reports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Reports.FlatAppearance.BorderSize = 0;
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.ForeColor = System.Drawing.Color.White;
            this.Reports.Location = new System.Drawing.Point(458, 461);
            this.Reports.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(212, 50);
            this.Reports.TabIndex = 26;
            this.Reports.Text = "التقارير";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // PrinterNameSettingBtn
            // 
            this.PrinterNameSettingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrinterNameSettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.PrinterNameSettingBtn.FlatAppearance.BorderSize = 0;
            this.PrinterNameSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrinterNameSettingBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterNameSettingBtn.ForeColor = System.Drawing.Color.White;
            this.PrinterNameSettingBtn.Location = new System.Drawing.Point(695, 333);
            this.PrinterNameSettingBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PrinterNameSettingBtn.Name = "PrinterNameSettingBtn";
            this.PrinterNameSettingBtn.Size = new System.Drawing.Size(212, 50);
            this.PrinterNameSettingBtn.TabIndex = 25;
            this.PrinterNameSettingBtn.Text = "ضبط اسم الطابعة";
            this.PrinterNameSettingBtn.UseVisualStyleBackColor = false;
            this.PrinterNameSettingBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // InvoicePrint
            // 
            this.InvoicePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InvoicePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.InvoicePrint.FlatAppearance.BorderSize = 0;
            this.InvoicePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoicePrint.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicePrint.ForeColor = System.Drawing.Color.White;
            this.InvoicePrint.Location = new System.Drawing.Point(458, 388);
            this.InvoicePrint.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.InvoicePrint.Name = "InvoicePrint";
            this.InvoicePrint.Size = new System.Drawing.Size(212, 50);
            this.InvoicePrint.TabIndex = 24;
            this.InvoicePrint.Text = "طباعة الفواتير";
            this.InvoicePrint.UseVisualStyleBackColor = false;
            this.InvoicePrint.Click += new System.EventHandler(this.InvoicePrint_Click);
            // 
            // Warehouses
            // 
            this.Warehouses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Warehouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Warehouses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Warehouses.BackgroundImage")));
            this.Warehouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Warehouses.FlatAppearance.BorderSize = 0;
            this.Warehouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warehouses.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warehouses.ForeColor = System.Drawing.Color.White;
            this.Warehouses.Location = new System.Drawing.Point(40, 201);
            this.Warehouses.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Warehouses.Name = "Warehouses";
            this.Warehouses.Size = new System.Drawing.Size(150, 150);
            this.Warehouses.TabIndex = 13;
            this.Warehouses.UseVisualStyleBackColor = false;
            this.Warehouses.Click += new System.EventHandler(this.Warehouses_Click);
            // 
            // Mats
            // 
            this.Mats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Mats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Mats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mats.BackgroundImage")));
            this.Mats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mats.FlatAppearance.BorderSize = 0;
            this.Mats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mats.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mats.ForeColor = System.Drawing.Color.White;
            this.Mats.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mats.Location = new System.Drawing.Point(40, 35);
            this.Mats.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Mats.Name = "Mats";
            this.Mats.Size = new System.Drawing.Size(150, 150);
            this.Mats.TabIndex = 14;
            this.Mats.UseVisualStyleBackColor = false;
            this.Mats.Click += new System.EventHandler(this.Mats_Click);
            // 
            // sellings
            // 
            this.sellings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sellings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.sellings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sellings.BackgroundImage")));
            this.sellings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sellings.FlatAppearance.BorderSize = 0;
            this.sellings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellings.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellings.ForeColor = System.Drawing.Color.White;
            this.sellings.Location = new System.Drawing.Point(205, 201);
            this.sellings.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.sellings.Name = "sellings";
            this.sellings.Size = new System.Drawing.Size(150, 150);
            this.sellings.TabIndex = 15;
            this.sellings.UseVisualStyleBackColor = false;
            this.sellings.Click += new System.EventHandler(this.sellings_Click);
            // 
            // ProvidersAndBuyers
            // 
            this.ProvidersAndBuyers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProvidersAndBuyers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ProvidersAndBuyers.FlatAppearance.BorderSize = 0;
            this.ProvidersAndBuyers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProvidersAndBuyers.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvidersAndBuyers.ForeColor = System.Drawing.Color.White;
            this.ProvidersAndBuyers.Location = new System.Drawing.Point(458, 333);
            this.ProvidersAndBuyers.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ProvidersAndBuyers.Name = "ProvidersAndBuyers";
            this.ProvidersAndBuyers.Size = new System.Drawing.Size(212, 50);
            this.ProvidersAndBuyers.TabIndex = 16;
            this.ProvidersAndBuyers.Text = "ادارة الموردين";
            this.ProvidersAndBuyers.UseVisualStyleBackColor = false;
            this.ProvidersAndBuyers.Click += new System.EventHandler(this.ProvidersAndBuyers_Click);
            // 
            // ProvidersAndBuyers2
            // 
            this.ProvidersAndBuyers2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProvidersAndBuyers2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ProvidersAndBuyers2.FlatAppearance.BorderSize = 0;
            this.ProvidersAndBuyers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProvidersAndBuyers2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvidersAndBuyers2.ForeColor = System.Drawing.Color.White;
            this.ProvidersAndBuyers2.Location = new System.Drawing.Point(458, 278);
            this.ProvidersAndBuyers2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ProvidersAndBuyers2.Name = "ProvidersAndBuyers2";
            this.ProvidersAndBuyers2.Size = new System.Drawing.Size(212, 50);
            this.ProvidersAndBuyers2.TabIndex = 17;
            this.ProvidersAndBuyers2.Text = "ادارة العملاء";
            this.ProvidersAndBuyers2.UseVisualStyleBackColor = false;
            this.ProvidersAndBuyers2.Click += new System.EventHandler(this.ProvidersAndBuyers2_Click);
            // 
            // Buyings
            // 
            this.Buyings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Buyings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Buyings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buyings.BackgroundImage")));
            this.Buyings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Buyings.FlatAppearance.BorderSize = 0;
            this.Buyings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buyings.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buyings.ForeColor = System.Drawing.Color.White;
            this.Buyings.Location = new System.Drawing.Point(205, 35);
            this.Buyings.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Buyings.Name = "Buyings";
            this.Buyings.Size = new System.Drawing.Size(150, 150);
            this.Buyings.TabIndex = 18;
            this.Buyings.UseVisualStyleBackColor = false;
            this.Buyings.Click += new System.EventHandler(this.Buyings_Click);
            // 
            // CompanyInfo
            // 
            this.CompanyInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompanyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.CompanyInfo.FlatAppearance.BorderSize = 0;
            this.CompanyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyInfo.ForeColor = System.Drawing.Color.White;
            this.CompanyInfo.Location = new System.Drawing.Point(695, 50);
            this.CompanyInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CompanyInfo.Name = "CompanyInfo";
            this.CompanyInfo.Size = new System.Drawing.Size(212, 50);
            this.CompanyInfo.TabIndex = 19;
            this.CompanyInfo.Text = "تعديل معلومات الشركة";
            this.CompanyInfo.UseVisualStyleBackColor = false;
            this.CompanyInfo.Click += new System.EventHandler(this.CompanyInfo_Click);
            // 
            // UsersManagment
            // 
            this.UsersManagment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsersManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.UsersManagment.FlatAppearance.BorderSize = 0;
            this.UsersManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersManagment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersManagment.ForeColor = System.Drawing.Color.White;
            this.UsersManagment.Location = new System.Drawing.Point(695, 105);
            this.UsersManagment.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.UsersManagment.Name = "UsersManagment";
            this.UsersManagment.Size = new System.Drawing.Size(212, 50);
            this.UsersManagment.TabIndex = 20;
            this.UsersManagment.Text = "ادارة المستخدمين";
            this.UsersManagment.UseVisualStyleBackColor = false;
            this.UsersManagment.Click += new System.EventHandler(this.UsersManagment_Click);
            // 
            // EmpManagment
            // 
            this.EmpManagment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmpManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.EmpManagment.FlatAppearance.BorderSize = 0;
            this.EmpManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpManagment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpManagment.ForeColor = System.Drawing.Color.White;
            this.EmpManagment.Location = new System.Drawing.Point(695, 160);
            this.EmpManagment.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.EmpManagment.Name = "EmpManagment";
            this.EmpManagment.Size = new System.Drawing.Size(212, 50);
            this.EmpManagment.TabIndex = 21;
            this.EmpManagment.Text = "ادارة الموظفين";
            this.EmpManagment.UseVisualStyleBackColor = false;
            this.EmpManagment.Click += new System.EventHandler(this.EmpManagment_Click);
            // 
            // SalaryManagment
            // 
            this.SalaryManagment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SalaryManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.SalaryManagment.FlatAppearance.BorderSize = 0;
            this.SalaryManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryManagment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryManagment.ForeColor = System.Drawing.Color.White;
            this.SalaryManagment.Location = new System.Drawing.Point(695, 223);
            this.SalaryManagment.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SalaryManagment.Name = "SalaryManagment";
            this.SalaryManagment.Size = new System.Drawing.Size(212, 50);
            this.SalaryManagment.TabIndex = 22;
            this.SalaryManagment.Text = "صرفيات الرواتب";
            this.SalaryManagment.UseVisualStyleBackColor = false;
            this.SalaryManagment.Click += new System.EventHandler(this.SalaryManagment_Click);
            // 
            // Expense
            // 
            this.Expense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Expense.FlatAppearance.BorderSize = 0;
            this.Expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense.ForeColor = System.Drawing.Color.White;
            this.Expense.Location = new System.Drawing.Point(695, 278);
            this.Expense.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(212, 50);
            this.Expense.TabIndex = 23;
            this.Expense.Text = "الصرفيات";
            this.Expense.UseVisualStyleBackColor = false;
            this.Expense.Click += new System.EventHandler(this.Expense_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 0);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.UserFullNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(910, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 81);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(131, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 78);
            this.panel3.TabIndex = 1;
            // 
            // UserFullNameLbl
            // 
            this.UserFullNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserFullNameLbl.AutoSize = true;
            this.UserFullNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLbl.ForeColor = System.Drawing.Color.White;
            this.UserFullNameLbl.Location = new System.Drawing.Point(74, 33);
            this.UserFullNameLbl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.UserFullNameLbl.Name = "UserFullNameLbl";
            this.UserFullNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserFullNameLbl.Size = new System.Drawing.Size(51, 20);
            this.UserFullNameLbl.TabIndex = 6;
            this.UserFullNameLbl.Text = "label2";
            this.UserFullNameLbl.Click += new System.EventHandler(this.UserFullNameLbl_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1119, 705);
            this.Controls.Add(this.BtnsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BtnsPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LogoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SubName;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Panel BtnsPanel;
        private System.Windows.Forms.Button InvoicePrint;
        private System.Windows.Forms.Button Warehouses;
        private System.Windows.Forms.Button Mats;
        private System.Windows.Forms.Button sellings;
        private System.Windows.Forms.Button ProvidersAndBuyers;
        private System.Windows.Forms.Button ProvidersAndBuyers2;
        private System.Windows.Forms.Button Buyings;
        private System.Windows.Forms.Button CompanyInfo;
        private System.Windows.Forms.Button UsersManagment;
        private System.Windows.Forms.Button EmpManagment;
        private System.Windows.Forms.Button SalaryManagment;
        private System.Windows.Forms.Button Expense;
        private System.Windows.Forms.Button PrinterNameSettingBtn;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button ProviderReport;
        private System.Windows.Forms.Button CustomerReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label UserFullNameLbl;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace Pazek_Pascal_Schulbistro_2024
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUebersicht = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShowcase = new System.Windows.Forms.DataGridView();
            this.tabProductChange = new System.Windows.Forms.TabPage();
            this.dgvProductsToChange = new System.Windows.Forms.DataGridView();
            this.tabProductAdd = new System.Windows.Forms.TabPage();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAddAmpel = new System.Windows.Forms.ComboBox();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.tabStatistiken = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProdukt = new System.Windows.Forms.ComboBox();
            this.rbtnProduktstatistik = new System.Windows.Forms.RadioButton();
            this.rbtnUmsatz = new System.Windows.Forms.RadioButton();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.picAmpel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAllergene = new System.Windows.Forms.ListBox();
            this.lstZusatz = new System.Windows.Forms.ListBox();
            this.grpProductChange = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPC_Info = new System.Windows.Forms.TextBox();
            this.txtPC_Price = new System.Windows.Forms.TextBox();
            this.cmbPC_Ampel = new System.Windows.Forms.ComboBox();
            this.cmbPC_Category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPC_Name = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabUebersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcase)).BeginInit();
            this.tabProductChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsToChange)).BeginInit();
            this.tabProductAdd.SuspendLayout();
            this.tabStatistiken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAmpel)).BeginInit();
            this.grpProductChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSorting
            // 
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Alle Produkte"});
            this.cmbSorting.Location = new System.Drawing.Point(82, 9);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(151, 23);
            this.cmbSorting.TabIndex = 0;
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAdminLogin.Location = new System.Drawing.Point(710, 27);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBar.Location = new System.Drawing.Point(330, 9);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(255, 21);
            this.txtSearchBar.TabIndex = 2;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produktsuche:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUebersicht);
            this.tabControl1.Controls.Add(this.tabProductChange);
            this.tabControl1.Controls.Add(this.tabProductAdd);
            this.tabControl1.Controls.Add(this.tabStatistiken);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 342);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabUebersicht
            // 
            this.tabUebersicht.BackColor = System.Drawing.Color.SandyBrown;
            this.tabUebersicht.Controls.Add(this.label2);
            this.tabUebersicht.Controls.Add(this.label1);
            this.tabUebersicht.Controls.Add(this.dgvShowcase);
            this.tabUebersicht.Controls.Add(this.txtSearchBar);
            this.tabUebersicht.Controls.Add(this.cmbSorting);
            this.tabUebersicht.Location = new System.Drawing.Point(4, 24);
            this.tabUebersicht.Name = "tabUebersicht";
            this.tabUebersicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabUebersicht.Size = new System.Drawing.Size(591, 314);
            this.tabUebersicht.TabIndex = 0;
            this.tabUebersicht.Text = "Produktübersicht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategorien:";
            // 
            // dgvShowcase
            // 
            this.dgvShowcase.AllowUserToAddRows = false;
            this.dgvShowcase.AllowUserToDeleteRows = false;
            this.dgvShowcase.AllowUserToResizeColumns = false;
            this.dgvShowcase.AllowUserToResizeRows = false;
            this.dgvShowcase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowcase.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvShowcase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowcase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowcase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowcase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowcase.EnableHeadersVisualStyles = false;
            this.dgvShowcase.GridColor = System.Drawing.Color.BurlyWood;
            this.dgvShowcase.Location = new System.Drawing.Point(6, 36);
            this.dgvShowcase.MultiSelect = false;
            this.dgvShowcase.Name = "dgvShowcase";
            this.dgvShowcase.ReadOnly = true;
            this.dgvShowcase.RowHeadersVisible = false;
            this.dgvShowcase.Size = new System.Drawing.Size(579, 274);
            this.dgvShowcase.TabIndex = 0;
            this.dgvShowcase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowcase_CellClick);
            // 
            // tabProductChange
            // 
            this.tabProductChange.BackColor = System.Drawing.Color.SandyBrown;
            this.tabProductChange.Controls.Add(this.dgvProductsToChange);
            this.tabProductChange.Location = new System.Drawing.Point(4, 24);
            this.tabProductChange.Name = "tabProductChange";
            this.tabProductChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductChange.Size = new System.Drawing.Size(591, 314);
            this.tabProductChange.TabIndex = 1;
            this.tabProductChange.Text = "Produkte Ändern";
            // 
            // dgvProductsToChange
            // 
            this.dgvProductsToChange.AllowUserToAddRows = false;
            this.dgvProductsToChange.AllowUserToDeleteRows = false;
            this.dgvProductsToChange.AllowUserToResizeColumns = false;
            this.dgvProductsToChange.AllowUserToResizeRows = false;
            this.dgvProductsToChange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsToChange.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvProductsToChange.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsToChange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsToChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsToChange.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductsToChange.EnableHeadersVisualStyles = false;
            this.dgvProductsToChange.Location = new System.Drawing.Point(6, 6);
            this.dgvProductsToChange.MultiSelect = false;
            this.dgvProductsToChange.Name = "dgvProductsToChange";
            this.dgvProductsToChange.ReadOnly = true;
            this.dgvProductsToChange.RowHeadersVisible = false;
            this.dgvProductsToChange.Size = new System.Drawing.Size(579, 304);
            this.dgvProductsToChange.TabIndex = 1;
            this.dgvProductsToChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsToChange_CellClick);
            // 
            // tabProductAdd
            // 
            this.tabProductAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.tabProductAdd.Controls.Add(this.btnAddProduct);
            this.tabProductAdd.Controls.Add(this.label16);
            this.tabProductAdd.Controls.Add(this.label15);
            this.tabProductAdd.Controls.Add(this.label14);
            this.tabProductAdd.Controls.Add(this.label13);
            this.tabProductAdd.Controls.Add(this.label12);
            this.tabProductAdd.Controls.Add(this.label11);
            this.tabProductAdd.Controls.Add(this.cmbAddAmpel);
            this.tabProductAdd.Controls.Add(this.cmbAddCategory);
            this.tabProductAdd.Controls.Add(this.txtAddInfo);
            this.tabProductAdd.Controls.Add(this.txtAddPrice);
            this.tabProductAdd.Controls.Add(this.txtAddName);
            this.tabProductAdd.Location = new System.Drawing.Point(4, 24);
            this.tabProductAdd.Name = "tabProductAdd";
            this.tabProductAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductAdd.Size = new System.Drawing.Size(591, 314);
            this.tabProductAdd.TabIndex = 2;
            this.tabProductAdd.Text = "Produkte Hinzufügen";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddProduct.Location = new System.Drawing.Point(115, 227);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(202, 23);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Produkt Hinzufügen";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(180, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = "Produkt Hinzufügen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Nutri Ampel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Kategorie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Preis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bezeichnung";
            // 
            // cmbAddAmpel
            // 
            this.cmbAddAmpel.FormattingEnabled = true;
            this.cmbAddAmpel.Location = new System.Drawing.Point(196, 179);
            this.cmbAddAmpel.Name = "cmbAddAmpel";
            this.cmbAddAmpel.Size = new System.Drawing.Size(121, 23);
            this.cmbAddAmpel.TabIndex = 4;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(196, 152);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbAddCategory.TabIndex = 3;
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.Location = new System.Drawing.Point(196, 99);
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(121, 21);
            this.txtAddInfo.TabIndex = 2;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(196, 125);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(121, 21);
            this.txtAddPrice.TabIndex = 1;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(196, 73);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(121, 21);
            this.txtAddName.TabIndex = 0;
            // 
            // tabStatistiken
            // 
            this.tabStatistiken.BackColor = System.Drawing.Color.SandyBrown;
            this.tabStatistiken.Controls.Add(this.chart1);
            this.tabStatistiken.Controls.Add(this.panel1);
            this.tabStatistiken.Location = new System.Drawing.Point(4, 24);
            this.tabStatistiken.Name = "tabStatistiken";
            this.tabStatistiken.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistiken.Size = new System.Drawing.Size(591, 314);
            this.tabStatistiken.TabIndex = 3;
            this.tabStatistiken.Text = "Statistiken";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.BurlyWood;
            this.chart1.BorderlineColor = System.Drawing.Color.Moccasin;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 96);
            this.chart1.Name = "chart1";
            series1.BackSecondaryColor = System.Drawing.Color.FloralWhite;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.SaddleBrown;
            series1.Legend = "Legend1";
            series1.Name = "Statistik";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(579, 214);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbProdukt);
            this.panel1.Controls.Add(this.rbtnProduktstatistik);
            this.panel1.Controls.Add(this.rbtnUmsatz);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 84);
            this.panel1.TabIndex = 0;
            // 
            // cmbProdukt
            // 
            this.cmbProdukt.BackColor = System.Drawing.Color.FloralWhite;
            this.cmbProdukt.FormattingEnabled = true;
            this.cmbProdukt.Location = new System.Drawing.Point(16, 56);
            this.cmbProdukt.Name = "cmbProdukt";
            this.cmbProdukt.Size = new System.Drawing.Size(121, 23);
            this.cmbProdukt.TabIndex = 2;
            this.cmbProdukt.Visible = false;
            this.cmbProdukt.SelectedIndexChanged += new System.EventHandler(this.cmbProdukt_SelectedIndexChanged);
            // 
            // rbtnProduktstatistik
            // 
            this.rbtnProduktstatistik.AutoSize = true;
            this.rbtnProduktstatistik.Location = new System.Drawing.Point(16, 33);
            this.rbtnProduktstatistik.Name = "rbtnProduktstatistik";
            this.rbtnProduktstatistik.Size = new System.Drawing.Size(107, 19);
            this.rbtnProduktstatistik.TabIndex = 1;
            this.rbtnProduktstatistik.TabStop = true;
            this.rbtnProduktstatistik.Text = "Produktstatistik";
            this.rbtnProduktstatistik.UseVisualStyleBackColor = true;
            this.rbtnProduktstatistik.CheckedChanged += new System.EventHandler(this.rbtnProduktstatistik_CheckedChanged);
            // 
            // rbtnUmsatz
            // 
            this.rbtnUmsatz.AutoSize = true;
            this.rbtnUmsatz.Location = new System.Drawing.Point(16, 15);
            this.rbtnUmsatz.Name = "rbtnUmsatz";
            this.rbtnUmsatz.Size = new System.Drawing.Size(67, 19);
            this.rbtnUmsatz.TabIndex = 0;
            this.rbtnUmsatz.TabStop = true;
            this.rbtnUmsatz.Text = "Umsatz";
            this.rbtnUmsatz.UseVisualStyleBackColor = true;
            this.rbtnUmsatz.CheckedChanged += new System.EventHandler(this.rbtnUmsatz_CheckedChanged);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(12, 201);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(225, 23);
            this.btnChangeProduct.TabIndex = 2;
            this.btnChangeProduct.Text = "Übernehmen";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Schulbistro BKR \"MANNA\"";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.SandyBrown;
            this.grpDetails.Controls.Add(this.label17);
            this.grpDetails.Controls.Add(this.picAmpel);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.lstAllergene);
            this.grpDetails.Controls.Add(this.lstZusatz);
            this.grpDetails.Location = new System.Drawing.Point(618, 99);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(249, 284);
            this.grpDetails.TabIndex = 6;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Produktdetails";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Nutri-Ampel";
            // 
            // picAmpel
            // 
            this.picAmpel.Location = new System.Drawing.Point(24, 65);
            this.picAmpel.Name = "picAmpel";
            this.picAmpel.Size = new System.Drawing.Size(53, 159);
            this.picAmpel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAmpel.TabIndex = 5;
            this.picAmpel.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Allergene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zusatzstoffe";
            // 
            // lstAllergene
            // 
            this.lstAllergene.FormattingEnabled = true;
            this.lstAllergene.Location = new System.Drawing.Point(117, 172);
            this.lstAllergene.Name = "lstAllergene";
            this.lstAllergene.Size = new System.Drawing.Size(120, 95);
            this.lstAllergene.TabIndex = 1;
            // 
            // lstZusatz
            // 
            this.lstZusatz.FormattingEnabled = true;
            this.lstZusatz.Location = new System.Drawing.Point(117, 44);
            this.lstZusatz.Name = "lstZusatz";
            this.lstZusatz.Size = new System.Drawing.Size(120, 95);
            this.lstZusatz.TabIndex = 0;
            // 
            // grpProductChange
            // 
            this.grpProductChange.Controls.Add(this.label10);
            this.grpProductChange.Controls.Add(this.label9);
            this.grpProductChange.Controls.Add(this.label8);
            this.grpProductChange.Controls.Add(this.label7);
            this.grpProductChange.Controls.Add(this.txtPC_Info);
            this.grpProductChange.Controls.Add(this.txtPC_Price);
            this.grpProductChange.Controls.Add(this.cmbPC_Ampel);
            this.grpProductChange.Controls.Add(this.btnChangeProduct);
            this.grpProductChange.Controls.Add(this.cmbPC_Category);
            this.grpProductChange.Controls.Add(this.label6);
            this.grpProductChange.Controls.Add(this.txtPC_Name);
            this.grpProductChange.Location = new System.Drawing.Point(617, 99);
            this.grpProductChange.Name = "grpProductChange";
            this.grpProductChange.Size = new System.Drawing.Size(249, 284);
            this.grpProductChange.TabIndex = 7;
            this.grpProductChange.TabStop = false;
            this.grpProductChange.Text = "Gewähltes Produkt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Preis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kategorie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nutri-Ampel:";
            // 
            // txtPC_Info
            // 
            this.txtPC_Info.Location = new System.Drawing.Point(93, 70);
            this.txtPC_Info.Name = "txtPC_Info";
            this.txtPC_Info.Size = new System.Drawing.Size(144, 20);
            this.txtPC_Info.TabIndex = 5;
            // 
            // txtPC_Price
            // 
            this.txtPC_Price.Location = new System.Drawing.Point(93, 96);
            this.txtPC_Price.Name = "txtPC_Price";
            this.txtPC_Price.Size = new System.Drawing.Size(144, 20);
            this.txtPC_Price.TabIndex = 4;
            // 
            // cmbPC_Ampel
            // 
            this.cmbPC_Ampel.FormattingEnabled = true;
            this.cmbPC_Ampel.Location = new System.Drawing.Point(93, 153);
            this.cmbPC_Ampel.Name = "cmbPC_Ampel";
            this.cmbPC_Ampel.Size = new System.Drawing.Size(144, 21);
            this.cmbPC_Ampel.TabIndex = 3;
            // 
            // cmbPC_Category
            // 
            this.cmbPC_Category.FormattingEnabled = true;
            this.cmbPC_Category.Location = new System.Drawing.Point(93, 126);
            this.cmbPC_Category.Name = "cmbPC_Category";
            this.cmbPC_Category.Size = new System.Drawing.Size(144, 21);
            this.cmbPC_Category.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bezeichnung:";
            // 
            // txtPC_Name
            // 
            this.txtPC_Name.Location = new System.Drawing.Point(93, 44);
            this.txtPC_Name.Name = "txtPC_Name";
            this.txtPC_Name.Size = new System.Drawing.Size(144, 20);
            this.txtPC_Name.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pazek_Pascal_Schulbistro_2024.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 400);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.grpProductChange);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Schulbistro MANNA Sortimentübersicht";
            this.tabControl1.ResumeLayout(false);
            this.tabUebersicht.ResumeLayout(false);
            this.tabUebersicht.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcase)).EndInit();
            this.tabProductChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsToChange)).EndInit();
            this.tabProductAdd.ResumeLayout(false);
            this.tabProductAdd.PerformLayout();
            this.tabStatistiken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAmpel)).EndInit();
            this.grpProductChange.ResumeLayout(false);
            this.grpProductChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShowcase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ListBox lstZusatz;
        private System.Windows.Forms.ListBox lstAllergene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picAmpel;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabUebersicht;
        public System.Windows.Forms.TabPage tabProductChange;
        public System.Windows.Forms.TabPage tabProductAdd;
        public System.Windows.Forms.TabPage tabStatistiken;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.DataGridView dgvProductsToChange;
        private System.Windows.Forms.GroupBox grpProductChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPC_Info;
        private System.Windows.Forms.TextBox txtPC_Price;
        private System.Windows.Forms.ComboBox cmbPC_Ampel;
        private System.Windows.Forms.ComboBox cmbPC_Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPC_Name;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProdukt;
        private System.Windows.Forms.RadioButton rbtnProduktstatistik;
        private System.Windows.Forms.RadioButton rbtnUmsatz;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAddAmpel;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}


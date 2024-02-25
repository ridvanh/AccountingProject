
namespace FormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.accountsTabControl = new System.Windows.Forms.TabControl();
            this.manageAccountsTab = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.accComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.accDeleteBtn = new System.Windows.Forms.Button();
            this.accUpdateBtn = new System.Windows.Forms.Button();
            this.loadAccTextBox7 = new System.Windows.Forms.TextBox();
            this.loadAccTextBox6 = new System.Windows.Forms.TextBox();
            this.loadAccTextBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.loadAccTextBox4 = new System.Windows.Forms.TextBox();
            this.loadAccTextBox3 = new System.Windows.Forms.TextBox();
            this.loadAccTextBox2 = new System.Windows.Forms.TextBox();
            this.loadAccTextBox1 = new System.Windows.Forms.TextBox();
            this.accDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createAccountsTab = new System.Windows.Forms.TabPage();
            this.accAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBranchNoTBox = new System.Windows.Forms.TextBox();
            this.addCustomerNoTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccComboBox = new System.Windows.Forms.ComboBox();
            this.transactionsTab = new System.Windows.Forms.TabPage();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.paymentTab = new System.Windows.Forms.TabPage();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.accNoLabel = new System.Windows.Forms.Label();
            this.paymentTextBox2 = new System.Windows.Forms.TextBox();
            this.paymentTextBox1 = new System.Windows.Forms.TextBox();
            this.transactionsLoadTab = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.saveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.transactionDeleteBtn = new System.Windows.Forms.Button();
            this.transactionUpdateBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.trTextBox9 = new System.Windows.Forms.TextBox();
            this.trTextBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.trTextBox7 = new System.Windows.Forms.TextBox();
            this.trTextBox6 = new System.Windows.Forms.TextBox();
            this.trTextBox5 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.trTextBox4 = new System.Windows.Forms.TextBox();
            this.trTextBox3 = new System.Windows.Forms.TextBox();
            this.trTextBox2 = new System.Windows.Forms.TextBox();
            this.trTextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionComboBox = new System.Windows.Forms.ComboBox();
            this.transactionDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainTabControl.SuspendLayout();
            this.accountsTab.SuspendLayout();
            this.accountsTabControl.SuspendLayout();
            this.manageAccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGrid)).BeginInit();
            this.createAccountsTab.SuspendLayout();
            this.transactionsTab.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.paymentTab.SuspendLayout();
            this.transactionsLoadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.accountsTab);
            this.mainTabControl.Controls.Add(this.transactionsTab);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(998, 594);
            this.mainTabControl.TabIndex = 0;
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsTabControl);
            this.accountsTab.Location = new System.Drawing.Point(4, 24);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountsTab.Size = new System.Drawing.Size(990, 566);
            this.accountsTab.TabIndex = 0;
            this.accountsTab.Text = "Hesap İşlemleri";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // accountsTabControl
            // 
            this.accountsTabControl.Controls.Add(this.manageAccountsTab);
            this.accountsTabControl.Controls.Add(this.createAccountsTab);
            this.accountsTabControl.Location = new System.Drawing.Point(0, 0);
            this.accountsTabControl.Name = "accountsTabControl";
            this.accountsTabControl.SelectedIndex = 0;
            this.accountsTabControl.Size = new System.Drawing.Size(994, 570);
            this.accountsTabControl.TabIndex = 0;
            // 
            // manageAccountsTab
            // 
            this.manageAccountsTab.Controls.Add(this.label25);
            this.manageAccountsTab.Controls.Add(this.accComboBox);
            this.manageAccountsTab.Controls.Add(this.label9);
            this.manageAccountsTab.Controls.Add(this.label10);
            this.manageAccountsTab.Controls.Add(this.label11);
            this.manageAccountsTab.Controls.Add(this.label12);
            this.manageAccountsTab.Controls.Add(this.label13);
            this.manageAccountsTab.Controls.Add(this.label14);
            this.manageAccountsTab.Controls.Add(this.label15);
            this.manageAccountsTab.Controls.Add(this.accDeleteBtn);
            this.manageAccountsTab.Controls.Add(this.accUpdateBtn);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox7);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox6);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox5);
            this.manageAccountsTab.Controls.Add(this.label16);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox4);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox3);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox2);
            this.manageAccountsTab.Controls.Add(this.loadAccTextBox1);
            this.manageAccountsTab.Controls.Add(this.accDataGrid);
            this.manageAccountsTab.Controls.Add(this.groupBox2);
            this.manageAccountsTab.Location = new System.Drawing.Point(4, 24);
            this.manageAccountsTab.Name = "manageAccountsTab";
            this.manageAccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.manageAccountsTab.Size = new System.Drawing.Size(986, 542);
            this.manageAccountsTab.TabIndex = 0;
            this.manageAccountsTab.Text = "Hesap Yönetimi";
            this.manageAccountsTab.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(30, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 15);
            this.label25.TabIndex = 37;
            this.label25.Text = "Hesap Türü";
            // 
            // accComboBox
            // 
            this.accComboBox.FormattingEnabled = true;
            this.accComboBox.Items.AddRange(new object[] {
            "Hepsi",
            "Müşteri",
            "Çalışan",
            "Şirket"});
            this.accComboBox.Location = new System.Drawing.Point(109, 33);
            this.accComboBox.Name = "accComboBox";
            this.accComboBox.Size = new System.Drawing.Size(100, 23);
            this.accComboBox.TabIndex = 36;
            this.accComboBox.Text = "Seçiniz";
            this.accComboBox.SelectedIndexChanged += new System.EventHandler(this.accComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(742, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Hesap Açıklaması";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Bakiye";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(650, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Hesap Türü";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ek NO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Müşteri NO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Şube NO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(123, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Hesap NO";
            // 
            // accDeleteBtn
            // 
            this.accDeleteBtn.Location = new System.Drawing.Point(875, 109);
            this.accDeleteBtn.Name = "accDeleteBtn";
            this.accDeleteBtn.Size = new System.Drawing.Size(89, 29);
            this.accDeleteBtn.TabIndex = 28;
            this.accDeleteBtn.Text = "Sil";
            this.accDeleteBtn.UseVisualStyleBackColor = true;
            this.accDeleteBtn.Click += new System.EventHandler(this.accDeleteBtn_Click);
            // 
            // accUpdateBtn
            // 
            this.accUpdateBtn.Location = new System.Drawing.Point(875, 74);
            this.accUpdateBtn.Name = "accUpdateBtn";
            this.accUpdateBtn.Size = new System.Drawing.Size(89, 29);
            this.accUpdateBtn.TabIndex = 27;
            this.accUpdateBtn.Text = "Güncelle";
            this.accUpdateBtn.UseVisualStyleBackColor = true;
            this.accUpdateBtn.Click += new System.EventHandler(this.accUpdateBtn_Click);
            // 
            // loadAccTextBox7
            // 
            this.loadAccTextBox7.Location = new System.Drawing.Point(742, 97);
            this.loadAccTextBox7.Name = "loadAccTextBox7";
            this.loadAccTextBox7.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox7.TabIndex = 26;
            this.loadAccTextBox7.TextChanged += new System.EventHandler(this.loadAccTextBox7_TextChanged);
            // 
            // loadAccTextBox6
            // 
            this.loadAccTextBox6.Location = new System.Drawing.Point(636, 97);
            this.loadAccTextBox6.Name = "loadAccTextBox6";
            this.loadAccTextBox6.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox6.TabIndex = 25;
            this.loadAccTextBox6.TextChanged += new System.EventHandler(this.loadAccTextBox6_TextChanged);
            // 
            // loadAccTextBox5
            // 
            this.loadAccTextBox5.Location = new System.Drawing.Point(530, 97);
            this.loadAccTextBox5.Name = "loadAccTextBox5";
            this.loadAccTextBox5.ReadOnly = true;
            this.loadAccTextBox5.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox5.TabIndex = 24;
            this.loadAccTextBox5.TextChanged += new System.EventHandler(this.loadAccTextBox5_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(30, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Seçili Hesap";
            // 
            // loadAccTextBox4
            // 
            this.loadAccTextBox4.Location = new System.Drawing.Point(424, 97);
            this.loadAccTextBox4.Name = "loadAccTextBox4";
            this.loadAccTextBox4.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox4.TabIndex = 22;
            this.loadAccTextBox4.TextChanged += new System.EventHandler(this.loadAccTextBox4_TextChanged);
            // 
            // loadAccTextBox3
            // 
            this.loadAccTextBox3.Location = new System.Drawing.Point(318, 97);
            this.loadAccTextBox3.Name = "loadAccTextBox3";
            this.loadAccTextBox3.ReadOnly = true;
            this.loadAccTextBox3.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox3.TabIndex = 21;
            this.loadAccTextBox3.TextChanged += new System.EventHandler(this.loadAccTextBox3_TextChanged);
            // 
            // loadAccTextBox2
            // 
            this.loadAccTextBox2.Location = new System.Drawing.Point(212, 97);
            this.loadAccTextBox2.Name = "loadAccTextBox2";
            this.loadAccTextBox2.ReadOnly = true;
            this.loadAccTextBox2.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox2.TabIndex = 20;
            this.loadAccTextBox2.TextChanged += new System.EventHandler(this.loadAccTextBox2_TextChanged);
            // 
            // loadAccTextBox1
            // 
            this.loadAccTextBox1.Location = new System.Drawing.Point(106, 97);
            this.loadAccTextBox1.Name = "loadAccTextBox1";
            this.loadAccTextBox1.ReadOnly = true;
            this.loadAccTextBox1.Size = new System.Drawing.Size(100, 23);
            this.loadAccTextBox1.TabIndex = 19;
            this.loadAccTextBox1.TextChanged += new System.EventHandler(this.loadAccTextBox1_TextChanged);
            // 
            // accDataGrid
            // 
            this.accDataGrid.AllowUserToAddRows = false;
            this.accDataGrid.AllowUserToDeleteRows = false;
            this.accDataGrid.AllowUserToResizeColumns = false;
            this.accDataGrid.AllowUserToResizeRows = false;
            this.accDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.accDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accDataGrid.Location = new System.Drawing.Point(-4, 159);
            this.accDataGrid.MultiSelect = false;
            this.accDataGrid.Name = "accDataGrid";
            this.accDataGrid.ReadOnly = true;
            this.accDataGrid.RowTemplate.Height = 25;
            this.accDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accDataGrid.Size = new System.Drawing.Size(991, 383);
            this.accDataGrid.TabIndex = 0;
            this.accDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accDataGrid_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(17, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 49);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtreler";
            // 
            // createAccountsTab
            // 
            this.createAccountsTab.Controls.Add(this.accAddBtn);
            this.createAccountsTab.Controls.Add(this.label3);
            this.createAccountsTab.Controls.Add(this.label2);
            this.createAccountsTab.Controls.Add(this.addBranchNoTBox);
            this.createAccountsTab.Controls.Add(this.addCustomerNoTBox);
            this.createAccountsTab.Controls.Add(this.label1);
            this.createAccountsTab.Controls.Add(this.addAccComboBox);
            this.createAccountsTab.Location = new System.Drawing.Point(4, 24);
            this.createAccountsTab.Name = "createAccountsTab";
            this.createAccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.createAccountsTab.Size = new System.Drawing.Size(986, 542);
            this.createAccountsTab.TabIndex = 1;
            this.createAccountsTab.Text = "Hesap Ekleme";
            this.createAccountsTab.UseVisualStyleBackColor = true;
            // 
            // accAddBtn
            // 
            this.accAddBtn.Location = new System.Drawing.Point(442, 87);
            this.accAddBtn.Name = "accAddBtn";
            this.accAddBtn.Size = new System.Drawing.Size(93, 35);
            this.accAddBtn.TabIndex = 8;
            this.accAddBtn.Text = "Hesap Ekle";
            this.accAddBtn.UseVisualStyleBackColor = true;
            this.accAddBtn.Click += new System.EventHandler(this.accAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şube NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri NO";
            // 
            // addBranchNoTBox
            // 
            this.addBranchNoTBox.Location = new System.Drawing.Point(459, 35);
            this.addBranchNoTBox.Name = "addBranchNoTBox";
            this.addBranchNoTBox.Size = new System.Drawing.Size(100, 23);
            this.addBranchNoTBox.TabIndex = 3;
            this.addBranchNoTBox.TextChanged += new System.EventHandler(this.addBranchNoTBox_TextChanged);
            // 
            // addCustomerNoTBox
            // 
            this.addCustomerNoTBox.Location = new System.Drawing.Point(284, 35);
            this.addCustomerNoTBox.Name = "addCustomerNoTBox";
            this.addCustomerNoTBox.Size = new System.Drawing.Size(100, 23);
            this.addCustomerNoTBox.TabIndex = 2;
            this.addCustomerNoTBox.TextChanged += new System.EventHandler(this.addCustomerNoTBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap Türü";
            // 
            // addAccComboBox
            // 
            this.addAccComboBox.FormattingEnabled = true;
            this.addAccComboBox.Items.AddRange(new object[] {
            "Şirket",
            "Çalışan",
            "Müşteri"});
            this.addAccComboBox.Location = new System.Drawing.Point(649, 35);
            this.addAccComboBox.Name = "addAccComboBox";
            this.addAccComboBox.Size = new System.Drawing.Size(100, 23);
            this.addAccComboBox.TabIndex = 0;
            // 
            // transactionsTab
            // 
            this.transactionsTab.Controls.Add(this.transactionsTabControl);
            this.transactionsTab.Location = new System.Drawing.Point(4, 24);
            this.transactionsTab.Name = "transactionsTab";
            this.transactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTab.Size = new System.Drawing.Size(990, 566);
            this.transactionsTab.TabIndex = 1;
            this.transactionsTab.Text = "Muhasebe İşlemleri";
            this.transactionsTab.UseVisualStyleBackColor = true;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Controls.Add(this.paymentTab);
            this.transactionsTabControl.Controls.Add(this.transactionsLoadTab);
            this.transactionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(990, 570);
            this.transactionsTabControl.TabIndex = 1;
            // 
            // paymentTab
            // 
            this.paymentTab.Controls.Add(this.brandLabel);
            this.paymentTab.Controls.Add(this.brandComboBox);
            this.paymentTab.Controls.Add(this.paymentComboBox);
            this.paymentTab.Controls.Add(this.label4);
            this.paymentTab.Controls.Add(this.payBtn);
            this.paymentTab.Controls.Add(this.label24);
            this.paymentTab.Controls.Add(this.accNoLabel);
            this.paymentTab.Controls.Add(this.paymentTextBox2);
            this.paymentTab.Controls.Add(this.paymentTextBox1);
            this.paymentTab.Location = new System.Drawing.Point(4, 24);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.paymentTab.Size = new System.Drawing.Size(982, 542);
            this.paymentTab.TabIndex = 0;
            this.paymentTab.Text = "Ödeme İşlemleri";
            this.paymentTab.UseVisualStyleBackColor = true;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(152, 99);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(67, 15);
            this.brandLabel.TabIndex = 17;
            this.brandLabel.Text = "Araç Marka";
            this.brandLabel.Visible = false;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "Mercedes",
            "BMW",
            "Audi"});
            this.brandComboBox.Location = new System.Drawing.Point(229, 96);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(100, 23);
            this.brandComboBox.TabIndex = 16;
            this.brandComboBox.Visible = false;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Maaş",
            "Araç Satış",
            "Servis",
            "Diğer"});
            this.paymentComboBox.Location = new System.Drawing.Point(229, 32);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(100, 23);
            this.paymentComboBox.TabIndex = 15;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "İşlem Tipi";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(457, 89);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(93, 35);
            this.payBtn.TabIndex = 13;
            this.payBtn.Text = "Ödeme Yap";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(574, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 15);
            this.label24.TabIndex = 12;
            this.label24.Text = "İşlem Tutarı";
            // 
            // accNoLabel
            // 
            this.accNoLabel.AutoSize = true;
            this.accNoLabel.Location = new System.Drawing.Point(352, 35);
            this.accNoLabel.Name = "accNoLabel";
            this.accNoLabel.Size = new System.Drawing.Size(99, 15);
            this.accNoLabel.TabIndex = 11;
            this.accNoLabel.Text = "Alacak Hesap NO";
            // 
            // paymentTextBox2
            // 
            this.paymentTextBox2.Location = new System.Drawing.Point(651, 32);
            this.paymentTextBox2.Name = "paymentTextBox2";
            this.paymentTextBox2.Size = new System.Drawing.Size(100, 23);
            this.paymentTextBox2.TabIndex = 10;
            this.paymentTextBox2.TextChanged += new System.EventHandler(this.paymentTextBox2_TextChanged);
            // 
            // paymentTextBox1
            // 
            this.paymentTextBox1.Location = new System.Drawing.Point(457, 32);
            this.paymentTextBox1.Name = "paymentTextBox1";
            this.paymentTextBox1.Size = new System.Drawing.Size(100, 23);
            this.paymentTextBox1.TabIndex = 9;
            this.paymentTextBox1.TextChanged += new System.EventHandler(this.paymentTextBox1_TextChanged);
            // 
            // transactionsLoadTab
            // 
            this.transactionsLoadTab.Controls.Add(this.label26);
            this.transactionsLoadTab.Controls.Add(this.saveTypeComboBox);
            this.transactionsLoadTab.Controls.Add(this.transactionDeleteBtn);
            this.transactionsLoadTab.Controls.Add(this.transactionUpdateBtn);
            this.transactionsLoadTab.Controls.Add(this.label22);
            this.transactionsLoadTab.Controls.Add(this.label23);
            this.transactionsLoadTab.Controls.Add(this.trTextBox9);
            this.transactionsLoadTab.Controls.Add(this.trTextBox8);
            this.transactionsLoadTab.Controls.Add(this.label6);
            this.transactionsLoadTab.Controls.Add(this.label7);
            this.transactionsLoadTab.Controls.Add(this.label8);
            this.transactionsLoadTab.Controls.Add(this.label17);
            this.transactionsLoadTab.Controls.Add(this.label18);
            this.transactionsLoadTab.Controls.Add(this.label19);
            this.transactionsLoadTab.Controls.Add(this.label20);
            this.transactionsLoadTab.Controls.Add(this.trTextBox7);
            this.transactionsLoadTab.Controls.Add(this.trTextBox6);
            this.transactionsLoadTab.Controls.Add(this.trTextBox5);
            this.transactionsLoadTab.Controls.Add(this.label21);
            this.transactionsLoadTab.Controls.Add(this.trTextBox4);
            this.transactionsLoadTab.Controls.Add(this.trTextBox3);
            this.transactionsLoadTab.Controls.Add(this.trTextBox2);
            this.transactionsLoadTab.Controls.Add(this.trTextBox1);
            this.transactionsLoadTab.Controls.Add(this.label5);
            this.transactionsLoadTab.Controls.Add(this.transactionComboBox);
            this.transactionsLoadTab.Controls.Add(this.transactionDataGrid);
            this.transactionsLoadTab.Controls.Add(this.groupBox1);
            this.transactionsLoadTab.Location = new System.Drawing.Point(4, 24);
            this.transactionsLoadTab.Name = "transactionsLoadTab";
            this.transactionsLoadTab.Size = new System.Drawing.Size(982, 542);
            this.transactionsLoadTab.TabIndex = 4;
            this.transactionsLoadTab.Text = "Muhasebe Kayıtları";
            this.transactionsLoadTab.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(212, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 15);
            this.label26.TabIndex = 62;
            this.label26.Text = "Kayıt Durumu";
            // 
            // saveTypeComboBox
            // 
            this.saveTypeComboBox.FormattingEnabled = true;
            this.saveTypeComboBox.Items.AddRange(new object[] {
            "Hepsi",
            "Pasif (0)",
            "Aktif (1)"});
            this.saveTypeComboBox.Location = new System.Drawing.Point(311, 27);
            this.saveTypeComboBox.Name = "saveTypeComboBox";
            this.saveTypeComboBox.Size = new System.Drawing.Size(100, 23);
            this.saveTypeComboBox.TabIndex = 61;
            this.saveTypeComboBox.Text = "Seçiniz";
            this.saveTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.saveTypeComboBox_SelectedIndexChanged);
            // 
            // transactionDeleteBtn
            // 
            this.transactionDeleteBtn.Location = new System.Drawing.Point(868, 142);
            this.transactionDeleteBtn.Name = "transactionDeleteBtn";
            this.transactionDeleteBtn.Size = new System.Drawing.Size(89, 29);
            this.transactionDeleteBtn.TabIndex = 60;
            this.transactionDeleteBtn.Text = "Sil";
            this.transactionDeleteBtn.UseVisualStyleBackColor = true;
            this.transactionDeleteBtn.Click += new System.EventHandler(this.transactionDeleteBtn_Click);
            // 
            // transactionUpdateBtn
            // 
            this.transactionUpdateBtn.Location = new System.Drawing.Point(868, 107);
            this.transactionUpdateBtn.Name = "transactionUpdateBtn";
            this.transactionUpdateBtn.Size = new System.Drawing.Size(89, 29);
            this.transactionUpdateBtn.TabIndex = 59;
            this.transactionUpdateBtn.Text = "Güncelle";
            this.transactionUpdateBtn.UseVisualStyleBackColor = true;
            this.transactionUpdateBtn.Click += new System.EventHandler(this.transactionUpdateBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(217, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 15);
            this.label22.TabIndex = 58;
            this.label22.Text = "Kayıt Durumu";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(114, 137);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 15);
            this.label23.TabIndex = 57;
            this.label23.Text = "İşlemi Yapan";
            // 
            // trTextBox9
            // 
            this.trTextBox9.Location = new System.Drawing.Point(206, 155);
            this.trTextBox9.Name = "trTextBox9";
            this.trTextBox9.Size = new System.Drawing.Size(100, 23);
            this.trTextBox9.TabIndex = 56;
            this.trTextBox9.TextChanged += new System.EventHandler(this.trTextBox9_TextChanged);
            // 
            // trTextBox8
            // 
            this.trTextBox8.Location = new System.Drawing.Point(100, 155);
            this.trTextBox8.Name = "trTextBox8";
            this.trTextBox8.Size = new System.Drawing.Size(100, 23);
            this.trTextBox8.TabIndex = 55;
            this.trTextBox8.TextChanged += new System.EventHandler(this.trTextBox8_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "İşlem Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Alacak Hesap NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "Borçlu Hesap NO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 51;
            this.label17.Text = "İşlem Tutarı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 15);
            this.label18.TabIndex = 50;
            this.label18.Text = "İşlem Tipi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(317, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 15);
            this.label19.TabIndex = 49;
            this.label19.Text = "İşlem Açıklaması";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(125, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 15);
            this.label20.TabIndex = 48;
            this.label20.Text = "İşlem NO";
            // 
            // trTextBox7
            // 
            this.trTextBox7.Location = new System.Drawing.Point(736, 104);
            this.trTextBox7.Name = "trTextBox7";
            this.trTextBox7.ReadOnly = true;
            this.trTextBox7.Size = new System.Drawing.Size(100, 23);
            this.trTextBox7.TabIndex = 47;
            this.trTextBox7.TextChanged += new System.EventHandler(this.trTextBox7_TextChanged);
            // 
            // trTextBox6
            // 
            this.trTextBox6.Location = new System.Drawing.Point(630, 104);
            this.trTextBox6.Name = "trTextBox6";
            this.trTextBox6.ReadOnly = true;
            this.trTextBox6.Size = new System.Drawing.Size(100, 23);
            this.trTextBox6.TabIndex = 46;
            this.trTextBox6.TextChanged += new System.EventHandler(this.trTextBox6_TextChanged);
            // 
            // trTextBox5
            // 
            this.trTextBox5.Location = new System.Drawing.Point(524, 104);
            this.trTextBox5.Name = "trTextBox5";
            this.trTextBox5.ReadOnly = true;
            this.trTextBox5.Size = new System.Drawing.Size(100, 23);
            this.trTextBox5.TabIndex = 45;
            this.trTextBox5.TextChanged += new System.EventHandler(this.trTextBox5_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(24, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 44;
            this.label21.Text = "Seçili Kayıt";
            // 
            // trTextBox4
            // 
            this.trTextBox4.Location = new System.Drawing.Point(418, 104);
            this.trTextBox4.Name = "trTextBox4";
            this.trTextBox4.ReadOnly = true;
            this.trTextBox4.Size = new System.Drawing.Size(100, 23);
            this.trTextBox4.TabIndex = 43;
            this.trTextBox4.TextChanged += new System.EventHandler(this.trTextBox4_TextChanged);
            // 
            // trTextBox3
            // 
            this.trTextBox3.Location = new System.Drawing.Point(312, 104);
            this.trTextBox3.Name = "trTextBox3";
            this.trTextBox3.Size = new System.Drawing.Size(100, 23);
            this.trTextBox3.TabIndex = 42;
            this.trTextBox3.TextChanged += new System.EventHandler(this.trTextBox3_TextChanged);
            // 
            // trTextBox2
            // 
            this.trTextBox2.Location = new System.Drawing.Point(206, 104);
            this.trTextBox2.Name = "trTextBox2";
            this.trTextBox2.Size = new System.Drawing.Size(100, 23);
            this.trTextBox2.TabIndex = 41;
            this.trTextBox2.TextChanged += new System.EventHandler(this.trTextBox2_TextChanged);
            // 
            // trTextBox1
            // 
            this.trTextBox1.Location = new System.Drawing.Point(100, 104);
            this.trTextBox1.Name = "trTextBox1";
            this.trTextBox1.ReadOnly = true;
            this.trTextBox1.Size = new System.Drawing.Size(100, 23);
            this.trTextBox1.TabIndex = 40;
            this.trTextBox1.TextChanged += new System.EventHandler(this.trTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "İşlem Türü";
            // 
            // transactionComboBox
            // 
            this.transactionComboBox.FormattingEnabled = true;
            this.transactionComboBox.Items.AddRange(new object[] {
            "Hepsi",
            "Maaş",
            "Araç Satış",
            "Servis",
            "Diğer"});
            this.transactionComboBox.Location = new System.Drawing.Point(101, 27);
            this.transactionComboBox.Name = "transactionComboBox";
            this.transactionComboBox.Size = new System.Drawing.Size(100, 23);
            this.transactionComboBox.TabIndex = 38;
            this.transactionComboBox.Text = "Seçiniz";
            this.transactionComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionComboBox_SelectedIndexChanged);
            // 
            // transactionDataGrid
            // 
            this.transactionDataGrid.AllowUserToAddRows = false;
            this.transactionDataGrid.AllowUserToDeleteRows = false;
            this.transactionDataGrid.AllowUserToResizeColumns = false;
            this.transactionDataGrid.AllowUserToResizeRows = false;
            this.transactionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.transactionDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGrid.Location = new System.Drawing.Point(-4, 190);
            this.transactionDataGrid.MultiSelect = false;
            this.transactionDataGrid.Name = "transactionDataGrid";
            this.transactionDataGrid.ReadOnly = true;
            this.transactionDataGrid.RowTemplate.Height = 25;
            this.transactionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDataGrid.Size = new System.Drawing.Size(987, 352);
            this.transactionDataGrid.TabIndex = 1;
            this.transactionDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionDataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 59);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 596);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Oto Galeri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.accountsTab.ResumeLayout(false);
            this.accountsTabControl.ResumeLayout(false);
            this.manageAccountsTab.ResumeLayout(false);
            this.manageAccountsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGrid)).EndInit();
            this.createAccountsTab.ResumeLayout(false);
            this.createAccountsTab.PerformLayout();
            this.transactionsTab.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.paymentTab.ResumeLayout(false);
            this.paymentTab.PerformLayout();
            this.transactionsLoadTab.ResumeLayout(false);
            this.transactionsLoadTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage accountsTab;
        private System.Windows.Forms.TabPage transactionsTab;
        private System.Windows.Forms.TabControl accountsTabControl;
        private System.Windows.Forms.TabPage manageAccountsTab;
        private System.Windows.Forms.TabPage createAccountsTab;
        private System.Windows.Forms.TabControl transactionsTabControl;
        private System.Windows.Forms.TabPage paymentTab;
        private System.Windows.Forms.DataGridView accDataGrid;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox accComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button accDeleteBtn;
        private System.Windows.Forms.Button accUpdateBtn;
        private System.Windows.Forms.TextBox loadAccTextBox7;
        private System.Windows.Forms.TextBox loadAccTextBox6;
        private System.Windows.Forms.TextBox loadAccTextBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox loadAccTextBox4;
        private System.Windows.Forms.TextBox loadAccTextBox3;
        private System.Windows.Forms.TextBox loadAccTextBox2;
        private System.Windows.Forms.TextBox loadAccTextBox1;
        private System.Windows.Forms.ComboBox addAccComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addBranchNoTBox;
        private System.Windows.Forms.TextBox addCustomerNoTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accAddBtn;
        private System.Windows.Forms.TabPage transactionsLoadTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox transactionComboBox;
        private System.Windows.Forms.DataGridView transactionDataGrid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox trTextBox9;
        private System.Windows.Forms.TextBox trTextBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox trTextBox7;
        private System.Windows.Forms.TextBox trTextBox6;
        private System.Windows.Forms.TextBox trTextBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox trTextBox4;
        private System.Windows.Forms.TextBox trTextBox3;
        private System.Windows.Forms.TextBox trTextBox2;
        private System.Windows.Forms.TextBox trTextBox1;
        private System.Windows.Forms.Button transactionDeleteBtn;
        private System.Windows.Forms.Button transactionUpdateBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label accNoLabel;
        private System.Windows.Forms.TextBox paymentTextBox2;
        private System.Windows.Forms.TextBox paymentTextBox1;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox saveTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


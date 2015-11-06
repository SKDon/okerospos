namespace OBS.Pos.UI.Customers
{
    partial class frmCustomer
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label paymentModeIdLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label minBalanceLabel;
            System.Windows.Forms.Label minCreditLabel;
            System.Windows.Forms.Label openBalanceLabel;
            System.Windows.Forms.Label contactFirstNameLabel;
            System.Windows.Forms.Label contactLastNameLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label contactEmailLabel;
            System.Windows.Forms.Label contactAddressLabel;
            System.Windows.Forms.Label createdOnLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label modifiedOnLabel;
            System.Windows.Forms.Label modifiedByLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.posData = new OBS.Pos.PosData();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new OBS.Pos.PosDataTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new OBS.Pos.PosDataTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openBalanceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minCreditMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minBalanceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.paymentModeIdComboBox = new System.Windows.Forms.ComboBox();
            this.paymentModesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.contactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.contactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.contactEmailTextBox = new System.Windows.Forms.TextBox();
            this.contactAddressTextBox = new System.Windows.Forms.TextBox();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.createdOnLabel1 = new System.Windows.Forms.Label();
            this.createdByLabel1 = new System.Windows.Forms.Label();
            this.modifiedOnLabel1 = new System.Windows.Forms.Label();
            this.modifiedByLabel1 = new System.Windows.Forms.Label();
            this.paymentModesTableAdapter = new OBS.Pos.PosDataTableAdapters.PaymentModesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            customerNameLabel = new System.Windows.Forms.Label();
            paymentModeIdLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            minBalanceLabel = new System.Windows.Forms.Label();
            minCreditLabel = new System.Windows.Forms.Label();
            openBalanceLabel = new System.Windows.Forms.Label();
            contactFirstNameLabel = new System.Windows.Forms.Label();
            contactLastNameLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            contactEmailLabel = new System.Windows.Forms.Label();
            contactAddressLabel = new System.Windows.Forms.Label();
            createdOnLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            modifiedOnLabel = new System.Windows.Forms.Label();
            modifiedByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingSource)).BeginInit();
            this.tabContact.SuspendLayout();
            this.tabOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.ForeColor = System.Drawing.Color.Blue;
            customerNameLabel.Location = new System.Drawing.Point(44, 42);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Customer Name:";
            // 
            // paymentModeIdLabel
            // 
            paymentModeIdLabel.AutoSize = true;
            paymentModeIdLabel.ForeColor = System.Drawing.Color.Blue;
            paymentModeIdLabel.Location = new System.Drawing.Point(44, 68);
            paymentModeIdLabel.Name = "paymentModeIdLabel";
            paymentModeIdLabel.Size = new System.Drawing.Size(81, 13);
            paymentModeIdLabel.TabIndex = 2;
            paymentModeIdLabel.Text = "Payment Mode:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(44, 95);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(44, 185);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // minBalanceLabel
            // 
            minBalanceLabel.AutoSize = true;
            minBalanceLabel.ForeColor = System.Drawing.Color.Blue;
            minBalanceLabel.Location = new System.Drawing.Point(18, 28);
            minBalanceLabel.Name = "minBalanceLabel";
            minBalanceLabel.Size = new System.Drawing.Size(93, 13);
            minBalanceLabel.TabIndex = 18;
            minBalanceLabel.Text = "Minimum Balance:";
            // 
            // minCreditLabel
            // 
            minCreditLabel.AutoSize = true;
            minCreditLabel.ForeColor = System.Drawing.Color.Blue;
            minCreditLabel.Location = new System.Drawing.Point(18, 54);
            minCreditLabel.Name = "minCreditLabel";
            minCreditLabel.Size = new System.Drawing.Size(61, 13);
            minCreditLabel.TabIndex = 20;
            minCreditLabel.Text = "Credit Limit:";
            // 
            // openBalanceLabel
            // 
            openBalanceLabel.AutoSize = true;
            openBalanceLabel.ForeColor = System.Drawing.Color.Blue;
            openBalanceLabel.Location = new System.Drawing.Point(18, 80);
            openBalanceLabel.Name = "openBalanceLabel";
            openBalanceLabel.Size = new System.Drawing.Size(78, 13);
            openBalanceLabel.TabIndex = 22;
            openBalanceLabel.Text = "Open Balance:";
            // 
            // contactFirstNameLabel
            // 
            contactFirstNameLabel.AutoSize = true;
            contactFirstNameLabel.Location = new System.Drawing.Point(37, 35);
            contactFirstNameLabel.Name = "contactFirstNameLabel";
            contactFirstNameLabel.Size = new System.Drawing.Size(100, 13);
            contactFirstNameLabel.TabIndex = 18;
            contactFirstNameLabel.Text = "Contact First Name:";
            // 
            // contactLastNameLabel
            // 
            contactLastNameLabel.AutoSize = true;
            contactLastNameLabel.Location = new System.Drawing.Point(37, 61);
            contactLastNameLabel.Name = "contactLastNameLabel";
            contactLastNameLabel.Size = new System.Drawing.Size(101, 13);
            contactLastNameLabel.TabIndex = 20;
            contactLastNameLabel.Text = "Contact Last Name:";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new System.Drawing.Point(37, 87);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(81, 13);
            contactPhoneLabel.TabIndex = 22;
            contactPhoneLabel.Text = "Contact Phone:";
            // 
            // contactEmailLabel
            // 
            contactEmailLabel.AutoSize = true;
            contactEmailLabel.Location = new System.Drawing.Point(37, 113);
            contactEmailLabel.Name = "contactEmailLabel";
            contactEmailLabel.Size = new System.Drawing.Size(75, 13);
            contactEmailLabel.TabIndex = 24;
            contactEmailLabel.Text = "Contact Email:";
            // 
            // contactAddressLabel
            // 
            contactAddressLabel.AutoSize = true;
            contactAddressLabel.Location = new System.Drawing.Point(37, 139);
            contactAddressLabel.Name = "contactAddressLabel";
            contactAddressLabel.Size = new System.Drawing.Size(88, 13);
            contactAddressLabel.TabIndex = 26;
            contactAddressLabel.Text = "Contact Address:";
            // 
            // createdOnLabel
            // 
            createdOnLabel.AutoSize = true;
            createdOnLabel.Location = new System.Drawing.Point(37, 41);
            createdOnLabel.Name = "createdOnLabel";
            createdOnLabel.Size = new System.Drawing.Size(64, 13);
            createdOnLabel.TabIndex = 32;
            createdOnLabel.Text = "Created On:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(37, 64);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 34;
            createdByLabel.Text = "Created By:";
            // 
            // modifiedOnLabel
            // 
            modifiedOnLabel.AutoSize = true;
            modifiedOnLabel.Location = new System.Drawing.Point(37, 87);
            modifiedOnLabel.Name = "modifiedOnLabel";
            modifiedOnLabel.Size = new System.Drawing.Size(67, 13);
            modifiedOnLabel.TabIndex = 36;
            modifiedOnLabel.Text = "Modified On:";
            // 
            // modifiedByLabel
            // 
            modifiedByLabel.AutoSize = true;
            modifiedByLabel.Location = new System.Drawing.Point(37, 110);
            modifiedByLabel.Name = "modifiedByLabel";
            modifiedByLabel.Size = new System.Drawing.Size(65, 13);
            modifiedByLabel.TabIndex = 38;
            modifiedByLabel.Text = "Modified By:";
            // 
            // posData
            // 
            this.posData.DataSetName = "PosData";
            this.posData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.posData;
            this.customersBindingSource.CurrentChanged += new System.EventHandler(this.customersBindingSource_CurrentChanged);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppSettingsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CurrenciesTableAdapter = null;
            this.tableAdapterManager.CustomerOutsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.PaymentModesTableAdapter = null;
            this.tableAdapterManager.PaymentTypesTableAdapter = null;
            this.tableAdapterManager.PayTransTableAdapter = null;
            this.tableAdapterManager.PeriodsTableAdapter = null;
            this.tableAdapterManager.ProductCategoriesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductStockTableAdapter = null;
            this.tableAdapterManager.ProductSuppliersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.ServicePointsTableAdapter = null;
            this.tableAdapterManager.ShiftsTableAdapter = null;
            this.tableAdapterManager.StockCountTableAdapter = null;
            this.tableAdapterManager.StockTypesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TaxesTableAdapter = null;
            this.tableAdapterManager.TransactionTypesTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OBS.Pos.PosDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(681, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customersListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbcMain);
            this.splitContainer1.Size = new System.Drawing.Size(681, 433);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 1;
            // 
            // customersListBox
            // 
            this.customersListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "CustomerId", true));
            this.customersListBox.DataSource = this.customersBindingSource;
            this.customersListBox.DisplayMember = "CustomerName";
            this.customersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(0, 0);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(227, 433);
            this.customersListBox.TabIndex = 2;
            this.customersListBox.ValueMember = "CustomerId";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabGeneral);
            this.tbcMain.Controls.Add(this.tabContact);
            this.tbcMain.Controls.Add(this.tabOther);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(450, 433);
            this.tbcMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Controls.Add(customerNameLabel);
            this.tabGeneral.Controls.Add(this.customerNameTextBox);
            this.tabGeneral.Controls.Add(paymentModeIdLabel);
            this.tabGeneral.Controls.Add(this.paymentModeIdComboBox);
            this.tabGeneral.Controls.Add(addressLabel);
            this.tabGeneral.Controls.Add(this.addressTextBox);
            this.tabGeneral.Controls.Add(emailLabel);
            this.tabGeneral.Controls.Add(this.emailTextBox);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(442, 407);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(minBalanceLabel);
            this.groupBox1.Controls.Add(this.openBalanceMaskedTextBox);
            this.groupBox1.Controls.Add(openBalanceLabel);
            this.groupBox1.Controls.Add(this.minCreditMaskedTextBox);
            this.groupBox1.Controls.Add(minCreditLabel);
            this.groupBox1.Controls.Add(this.minBalanceMaskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(47, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 124);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // openBalanceMaskedTextBox
            // 
            this.openBalanceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "OpenBalance", true));
            this.openBalanceMaskedTextBox.Location = new System.Drawing.Point(125, 77);
            this.openBalanceMaskedTextBox.Name = "openBalanceMaskedTextBox";
            this.openBalanceMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.openBalanceMaskedTextBox.TabIndex = 23;
            this.openBalanceMaskedTextBox.Text = "0";
            // 
            // minCreditMaskedTextBox
            // 
            this.minCreditMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "MinCredit", true));
            this.minCreditMaskedTextBox.Location = new System.Drawing.Point(125, 51);
            this.minCreditMaskedTextBox.Name = "minCreditMaskedTextBox";
            this.minCreditMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.minCreditMaskedTextBox.TabIndex = 21;
            this.minCreditMaskedTextBox.Text = "0";
            // 
            // minBalanceMaskedTextBox
            // 
            this.minBalanceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "MinBalance", true));
            this.minBalanceMaskedTextBox.Location = new System.Drawing.Point(125, 25);
            this.minBalanceMaskedTextBox.Name = "minBalanceMaskedTextBox";
            this.minBalanceMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.minBalanceMaskedTextBox.TabIndex = 19;
            this.minBalanceMaskedTextBox.Text = "0";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(151, 39);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.Validated += new System.EventHandler(this.customerNameTextBox_Validated);
            this.customerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameTextBox_Validating);
            // 
            // paymentModeIdComboBox
            // 
            this.paymentModeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "PaymentModeId", true));
            this.paymentModeIdComboBox.DataSource = this.paymentModesBindingSource;
            this.paymentModeIdComboBox.DisplayMember = "Name";
            this.paymentModeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentModeIdComboBox.FormattingEnabled = true;
            this.paymentModeIdComboBox.Location = new System.Drawing.Point(151, 65);
            this.paymentModeIdComboBox.Name = "paymentModeIdComboBox";
            this.paymentModeIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.paymentModeIdComboBox.TabIndex = 3;
            this.paymentModeIdComboBox.ValueMember = "ModeId";
            this.paymentModeIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.paymentModeIdComboBox_Validating);
            this.paymentModeIdComboBox.Validated += new System.EventHandler(this.paymentModeIdComboBox_Validated);
            // 
            // paymentModesBindingSource
            // 
            this.paymentModesBindingSource.DataMember = "PaymentModes";
            this.paymentModesBindingSource.DataSource = this.posData;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(151, 92);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTextBox.Size = new System.Drawing.Size(186, 84);
            this.addressTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(151, 182);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(contactFirstNameLabel);
            this.tabContact.Controls.Add(this.contactFirstNameTextBox);
            this.tabContact.Controls.Add(contactLastNameLabel);
            this.tabContact.Controls.Add(this.contactLastNameTextBox);
            this.tabContact.Controls.Add(contactPhoneLabel);
            this.tabContact.Controls.Add(this.contactPhoneTextBox);
            this.tabContact.Controls.Add(contactEmailLabel);
            this.tabContact.Controls.Add(this.contactEmailTextBox);
            this.tabContact.Controls.Add(contactAddressLabel);
            this.tabContact.Controls.Add(this.contactAddressTextBox);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(442, 407);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // contactFirstNameTextBox
            // 
            this.contactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactFirstName", true));
            this.contactFirstNameTextBox.Location = new System.Drawing.Point(144, 32);
            this.contactFirstNameTextBox.Name = "contactFirstNameTextBox";
            this.contactFirstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactFirstNameTextBox.TabIndex = 19;
            // 
            // contactLastNameTextBox
            // 
            this.contactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactLastName", true));
            this.contactLastNameTextBox.Location = new System.Drawing.Point(144, 58);
            this.contactLastNameTextBox.Name = "contactLastNameTextBox";
            this.contactLastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactLastNameTextBox.TabIndex = 21;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactPhone", true));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(144, 84);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactPhoneTextBox.TabIndex = 23;
            // 
            // contactEmailTextBox
            // 
            this.contactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactEmail", true));
            this.contactEmailTextBox.Location = new System.Drawing.Point(144, 110);
            this.contactEmailTextBox.Name = "contactEmailTextBox";
            this.contactEmailTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactEmailTextBox.TabIndex = 25;
            // 
            // contactAddressTextBox
            // 
            this.contactAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactAddress", true));
            this.contactAddressTextBox.Location = new System.Drawing.Point(144, 136);
            this.contactAddressTextBox.Multiline = true;
            this.contactAddressTextBox.Name = "contactAddressTextBox";
            this.contactAddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contactAddressTextBox.Size = new System.Drawing.Size(189, 91);
            this.contactAddressTextBox.TabIndex = 27;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(createdOnLabel);
            this.tabOther.Controls.Add(this.createdOnLabel1);
            this.tabOther.Controls.Add(createdByLabel);
            this.tabOther.Controls.Add(this.createdByLabel1);
            this.tabOther.Controls.Add(modifiedOnLabel);
            this.tabOther.Controls.Add(this.modifiedOnLabel1);
            this.tabOther.Controls.Add(modifiedByLabel);
            this.tabOther.Controls.Add(this.modifiedByLabel1);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(442, 407);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // createdOnLabel1
            // 
            this.createdOnLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CreatedOn", true));
            this.createdOnLabel1.Location = new System.Drawing.Point(144, 41);
            this.createdOnLabel1.Name = "createdOnLabel1";
            this.createdOnLabel1.Size = new System.Drawing.Size(121, 23);
            this.createdOnLabel1.TabIndex = 33;
            this.createdOnLabel1.Text = "label1";
            // 
            // createdByLabel1
            // 
            this.createdByLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CreatedBy", true));
            this.createdByLabel1.Location = new System.Drawing.Point(144, 64);
            this.createdByLabel1.Name = "createdByLabel1";
            this.createdByLabel1.Size = new System.Drawing.Size(121, 23);
            this.createdByLabel1.TabIndex = 35;
            this.createdByLabel1.Text = "label1";
            // 
            // modifiedOnLabel1
            // 
            this.modifiedOnLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ModifiedOn", true));
            this.modifiedOnLabel1.Location = new System.Drawing.Point(144, 87);
            this.modifiedOnLabel1.Name = "modifiedOnLabel1";
            this.modifiedOnLabel1.Size = new System.Drawing.Size(121, 23);
            this.modifiedOnLabel1.TabIndex = 37;
            this.modifiedOnLabel1.Text = "label1";
            // 
            // modifiedByLabel1
            // 
            this.modifiedByLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ModifiedBy", true));
            this.modifiedByLabel1.Location = new System.Drawing.Point(144, 110);
            this.modifiedByLabel1.Name = "modifiedByLabel1";
            this.modifiedByLabel1.Size = new System.Drawing.Size(121, 23);
            this.modifiedByLabel1.TabIndex = 39;
            this.modifiedByLabel1.Text = "label1";
            // 
            // paymentModesTableAdapter
            // 
            this.paymentModesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 458);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "frmCustomer";
            this.Text = "Customer Manager";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingSource)).EndInit();
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PosData posData;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private OBS.Pos.PosDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private OBS.Pos.PosDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox openBalanceMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox minCreditMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox minBalanceMaskedTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.ComboBox paymentModeIdComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TextBox contactFirstNameTextBox;
        private System.Windows.Forms.TextBox contactLastNameTextBox;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.TextBox contactEmailTextBox;
        private System.Windows.Forms.TextBox contactAddressTextBox;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Label createdOnLabel1;
        private System.Windows.Forms.Label createdByLabel1;
        private System.Windows.Forms.Label modifiedOnLabel1;
        private System.Windows.Forms.Label modifiedByLabel1;
        private System.Windows.Forms.BindingSource paymentModesBindingSource;
        private OBS.Pos.PosDataTableAdapters.PaymentModesTableAdapter paymentModesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
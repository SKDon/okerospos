namespace OBS.Pos.UI.Products
{
    partial class frmProducts
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
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label applyVATLabel;
            System.Windows.Forms.Label applyNHILLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label costPriceLabel;
            System.Windows.Forms.Label usedInSalesLabel;
            System.Windows.Forms.Label usedInProductionLabel;
            System.Windows.Forms.Label minLevelLabel;
            System.Windows.Forms.Label reOrderLevelLabel;
            System.Windows.Forms.Label useIfNotInStockLabel;
            System.Windows.Forms.Label measurementIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.posData = new OBS.Pos.PosData();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new OBS.Pos.PosDataTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new OBS.Pos.PosDataTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.measurementIdComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minLevelTextBox = new System.Windows.Forms.TextBox();
            this.usedInProductionCheckBox = new System.Windows.Forms.CheckBox();
            this.usedInSalesCheckBox = new System.Windows.Forms.CheckBox();
            this.reOrderLevelTextBox = new System.Windows.Forms.TextBox();
            this.useIfNotInStockCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.applyVATCheckBox = new System.Windows.Forms.CheckBox();
            this.applyNHILCheckBox = new System.Windows.Forms.CheckBox();
            this.basicGroup = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productImagePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.unitOfMeasurementTableAdapter = new OBS.Pos.PosDataTableAdapters.UnitOfMeasurementTableAdapter();
            this.eMessages = new System.Windows.Forms.ErrorProvider(this.components);
            this.posDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoriesTableAdapter = new OBS.Pos.PosDataTableAdapters.ProductCategoriesTableAdapter();
            this.categoriesTableAdapter = new OBS.Pos.PosDataTableAdapters.CategoriesTableAdapter();
            this.selectImageDialog = new System.Windows.Forms.OpenFileDialog();
            productCodeLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            applyVATLabel = new System.Windows.Forms.Label();
            applyNHILLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            costPriceLabel = new System.Windows.Forms.Label();
            usedInSalesLabel = new System.Windows.Forms.Label();
            usedInProductionLabel = new System.Windows.Forms.Label();
            minLevelLabel = new System.Windows.Forms.Label();
            reOrderLevelLabel = new System.Windows.Forms.Label();
            useIfNotInStockLabel = new System.Windows.Forms.Label();
            measurementIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.basicGroup.SuspendLayout();
            this.tabCategories.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabImage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.ForeColor = System.Drawing.Color.Blue;
            productCodeLabel.Location = new System.Drawing.Point(6, 30);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 0;
            productCodeLabel.Text = "Product Code:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.ForeColor = System.Drawing.Color.Blue;
            productNameLabel.Location = new System.Drawing.Point(6, 56);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 82);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // applyVATLabel
            // 
            applyVATLabel.AutoSize = true;
            applyVATLabel.Location = new System.Drawing.Point(17, 79);
            applyVATLabel.Name = "applyVATLabel";
            applyVATLabel.Size = new System.Drawing.Size(60, 13);
            applyVATLabel.TabIndex = 10;
            applyVATLabel.Text = "Apply VAT:";
            // 
            // applyNHILLabel
            // 
            applyNHILLabel.AutoSize = true;
            applyNHILLabel.Location = new System.Drawing.Point(17, 109);
            applyNHILLabel.Name = "applyNHILLabel";
            applyNHILLabel.Size = new System.Drawing.Size(64, 13);
            applyNHILLabel.TabIndex = 12;
            applyNHILLabel.Text = "Apply NHIL:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.ForeColor = System.Drawing.Color.Blue;
            unitPriceLabel.Location = new System.Drawing.Point(17, 24);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 14;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // costPriceLabel
            // 
            costPriceLabel.AutoSize = true;
            costPriceLabel.Location = new System.Drawing.Point(17, 50);
            costPriceLabel.Name = "costPriceLabel";
            costPriceLabel.Size = new System.Drawing.Size(58, 13);
            costPriceLabel.TabIndex = 16;
            costPriceLabel.Text = "Cost Price:";
            // 
            // usedInSalesLabel
            // 
            usedInSalesLabel.AutoSize = true;
            usedInSalesLabel.Location = new System.Drawing.Point(322, 27);
            usedInSalesLabel.Name = "usedInSalesLabel";
            usedInSalesLabel.Size = new System.Drawing.Size(76, 13);
            usedInSalesLabel.TabIndex = 18;
            usedInSalesLabel.Text = "Used In Sales:";
            // 
            // usedInProductionLabel
            // 
            usedInProductionLabel.AutoSize = true;
            usedInProductionLabel.Location = new System.Drawing.Point(322, 57);
            usedInProductionLabel.Name = "usedInProductionLabel";
            usedInProductionLabel.Size = new System.Drawing.Size(101, 13);
            usedInProductionLabel.TabIndex = 20;
            usedInProductionLabel.Text = "Used In Production:";
            // 
            // minLevelLabel
            // 
            minLevelLabel.AutoSize = true;
            minLevelLabel.Location = new System.Drawing.Point(6, 63);
            minLevelLabel.Name = "minLevelLabel";
            minLevelLabel.Size = new System.Drawing.Size(80, 13);
            minLevelLabel.TabIndex = 22;
            minLevelLabel.Text = "Minimum Level:";
            // 
            // reOrderLevelLabel
            // 
            reOrderLevelLabel.AutoSize = true;
            reOrderLevelLabel.Location = new System.Drawing.Point(6, 89);
            reOrderLevelLabel.Name = "reOrderLevelLabel";
            reOrderLevelLabel.Size = new System.Drawing.Size(82, 13);
            reOrderLevelLabel.TabIndex = 24;
            reOrderLevelLabel.Text = "Re-Order Level:";
            // 
            // useIfNotInStockLabel
            // 
            useIfNotInStockLabel.AutoSize = true;
            useIfNotInStockLabel.Location = new System.Drawing.Point(322, 87);
            useIfNotInStockLabel.Name = "useIfNotInStockLabel";
            useIfNotInStockLabel.Size = new System.Drawing.Size(96, 13);
            useIfNotInStockLabel.TabIndex = 26;
            useIfNotInStockLabel.Text = "Don\'t check Stock";
            // 
            // measurementIdLabel
            // 
            measurementIdLabel.AutoSize = true;
            measurementIdLabel.Location = new System.Drawing.Point(6, 27);
            measurementIdLabel.Name = "measurementIdLabel";
            measurementIdLabel.Size = new System.Drawing.Size(85, 13);
            measurementIdLabel.TabIndex = 29;
            measurementIdLabel.Text = "Unit of Measure:";
            // 
            // posData
            // 
            this.posData.DataSetName = "PosData";
            this.posData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.posData;
            this.productsBindingSource.CurrentChanged += new System.EventHandler(this.productsBindingSource_CurrentChanged);
            this.productsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.productsBindingSource_AddingNew);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppSettingsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CurrenciesTableAdapter = null;
            this.tableAdapterManager.CustomerOutsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.PaymentModesTableAdapter = null;
            this.tableAdapterManager.PaymentTypesTableAdapter = null;
            this.tableAdapterManager.PayTransTableAdapter = null;
            this.tableAdapterManager.PeriodsTableAdapter = null;
            this.tableAdapterManager.ProductCategoriesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
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
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(904, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "ProductId", true));
            this.productsListBox.DataSource = this.productsBindingSource;
            this.productsListBox.DisplayMember = "ProductCode";
            this.productsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(0, 0);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(301, 459);
            this.productsListBox.TabIndex = 1;
            this.productsListBox.ValueMember = "ProductId";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.productsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbcMain);
            this.splitContainer1.Size = new System.Drawing.Size(904, 461);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 2;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabGeneral);
            this.tbcMain.Controls.Add(this.tabCategories);
            this.tbcMain.Controls.Add(this.tabImage);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(599, 461);
            this.tbcMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.Controls.Add(this.groupBox2);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Controls.Add(this.basicGroup);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(591, 435);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(measurementIdLabel);
            this.groupBox2.Controls.Add(this.measurementIdComboBox);
            this.groupBox2.Controls.Add(usedInSalesLabel);
            this.groupBox2.Controls.Add(minLevelLabel);
            this.groupBox2.Controls.Add(this.minLevelTextBox);
            this.groupBox2.Controls.Add(this.usedInProductionCheckBox);
            this.groupBox2.Controls.Add(reOrderLevelLabel);
            this.groupBox2.Controls.Add(this.usedInSalesCheckBox);
            this.groupBox2.Controls.Add(this.reOrderLevelTextBox);
            this.groupBox2.Controls.Add(usedInProductionLabel);
            this.groupBox2.Controls.Add(useIfNotInStockLabel);
            this.groupBox2.Controls.Add(this.useIfNotInStockCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 175);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // measurementIdComboBox
            // 
            this.measurementIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "MeasurementId", true));
            this.measurementIdComboBox.DataSource = this.unitOfMeasurementBindingSource;
            this.measurementIdComboBox.DisplayMember = "MeasurementName";
            this.measurementIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementIdComboBox.FormattingEnabled = true;
            this.measurementIdComboBox.Location = new System.Drawing.Point(113, 24);
            this.measurementIdComboBox.Name = "measurementIdComboBox";
            this.measurementIdComboBox.Size = new System.Drawing.Size(157, 21);
            this.measurementIdComboBox.TabIndex = 30;
            this.measurementIdComboBox.ValueMember = "MeasurementId";
            // 
            // unitOfMeasurementBindingSource
            // 
            this.unitOfMeasurementBindingSource.DataMember = "UnitOfMeasurement";
            this.unitOfMeasurementBindingSource.DataSource = this.posData;
            // 
            // minLevelTextBox
            // 
            this.minLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "MinLevel", true));
            this.minLevelTextBox.Location = new System.Drawing.Point(113, 60);
            this.minLevelTextBox.Name = "minLevelTextBox";
            this.minLevelTextBox.Size = new System.Drawing.Size(104, 20);
            this.minLevelTextBox.TabIndex = 23;
            // 
            // usedInProductionCheckBox
            // 
            this.usedInProductionCheckBox.Checked = true;
            this.usedInProductionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usedInProductionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "UsedInProduction", true));
            this.usedInProductionCheckBox.Location = new System.Drawing.Point(429, 52);
            this.usedInProductionCheckBox.Name = "usedInProductionCheckBox";
            this.usedInProductionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.usedInProductionCheckBox.TabIndex = 21;
            this.usedInProductionCheckBox.UseVisualStyleBackColor = true;
            // 
            // usedInSalesCheckBox
            // 
            this.usedInSalesCheckBox.Checked = true;
            this.usedInSalesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usedInSalesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "UsedInSales", true));
            this.usedInSalesCheckBox.Location = new System.Drawing.Point(429, 22);
            this.usedInSalesCheckBox.Name = "usedInSalesCheckBox";
            this.usedInSalesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.usedInSalesCheckBox.TabIndex = 19;
            this.usedInSalesCheckBox.UseVisualStyleBackColor = true;
            // 
            // reOrderLevelTextBox
            // 
            this.reOrderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReOrderLevel", true));
            this.reOrderLevelTextBox.Location = new System.Drawing.Point(113, 86);
            this.reOrderLevelTextBox.Name = "reOrderLevelTextBox";
            this.reOrderLevelTextBox.Size = new System.Drawing.Size(104, 20);
            this.reOrderLevelTextBox.TabIndex = 25;
            // 
            // useIfNotInStockCheckBox
            // 
            this.useIfNotInStockCheckBox.Checked = true;
            this.useIfNotInStockCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useIfNotInStockCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "UseIfNotInStock", true));
            this.useIfNotInStockCheckBox.Location = new System.Drawing.Point(429, 82);
            this.useIfNotInStockCheckBox.Name = "useIfNotInStockCheckBox";
            this.useIfNotInStockCheckBox.Size = new System.Drawing.Size(104, 24);
            this.useIfNotInStockCheckBox.TabIndex = 27;
            this.useIfNotInStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(applyVATLabel);
            this.groupBox1.Controls.Add(this.costPriceTextBox);
            this.groupBox1.Controls.Add(costPriceLabel);
            this.groupBox1.Controls.Add(this.unitPriceTextBox);
            this.groupBox1.Controls.Add(this.applyVATCheckBox);
            this.groupBox1.Controls.Add(unitPriceLabel);
            this.groupBox1.Controls.Add(applyNHILLabel);
            this.groupBox1.Controls.Add(this.applyNHILCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(333, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 169);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing";
            // 
            // costPriceTextBox
            // 
            this.costPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CostPrice", true));
            this.costPriceTextBox.Location = new System.Drawing.Point(124, 47);
            this.costPriceTextBox.Name = "costPriceTextBox";
            this.costPriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.costPriceTextBox.TabIndex = 17;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(124, 21);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.unitPriceTextBox.TabIndex = 15;
            // 
            // applyVATCheckBox
            // 
            this.applyVATCheckBox.Checked = true;
            this.applyVATCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyVATCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "ApplyVAT", true));
            this.applyVATCheckBox.Location = new System.Drawing.Point(124, 74);
            this.applyVATCheckBox.Name = "applyVATCheckBox";
            this.applyVATCheckBox.Size = new System.Drawing.Size(104, 24);
            this.applyVATCheckBox.TabIndex = 11;
            this.applyVATCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyNHILCheckBox
            // 
            this.applyNHILCheckBox.Checked = true;
            this.applyNHILCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyNHILCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "ApplyNHIL", true));
            this.applyNHILCheckBox.Location = new System.Drawing.Point(124, 104);
            this.applyNHILCheckBox.Name = "applyNHILCheckBox";
            this.applyNHILCheckBox.Size = new System.Drawing.Size(104, 24);
            this.applyNHILCheckBox.TabIndex = 13;
            this.applyNHILCheckBox.UseVisualStyleBackColor = true;
            // 
            // basicGroup
            // 
            this.basicGroup.Controls.Add(productCodeLabel);
            this.basicGroup.Controls.Add(this.descriptionTextBox);
            this.basicGroup.Controls.Add(this.productCodeTextBox);
            this.basicGroup.Controls.Add(descriptionLabel);
            this.basicGroup.Controls.Add(productNameLabel);
            this.basicGroup.Controls.Add(this.productNameTextBox);
            this.basicGroup.Location = new System.Drawing.Point(28, 28);
            this.basicGroup.Name = "basicGroup";
            this.basicGroup.Size = new System.Drawing.Size(280, 172);
            this.basicGroup.TabIndex = 28;
            this.basicGroup.TabStop = false;
            this.basicGroup.Text = "Basic Information";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(113, 79);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(157, 77);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(113, 27);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.productCodeTextBox.TabIndex = 1;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(113, 53);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.productNameTextBox.TabIndex = 3;
            // 
            // tabCategories
            // 
            this.tabCategories.AutoScroll = true;
            this.tabCategories.Controls.Add(this.panel4);
            this.tabCategories.Controls.Add(this.bindingNavigator1);
            this.tabCategories.Location = new System.Drawing.Point(4, 22);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(591, 435);
            this.tabCategories.TabIndex = 2;
            this.tabCategories.Text = "Categories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.productCategoriesDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 404);
            this.panel4.TabIndex = 2;
            // 
            // productCategoriesDataGridView
            // 
            this.productCategoriesDataGridView.AutoGenerateColumns = false;
            this.productCategoriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ProductId});
            this.productCategoriesDataGridView.DataSource = this.productCategoriesBindingSource;
            this.productCategoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productCategoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productCategoriesDataGridView.Name = "productCategoriesDataGridView";
            this.productCategoriesDataGridView.Size = new System.Drawing.Size(585, 404);
            this.productCategoriesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryId";
            this.dataGridViewTextBoxColumn2.DataSource = this.categoriesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "CategoryId";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.posData;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // productCategoriesBindingSource
            // 
            this.productCategoriesBindingSource.DataMember = "FK_ProductCategories_Products";
            this.productCategoriesBindingSource.DataSource = this.productsBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.productCategoriesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(585, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.panel3);
            this.tabImage.Location = new System.Drawing.Point(4, 22);
            this.tabImage.Name = "tabImage";
            this.tabImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabImage.Size = new System.Drawing.Size(591, 435);
            this.tabImage.TabIndex = 1;
            this.tabImage.Text = "Photo";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 429);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productImagePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 350);
            this.panel1.TabIndex = 12;
            // 
            // productImagePictureBox
            // 
            this.productImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productsBindingSource, "ProductImage", true));
            this.productImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.productImagePictureBox.Name = "productImagePictureBox";
            this.productImagePictureBox.Size = new System.Drawing.Size(585, 350);
            this.productImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.productImagePictureBox.TabIndex = 11;
            this.productImagePictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearImage);
            this.panel2.Controls.Add(this.btnSetImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 79);
            this.panel2.TabIndex = 13;
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(198, 7);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(75, 23);
            this.btnClearImage.TabIndex = 1;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(79, 7);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(113, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "Choose Image";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // unitOfMeasurementTableAdapter
            // 
            this.unitOfMeasurementTableAdapter.ClearBeforeFill = true;
            // 
            // eMessages
            // 
            this.eMessages.ContainerControl = this;
            this.eMessages.DataMember = "Products";
            this.eMessages.DataSource = this.posDataBindingSource;
            // 
            // posDataBindingSource
            // 
            this.posDataBindingSource.DataSource = this.posData;
            this.posDataBindingSource.Position = 0;
            // 
            // productCategoriesTableAdapter
            // 
            this.productCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // selectImageDialog
            // 
            this.selectImageDialog.Filter = "All Images|*.png;*.gif;*.jpg;*.jpeg;*.bmp;*.wmf";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 486);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "frmProducts";
            this.Text = "Product Register";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.basicGroup.ResumeLayout(false);
            this.basicGroup.PerformLayout();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabImage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PosData posData;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OBS.Pos.PosDataTableAdapters.ProductsTableAdapter productsTableAdapter;
        private OBS.Pos.PosDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox basicGroup;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox applyVATCheckBox;
        private System.Windows.Forms.CheckBox applyNHILCheckBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox costPriceTextBox;
        private System.Windows.Forms.CheckBox usedInSalesCheckBox;
        private System.Windows.Forms.CheckBox usedInProductionCheckBox;
        private System.Windows.Forms.TextBox minLevelTextBox;
        private System.Windows.Forms.TextBox reOrderLevelTextBox;
        private System.Windows.Forms.CheckBox useIfNotInStockCheckBox;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox measurementIdComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox productImagePictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.BindingSource unitOfMeasurementBindingSource;
        private OBS.Pos.PosDataTableAdapters.UnitOfMeasurementTableAdapter unitOfMeasurementTableAdapter;
        private System.Windows.Forms.ErrorProvider eMessages;
        private System.Windows.Forms.BindingSource posDataBindingSource;
        private System.Windows.Forms.BindingSource productCategoriesBindingSource;
        private OBS.Pos.PosDataTableAdapters.ProductCategoriesTableAdapter productCategoriesTableAdapter;
        private System.Windows.Forms.DataGridView productCategoriesDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private OBS.Pos.PosDataTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.OpenFileDialog selectImageDialog;
    }
}
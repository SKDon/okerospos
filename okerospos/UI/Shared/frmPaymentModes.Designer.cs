namespace OBS.Pos.UI.Shared
{
    partial class frmPaymentModes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentModes));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label paymentTypeLabel;
            this.posData = new OBS.Pos.PosData();
            this.paymentModesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentModesTableAdapter = new OBS.Pos.PosDataTableAdapters.PaymentModesTableAdapter();
            this.tableAdapterManager = new OBS.Pos.PosDataTableAdapters.TableAdapterManager();
            this.paymentModesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paymentModesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.paymentModesListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.paymentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypesTableAdapter = new OBS.Pos.PosDataTableAdapters.PaymentTypesTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            paymentTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingNavigator)).BeginInit();
            this.paymentModesBindingNavigator.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // posData
            // 
            this.posData.DataSetName = "PosData";
            this.posData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentModesBindingSource
            // 
            this.paymentModesBindingSource.DataMember = "PaymentModes";
            this.paymentModesBindingSource.DataSource = this.posData;
            // 
            // paymentModesTableAdapter
            // 
            this.paymentModesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PaymentModesTableAdapter = this.paymentModesTableAdapter;
            this.tableAdapterManager.PaymentTypesTableAdapter = this.paymentTypesTableAdapter;
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
            // paymentModesBindingNavigator
            // 
            this.paymentModesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentModesBindingNavigator.BindingSource = this.paymentModesBindingSource;
            this.paymentModesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentModesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentModesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentModesBindingNavigatorSaveItem});
            this.paymentModesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentModesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentModesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentModesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentModesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentModesBindingNavigator.Name = "paymentModesBindingNavigator";
            this.paymentModesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentModesBindingNavigator.Size = new System.Drawing.Size(533, 25);
            this.paymentModesBindingNavigator.TabIndex = 0;
            this.paymentModesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // paymentModesBindingNavigatorSaveItem
            // 
            this.paymentModesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentModesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentModesBindingNavigatorSaveItem.Image")));
            this.paymentModesBindingNavigatorSaveItem.Name = "paymentModesBindingNavigatorSaveItem";
            this.paymentModesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentModesBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentModesBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentModesBindingNavigatorSaveItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.paymentModesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbcMain);
            this.splitContainer1.Size = new System.Drawing.Size(533, 387);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabGeneral);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(352, 387);
            this.tbcMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(nameLabel);
            this.tabGeneral.Controls.Add(this.nameTextBox);
            this.tabGeneral.Controls.Add(descriptionLabel);
            this.tabGeneral.Controls.Add(this.descriptionTextBox);
            this.tabGeneral.Controls.Add(paymentTypeLabel);
            this.tabGeneral.Controls.Add(this.paymentTypeComboBox);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(344, 361);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // paymentModesListBox
            // 
            this.paymentModesListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentModesBindingSource, "ModeId", true));
            this.paymentModesListBox.DataSource = this.paymentModesBindingSource;
            this.paymentModesListBox.DisplayMember = "Name";
            this.paymentModesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentModesListBox.FormattingEnabled = true;
            this.paymentModesListBox.Location = new System.Drawing.Point(0, 0);
            this.paymentModesListBox.Name = "paymentModesListBox";
            this.paymentModesListBox.Size = new System.Drawing.Size(177, 381);
            this.paymentModesListBox.TabIndex = 2;
            this.paymentModesListBox.ValueMember = "ModeId";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(33, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentModesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(33, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentModesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(117, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(191, 87);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // paymentTypeLabel
            // 
            paymentTypeLabel.AutoSize = true;
            paymentTypeLabel.Location = new System.Drawing.Point(33, 154);
            paymentTypeLabel.Name = "paymentTypeLabel";
            paymentTypeLabel.Size = new System.Drawing.Size(78, 13);
            paymentTypeLabel.TabIndex = 4;
            paymentTypeLabel.Text = "Payment Type:";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentModesBindingSource, "PaymentType", true));
            this.paymentTypeComboBox.DataSource = this.paymentTypesBindingSource;
            this.paymentTypeComboBox.DisplayMember = "Name";
            this.paymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Location = new System.Drawing.Point(117, 151);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.paymentTypeComboBox.TabIndex = 5;
            this.paymentTypeComboBox.ValueMember = "PaymentTypeId";
            // 
            // paymentTypesBindingSource
            // 
            this.paymentTypesBindingSource.DataMember = "PaymentTypes";
            this.paymentTypesBindingSource.DataSource = this.posData;
            // 
            // paymentTypesTableAdapter
            // 
            this.paymentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmPaymentModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 412);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.paymentModesBindingNavigator);
            this.Name = "frmPaymentModes";
            this.Text = "Payment Mode Manager";
            this.Load += new System.EventHandler(this.frmPaymentModes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentModesBindingNavigator)).EndInit();
            this.paymentModesBindingNavigator.ResumeLayout(false);
            this.paymentModesBindingNavigator.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PosData posData;
        private System.Windows.Forms.BindingSource paymentModesBindingSource;
        private OBS.Pos.PosDataTableAdapters.PaymentModesTableAdapter paymentModesTableAdapter;
        private OBS.Pos.PosDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentModesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentModesBindingNavigatorSaveItem;
        private OBS.Pos.PosDataTableAdapters.PaymentTypesTableAdapter paymentTypesTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox paymentModesListBox;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.BindingSource paymentTypesBindingSource;
    }
}
namespace OBS.Pos.UI.Stock
{
    partial class frmStockCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockCount));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlStockCount = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.posData = new OBS.Pos.PosData();
            this.stockCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockCountTableAdapter = new OBS.Pos.PosDataTableAdapters.StockCountTableAdapter();
            this.periodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodsTableAdapter = new OBS.Pos.PosDataTableAdapters.PeriodsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new OBS.Pos.PosDataTableAdapters.ProductsTableAdapter();
            this.periodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.systemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countedStockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemStockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.pnlStockCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlStockCount
            // 
            this.pnlStockCount.Controls.Add(this.dataGridView1);
            this.pnlStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockCount.Location = new System.Drawing.Point(0, 25);
            this.pnlStockCount.Name = "pnlStockCount";
            this.pnlStockCount.Size = new System.Drawing.Size(705, 449);
            this.pnlStockCount.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.systemQuantityDataGridViewTextBoxColumn,
            this.countedQuantityDataGridViewTextBoxColumn,
            this.countedStockDateDataGridViewTextBoxColumn,
            this.systemStockDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockCountBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // posData
            // 
            this.posData.DataSetName = "PosData";
            this.posData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockCountBindingSource
            // 
            this.stockCountBindingSource.DataMember = "StockCount";
            this.stockCountBindingSource.DataSource = this.posData;
            // 
            // stockCountTableAdapter
            // 
            this.stockCountTableAdapter.ClearBeforeFill = true;
            // 
            // periodsBindingSource
            // 
            this.periodsBindingSource.DataMember = "Periods";
            this.periodsBindingSource.DataSource = this.posData;
            // 
            // periodsTableAdapter
            // 
            this.periodsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.posData;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // periodIdDataGridViewTextBoxColumn
            // 
            this.periodIdDataGridViewTextBoxColumn.DataPropertyName = "PeriodId";
            this.periodIdDataGridViewTextBoxColumn.DataSource = this.periodsBindingSource;
            this.periodIdDataGridViewTextBoxColumn.DisplayMember = "PeriodName";
            this.periodIdDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodIdDataGridViewTextBoxColumn.Name = "periodIdDataGridViewTextBoxColumn";
            this.periodIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.periodIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.periodIdDataGridViewTextBoxColumn.ValueMember = "PeriodId";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.DataSource = this.productsBindingSource;
            this.productIdDataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIdDataGridViewTextBoxColumn.ValueMember = "ProductId";
            // 
            // systemQuantityDataGridViewTextBoxColumn
            // 
            this.systemQuantityDataGridViewTextBoxColumn.DataPropertyName = "SystemQuantity";
            this.systemQuantityDataGridViewTextBoxColumn.HeaderText = "System Counted";
            this.systemQuantityDataGridViewTextBoxColumn.Name = "systemQuantityDataGridViewTextBoxColumn";
            // 
            // countedQuantityDataGridViewTextBoxColumn
            // 
            this.countedQuantityDataGridViewTextBoxColumn.DataPropertyName = "CountedQuantity";
            this.countedQuantityDataGridViewTextBoxColumn.HeaderText = "Actual Counted";
            this.countedQuantityDataGridViewTextBoxColumn.Name = "countedQuantityDataGridViewTextBoxColumn";
            // 
            // countedStockDateDataGridViewTextBoxColumn
            // 
            this.countedStockDateDataGridViewTextBoxColumn.DataPropertyName = "CountedStockDate";
            this.countedStockDateDataGridViewTextBoxColumn.HeaderText = "Counted On";
            this.countedStockDateDataGridViewTextBoxColumn.Name = "countedStockDateDataGridViewTextBoxColumn";
            // 
            // systemStockDateDataGridViewTextBoxColumn
            // 
            this.systemStockDateDataGridViewTextBoxColumn.DataPropertyName = "SystemStockDate";
            this.systemStockDateDataGridViewTextBoxColumn.HeaderText = "System Date";
            this.systemStockDateDataGridViewTextBoxColumn.Name = "systemStockDateDataGridViewTextBoxColumn";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::OBS.Pos.Properties.Resources.fileprint;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Print Stock Report";
            // 
            // frmStockCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 474);
            this.Controls.Add(this.pnlStockCount);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStockCount";
            this.Text = "Physical Stock Count";
            this.Load += new System.EventHandler(this.frmStockCount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlStockCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Panel pnlStockCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PosData posData;
        private System.Windows.Forms.BindingSource stockCountBindingSource;
        private OBS.Pos.PosDataTableAdapters.StockCountTableAdapter stockCountTableAdapter;
        private System.Windows.Forms.BindingSource periodsBindingSource;
        private OBS.Pos.PosDataTableAdapters.PeriodsTableAdapter periodsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OBS.Pos.PosDataTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn periodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countedStockDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemStockDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
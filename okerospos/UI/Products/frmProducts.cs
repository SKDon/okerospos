using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared;
using OBS.Pos.BLL;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Products
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.posData);
                this.ResetChangeState();
                this.productCodeTextBox.ReadOnly = true; 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

            this.categoriesTableAdapter.FillCategories(this.posData.Categories);
            this.productCategoriesTableAdapter.Fill(this.posData.ProductCategories);

            foreach (Binding b in productsBindingSource.CurrencyManager.Bindings)
            {
                if (b.BindingMemberInfo.BindingField == posData.Products.UnitPriceColumn.ColumnName
                    || b.BindingMemberInfo.BindingField == posData.Products.CostPriceColumn.ColumnName
                    )
                {
                    Formatter.ApplyCurrencyFormat(b);
                }
                if (b.BindingMemberInfo.BindingField == posData.Products.MinLevelColumn.ColumnName
                    || b.BindingMemberInfo.BindingField == posData.Products.ReOrderLevelColumn.ColumnName)
                {
                    Formatter.ApplyFloatFormat(b);
                }
            }

            this.unitOfMeasurementTableAdapter.Fill(this.posData.UnitOfMeasurement);
            this.productsTableAdapter.Fill(this.posData.Products);
            this.LoadContext(productsBindingSource, productsBindingNavigatorSaveItem_Click);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            productImagePictureBox.Image = null;
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {
                productImagePictureBox.Image = Bitmap.FromFile(selectImageDialog.FileName);
            }

        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var row = productsBindingSource.Current as DataRowView;
            if (row.IsNew) ProductBLL.SetProductDefault(row);
        }

        private void productsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.productCodeTextBox.ReadOnly = false; 
        }

    }
}

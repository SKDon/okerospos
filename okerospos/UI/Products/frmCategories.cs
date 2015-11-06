using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;


namespace OBS.Pos.UI.Products
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.FillCategories(this.posData.Categories);
            this.LoadContext(categoriesBindingSource, categoriesBindingNavigatorSaveItem_Click);
            LoadCombos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadCombos()
        {
            //this.parentIdComboBox.Items  
            this.parentIdComboBox.Items.Insert(0,  "[--Not Selected--]");   
        }
        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentItem = this.categoriesBindingSource.Current as DataRowView;
            if (currentItem != null)
                this.categoriesTableAdapter.FillCategoriesExempt(this.posData.Categories, Convert.ToInt32(currentItem["CategoryId"]));
        }
    }
}

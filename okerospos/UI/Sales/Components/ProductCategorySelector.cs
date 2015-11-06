using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos;
using OBS.Pos.PosDataTableAdapters;
using System.IO;

namespace OBS.Pos.UI.Sales.Components
{
    public partial class ProductCategorySelector : Panel
    {
        public ProductCategorySelector()
        {
            InitializeComponent();
        }

        #region Render Categories
        private PosData.CategoriesDataTable _categoryList;
        private PosData.ProductsDataTable _productList;
        private void RenderCategory(long? categoryId)
        {

        }

        #region Categories
        private void RenderCategories()
        {
            using (CategoriesTableAdapter adapter = new CategoriesTableAdapter())
            {
                _categoryList = adapter.GetCategories();
                if (_categoryList != null && _categoryList.Rows.Count > 0)
                {
                    foreach (PosData.CategoriesRow category in _categoryList)
                    {
                        var newCategoryButton = new Button()
                        {
                            Name=category.CategoryName.Replace(" ","") , Text = category.CategoryName};
                        if (category.CategoryImage != null)
                        {

                        }
                    }
                }
            }
        }
        private void RenderSubCategories(long? categoryId)
        {

        }
        #endregion
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.BLL;

namespace OBS.Pos.UI.Products.Components
{
    public partial class CategorySelector : UserControl
    {
        public CategorySelector()
        {
            InitializeComponent();
            categoryList.AfterSelect += SelectNodeItem;
            this.Load += Control_Load;
        }

        #region Event Handlers
        protected void Control_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void SelectNodeItem(object sender, TreeViewEventArgs e)
        {
            try
            {
                SelectedCategoryID = Convert.ToInt64(e.Node.Tag);
            }
            catch { } 
        }
        #endregion

        #region Properties
        public long SelectedCategoryID { get; set; }

        #endregion

        public void LoadCategories()
        {
            CategoryBLL.LoadCategoriesView(categoryList, CategoryBLL.GetAllCategories());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace OBS.Pos.BLL
{
    public class CategoryBLL
    {
        public static DataRowView SetCategoryDefault(DataRowView category)
        {
            var row = category;
            row["CategoryName"] = "";
            row["ParentID"] = 0L;
            row["CreatedOn"] = DateTime.Now.ToUniversalTime();
            if (System.Threading.Thread.CurrentPrincipal != null)
            { row["CreatedBy"] = System.Threading.Thread.CurrentPrincipal.Identity.Name; }

            return row;
        }
        public static PosData.CategoriesDataTable GetAllCategories()
        {
            using (PosDataTableAdapters.CategoriesTableAdapter adapter = new OBS.Pos.PosDataTableAdapters.CategoriesTableAdapter())
            {
                return adapter.GetCategories();
            }
        }

        #region Category Loading
        public static void LoadCategoriesView(TreeView target, PosData.CategoriesDataTable source)
        {
            var roots = from p in source
                        select p;
            target.BeginUpdate();
            TreeNode currentNode = null;
            foreach (PosData.CategoriesRow row in roots)
            {
                if (row.ParentId == 0)//root nodes only
                {
                    currentNode = new TreeNode(row.CategoryName, 0, 0);
                    currentNode.Tag = row.CategoryId;
                    target.Nodes.Add(currentNode);
                }

                var current = from c in source
                              where c.ParentId == row.CategoryId && c.ParentId != 0L
                              select c;
                if (current != null && current.Count<PosData.CategoriesRow>() > 0)
                {
                    _LoadCategoriesView(currentNode, current, source);
                }

            }
            target.EndUpdate();
        }
        private static void _LoadCategoriesView(TreeNode targetNode, EnumerableRowCollection<PosData.CategoriesRow> current, PosData.CategoriesDataTable source)
        {
            foreach (PosData.CategoriesRow row in current)
            {
                var newNode = from c in source
                              where c.ParentId == row.CategoryId && c.ParentId != 0L
                              select c;
                if (newNode != null && newNode.Count<PosData.CategoriesRow>() > 0)
                {
                    _LoadCategoriesView(targetNode, newNode, source);
                }
                //root nodes
                TreeNode currentNode = new TreeNode(row.CategoryName, 0, 0);
                currentNode.Tag = row.CategoryId;
                 targetNode.Nodes.Add(currentNode);
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Suppliers
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.posData.Suppliers);
            this.LoadContext(suppliersBindingSource , suppliersBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

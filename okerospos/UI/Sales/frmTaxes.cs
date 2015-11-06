using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Sales
{
    public partial class frmTaxes : Form
    {
        public frmTaxes()
        {
            InitializeComponent();
        }

        private void taxesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taxesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmTaxes_Load(object sender, EventArgs e)
        {
            this.taxesTableAdapter.Fill(this.posData.Taxes);
            this.LoadContext(taxesBindingSource , taxesBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

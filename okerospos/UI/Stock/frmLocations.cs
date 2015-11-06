using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Stock
{
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            InitializeComponent();
        }

        private void locationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            this.locationsTableAdapter.Fill(this.posData.Locations);
            this.LoadContext(locationsBindingSource, locationsBindingNavigatorSaveItem_Click);
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

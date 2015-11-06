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
    public partial class frmUOM : Form
    {
        public frmUOM()
        {
            InitializeComponent();
        }

        private void unitOfMeasurementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitOfMeasurementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();

        }

        private void frmUOM_Load(object sender, EventArgs e)
        {
            this.unitOfMeasurementTableAdapter.Fill(this.posData.UnitOfMeasurement);
            this.LoadContext(unitOfMeasurementBindingSource, unitOfMeasurementBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

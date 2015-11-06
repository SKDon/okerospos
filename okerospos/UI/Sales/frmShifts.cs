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
    public partial class frmShifts : Form
    {
        public frmShifts()
        {
            InitializeComponent();
        }

        private void shiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmShifts_Load(object sender, EventArgs e)
        {
            this.shiftsTableAdapter.Fill(this.posData.Shifts);
            this.LoadContext(shiftsBindingSource , shiftsBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Shared
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void currenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            this.currenciesTableAdapter.Fill(this.posData.Currencies);
            this.LoadContext(currenciesBindingSource , currenciesBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

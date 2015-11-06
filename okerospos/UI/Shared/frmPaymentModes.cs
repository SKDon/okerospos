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
    public partial class frmPaymentModes : Form
    {
        public frmPaymentModes()
        {
            InitializeComponent();
        }

        private void paymentModesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentModesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmPaymentModes_Load(object sender, EventArgs e)
        {
            this.paymentTypesTableAdapter.Fill(this.posData.PaymentTypes);
            this.paymentModesTableAdapter.Fill(this.posData.PaymentModes);
            this.LoadContext(paymentModesBindingSource , paymentModesBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

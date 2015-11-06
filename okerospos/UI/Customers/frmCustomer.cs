using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.BLL;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Customers
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.paymentModesTableAdapter.Fill(this.posData.PaymentModes);
            this.customersTableAdapter.Fill(this.posData.Customers);
            this.LoadContext(customersBindingSource , customersBindingNavigatorSaveItem_Click );
            this.WindowState = FormWindowState.Maximized;

        }

        private void customerNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(customerNameTextBox, string.Empty);
        }

        private void customerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(customerNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(customerNameTextBox, "Please supply customer name.");
            }
        }

        private void paymentModeIdComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (paymentModeIdComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(paymentModeIdComboBox, "Please select a mode of payment.");
            }
        }

        private void paymentModeIdComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(paymentModeIdComboBox, string.Empty);

        }
        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var row = customersBindingSource.Current as DataRowView;
            if (row.IsNew) CustomerBLL.SetCustomerDefault(row);
        }

    }
}

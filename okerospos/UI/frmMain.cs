using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBSPos.UI.Reports;
using OBS.Pos.UI;
using OBS.Pos.UI.Shared;
using OBS.Pos.UI.Shared.Extensions;

namespace OBSPos.UI
{
    public partial class frmMain : Form
    {
        #region private members
        private bool m_boolCanExit = false;

        #endregion
        public frmMain()
        {
            InitializeComponent();
        }


        private void manageProductsMenu_Click(object sender, EventArgs e)
        {
            MenuManager.ProductRegister.MdiParent = this;
            MenuManager.ProductRegister.Show();
            MenuManager.ProductRegister.BringToFront();
        }

        private void administrationUsersMenu_Click(object sender, EventArgs e)
        {
            MenuManager.UserRegister.MdiParent = this;
            MenuManager.UserRegister.Show();
            MenuManager.UserRegister.BringToFront();
        }

        private void administrationProductCategoriesMenu_Click(object sender, EventArgs e)
        {
            MenuManager.CategoryRegister.MdiParent = this;
            MenuManager.CategoryRegister.Show();
            MenuManager.CategoryRegister.BringToFront();
        }

        private void reportsMenu_Click(object sender, EventArgs e)
        {
            MenuManager.ReportViewer.MdiParent = this;
            MenuManager.ReportViewer.Show();
            MenuManager.ReportViewer.BringToFront();
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.TaxRegister.MdiParent = this;
            MenuManager.TaxRegister.Show();
            MenuManager.TaxRegister.BringToFront();
        }

        private void paymentModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.PaymentModeRegister.MdiParent = this;
            MenuManager.PaymentModeRegister.Show();
            MenuManager.PaymentModeRegister.BringToFront();
        }

        private void adminCurrencyMenu_Click(object sender, EventArgs e)
        {
            MenuManager.CurrencyRegister.MdiParent = this;
            MenuManager.CurrencyRegister.Show();
            MenuManager.CurrencyRegister.BringToFront();
        }

        private void adminProductsUomMenu_Click(object sender, EventArgs e)
        {
            MenuManager.UOMRegister.MdiParent = this;
            MenuManager.UOMRegister.Show();
            MenuManager.UOMRegister.BringToFront();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.LocationRegister.MdiParent = this;
            MenuManager.LocationRegister.Show();
            MenuManager.LocationRegister.BringToFront();
        }

        private void adminSupplierManageMenu_Click(object sender, EventArgs e)
        {
            MenuManager.SupplierRegister.MdiParent = this;
            MenuManager.SupplierRegister.Show();
            MenuManager.SupplierRegister.BringToFront();
        }

        private void adminCustomerManageMenu_Click(object sender, EventArgs e)
        {
            MenuManager.CustomerRegister.MdiParent = this;
            MenuManager.CustomerRegister.Show();
            MenuManager.CustomerRegister.BringToFront();
        }

        private void salesRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.SalesRegister.MdiParent = this;
            MenuManager.SalesRegister.Show();
            MenuManager.SalesRegister.BringToFront();
        }

        private void adminStockTransferMenu_Click(object sender, EventArgs e)
        {
            MenuManager.StockTranfer.MdiParent = this;
            MenuManager.StockTranfer.Show();
            MenuManager.StockTranfer.BringToFront();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.StockCountRun.MdiParent = this;
            MenuManager.StockCountRun.Show();
            MenuManager.StockCountRun.BringToFront();
        }

        private void freezeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.StockFreeze.MdiParent = this;
            MenuManager.StockFreeze.Show();
            MenuManager.StockFreeze.BringToFront();
        }

        private void adminStockRecieveMenu_Click(object sender, EventArgs e)
        {
            MenuManager.StockRecieve.MdiParent = this;
            MenuManager.StockRecieve.Show();
            MenuManager.StockRecieve.BringToFront();
        }

        private void adminStockRemoveMenu_Click(object sender, EventArgs e)
        {
            MenuManager.StockRemove.MdiParent = this;
            MenuManager.StockRemove.Show();
            MenuManager.StockRemove.BringToFront();
        }

        private void adminStockReturnMenu_Click(object sender, EventArgs e)
        {
            MenuManager.StockReturn.MdiParent = this;
            MenuManager.StockReturn.Show();
            MenuManager.StockReturn.BringToFront();
        }

        private void adminShiftMenu_Click(object sender, EventArgs e)
        {
            MenuManager.ShiftRegister.MdiParent = this;
            MenuManager.ShiftRegister.Show();
            MenuManager.ShiftRegister.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_boolCanExit = true;
            this.Close();
        }

        private void winCloseAllMenu_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.AuthorizeAll(menuStrip1.Items);
        }

        private void btnSalesRegister_Click(object sender, EventArgs e)
        {
            salesRegisterToolStripMenuItem_Click(sender, e);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            paymentsToolStripMenuItem_Click(sender, e);

        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManager.PaymentsRegister.MdiParent = this;
            MenuManager.PaymentsRegister.Show();
            MenuManager.PaymentsRegister.BringToFront();
        }

        private void closeShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseShift_Click(object sender, EventArgs e)
        {
            closeShiftToolStripMenuItem_Click(sender, e);
        }
    }
}

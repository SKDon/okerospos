using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OBS.Pos.UI.Stock
{
    public partial class frmStockCount : Form
    {
        public frmStockCount()
        {
            InitializeComponent();
        }

        private void frmStockCount_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.posData.Products);
            this.periodsTableAdapter.Fill(this.posData.Periods);
            this.stockCountTableAdapter.Fill(this.posData.StockCount);
            this.WindowState = FormWindowState.Maximized;

        }
    }
}

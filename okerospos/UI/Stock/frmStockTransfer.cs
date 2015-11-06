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
    public partial class frmStockTransfer : Form
    {
        public frmStockTransfer()
        {
            InitializeComponent();
        }

        private void frmStockTransfer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

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
    public partial class frmStockReturn : Form
    {
        public frmStockReturn()
        {
            InitializeComponent();
        }

        private void frmStockReturn_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

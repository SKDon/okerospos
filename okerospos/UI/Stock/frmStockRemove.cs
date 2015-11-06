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
    public partial class frmStockRemove : Form
    {
        public frmStockRemove()
        {
            InitializeComponent();
        }

        private void frmStockRemove_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

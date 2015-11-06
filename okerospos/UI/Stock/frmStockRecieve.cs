using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.BLL;

namespace OBS.Pos.UI.Stock
{
    public partial class frmStockRecieve : Form
    {
        public frmStockRecieve()
        {
            InitializeComponent();
        }

        private void frmStockRecieve_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

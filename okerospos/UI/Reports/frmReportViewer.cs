using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OBSPos.UI.Reports
{
    public partial class frmReportViewer : Form
    {
        #region properties
        public string ReportFile { get; set; }
        #endregion

        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadReport();
        }

        private void LoadReport()
        {
            if (!string.IsNullOrEmpty(this.ReportFile))
            {
                //this.reportViewer1.ServerReport.ReportPath = this.ReportFile;
                //this.reportViewer1.RefreshReport();
            }
        }
    }
}

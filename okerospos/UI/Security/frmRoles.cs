using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OBS.Pos.UI.Security
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posData.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.posData.Roles);

        }
    }
}

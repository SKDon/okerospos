using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;


namespace OBS.Pos.UI.Security
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.posData.Roles);
            this.shiftsTableAdapter.Fill(this.posData.Shifts);
            this.usersTableAdapter.Fill(this.posData.Users);

            this.LoadContext(usersBindingSource, usersBindingNavigatorSaveItem_Click);
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.posData);
            this.ResetChangeState();

        }
    }
}

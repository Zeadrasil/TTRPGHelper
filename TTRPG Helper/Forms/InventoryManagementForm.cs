//Auth: Logan Wright
//Desc: gives the user the ability to manage there inventory

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTRPG_Helper.Forms
{
    public partial class InventoryManagementForm : Form
    {
        public InventoryManagementForm()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDataSet);

        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsDataSet.Items);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDataSet);
        }
    }
}

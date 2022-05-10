//Auth: Logan Wright
//Desc: gives the user the ability to manage spells


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
    public partial class spellManagementForm : Form
    {
        public spellManagementForm()
        {
            InitializeComponent();
        }

        private void preparedSpellsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preparedSpellsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.spellsDataSet);

        }

        private void spellManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spellsDataSet.PreparedSpells' table. You can move, or remove it, as needed.
            this.preparedSpellsTableAdapter.Fill(this.spellsDataSet.PreparedSpells);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preparedSpellsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.spellsDataSet);
        }
    }
}

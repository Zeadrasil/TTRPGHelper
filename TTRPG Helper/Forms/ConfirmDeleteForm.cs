using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTRPG_Helper.Classes;

namespace TTRPG_Helper.Forms
{
    public partial class ConfirmDeleteForm : Form
    {
        Being toDelete;

        public ConfirmDeleteForm(Being being)
        {
            InitializeComponent();
            toDelete = being;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                toDelete.tryDelete();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

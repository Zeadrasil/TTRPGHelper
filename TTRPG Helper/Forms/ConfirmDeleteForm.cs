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
        Being beingDelete;
        int deletetype;
        Bonus bonusDelete;

        public ConfirmDeleteForm(Being being)
        {
            InitializeComponent();
            beingDelete = being;
            deletetype = 0;
        }

        public ConfirmDeleteForm(Bonus bonus)
        {
            InitializeComponent();
            bonusDelete = bonus;
            deletetype = 1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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
                switch(deletetype)
                {
                    case 0:
                        {
                            beingDelete.tryDelete();
                            break;
                        }
                    case 1:
                        {
                            bonusDelete.tryDelete();
                            break;
                        }
                    default:
                        {
                            beingDelete.tryDelete();
                            break;
                        }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

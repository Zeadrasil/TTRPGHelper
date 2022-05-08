/*Author: David Griffith
 Date: 5/8/2022
Description: form confirming that the user wants to delete something, which deletes the item if they do and does nothing if they do not*/
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
        //storage for the item to be deleted and which type of item is being deleted
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
                //deletes the item that needs to be deleted
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

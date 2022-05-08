/*Author: David Griffith
 Date: 5/7/2022
Description: allows users to manage the bonuses of the selected character by creating editing, and removing bonuses*/
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
using TTRPG_Helper.Database_Files;
using TTRPG_Helper.Forms;

namespace TTRPG_Helper.Forms
{
    public partial class BonusManagementForm : Form
    {
        //various information storage fields
        int id;
        List<Bonus> bonusList;

        //database access
        CharacterLINQDataContext bonusbase;

        public BonusManagementForm(int characterId, string characterName)
        {
            InitializeComponent();
            bonusbase = new CharacterLINQDataContext();
            id = characterId;
            bonusLabel.Text = characterName + "'s Bonuses";
        }

        private void BonusManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                //fills displays and storages upon load
                reloadBonuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reloadBonuses()
        {
            try
            {
                //resets then fills displays and storage structures with information about the selected character's bonuses
                bonusListBox.Items.Clear();
                bonusList = new List<Bonus>();
                bonusbase = new CharacterLINQDataContext();
                foreach (Bonuses bonus in bonusbase.Bonuses)
                {
                    if(bonus.CharacterId == id)
                    {
                        bonusList.Add(new Bonus(bonus.Id, id, bonus.Effect));
                        bonusListBox.Items.Add(bonus.Effect);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //begins removal of selected bonus
                ConfirmDeleteForm cdf = new ConfirmDeleteForm(bonusList[bonusListBox.SelectedIndex]);
                cdf.ShowDialog();
                if (bonusList[bonusListBox.SelectedIndex].getId() == -1)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                //saves the effect in the effect text box as a new bonus
                Bonus bonus = new Bonus(-1, id, effectTextBox.Text);
                bonus.trySaveAsNew();
                reloadBonuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bonusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                effectTextBox.Text = bonusListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //alters the effect of the selected bonus with alterations made in the effect text box as long as something is selected
                if (bonusListBox.SelectedIndex != -1)
                {
                    bonusList[bonusListBox.SelectedIndex].setEffect(effectTextBox.Text);
                    bonusList[bonusListBox.SelectedIndex].trySave();
                    reloadBonuses();
                }
                else
                {
                    MessageBox.Show("Please select a bonus to edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

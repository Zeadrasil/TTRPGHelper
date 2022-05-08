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
        int id;
        List<Bonus> bonusList;
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
                bonusList[bonusListBox.SelectedIndex].setEffect(effectTextBox.Text);
                bonusList[bonusListBox.SelectedIndex].trySave();
                reloadBonuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

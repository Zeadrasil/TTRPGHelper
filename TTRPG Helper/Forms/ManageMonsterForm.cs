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
    public partial class ManageMonsterForm : Form
    {
        Being being;
        public ManageMonsterForm(Being temp)
        {
            InitializeComponent();
            being = temp;
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

        private void deleteCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmDeleteForm cdf = new ConfirmDeleteForm(being);
                cdf.ShowDialog();
                if (being.getId() == -1)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkStats()
        {
            try
            {
                int tempHolder;
                if (!int.TryParse(strengthTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Strength value is invalid, please enter an integer between 1 and 30");
                    strengthTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(constitutionTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Constitution value is invalid, please enter an integer between 1 and 30");
                    constitutionTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(dexterityTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Dexterity value is invalid, please enter an integer between 1 and 30");
                    dexterityTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(wisdomTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Wisdom value is invalid, please enter an integer between 1 and 30");
                    wisdomTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(intelligenceTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Intelligence value is invalid, please enter an integer between 1 and 30");
                    intelligenceTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(charismaTextBox.Text, out tempHolder) || tempHolder < 1 || tempHolder > 30)
                {
                    MessageBox.Show("Charisma value is invalid, please enter an integer between 1 and 30");
                    charismaTextBox.Focus();
                    return false;
                }

                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Name value is empty, please enter a name");
                    nameTextBox.Focus();
                    return false;
                }

                if (raceTextBox.Text == "")
                {
                    MessageBox.Show("Race value is empty, please enter a race");
                    raceTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(speedTextBox.Text, out tempHolder) || tempHolder < 0 || (tempHolder % 5) != 0)
                {
                    MessageBox.Show("Speed value is invalid, please enter an integer above 0 that is a multiple of 5");
                    speedTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(maxHealthTextBox.Text, out tempHolder) || tempHolder < 1)
                {
                    MessageBox.Show("Maximum health value is invalid, please enter an integer of at least 1");
                    maxHealthTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(healthTextBox.Text, out tempHolder) || tempHolder < -1 || tempHolder > int.Parse(maxHealthTextBox.Text))
                {
                    MessageBox.Show("Health value is invalid, please enter an integer of at least -1 that is below the maximum health");
                    healthTextBox.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void ManageMonsterForm_Load(object sender, EventArgs e)
        {
            try
            {
                strengthTextBox.Text = being.getStrength().ToString();
                constitutionTextBox.Text = being.getConstitution().ToString();
                dexterityTextBox.Text = being.getDexterity().ToString();
                wisdomTextBox.Text = being.getWisdom().ToString();
                intelligenceTextBox.Text = being.getIntelligence().ToString();
                charismaTextBox.Text = being.getCharisma().ToString();

                nameTextBox.Text = being.getName();
                raceTextBox.Text = being.getRace();
                speedTextBox.Text = being.getSpeed().ToString();

                maxHealthTextBox.Text = being.getMaxHealth().ToString();
                healthTextBox.Text = being.getHealth().ToString();
                armorClassTextBox.Text = being.getArmorClass().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void savePlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkStats())
                {
                    int tempHolder;
                    if (!int.TryParse(armorClassTextBox.Text, out tempHolder) || tempHolder < 0)
                    {
                        MessageBox.Show("Armor class value is invalid, please enter an integer of at least 0");
                        armorClassTextBox.Focus();
                        return;
                    }
                    int idHolder = being.getId();
                    being = new Being(idHolder, int.Parse(strengthTextBox.Text), int.Parse(constitutionTextBox.Text),
                        int.Parse(dexterityTextBox.Text), int.Parse(wisdomTextBox.Text), int.Parse(intelligenceTextBox.Text),
                        int.Parse(charismaTextBox.Text), int.Parse(maxHealthTextBox.Text), int.Parse(speedTextBox.Text),
                        int.Parse(healthTextBox.Text), true, nameTextBox.Text, raceTextBox.Text, tempHolder);
                    being.trySave();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

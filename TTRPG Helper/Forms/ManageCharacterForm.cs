/*Author: David Griffith
 Date: 5/8/2022
Description: form allowing users to change character data*/
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

namespace TTRPG_Helper.Forms
{
    public partial class ManageCharacterForm : Form
    {
        //player storage to reduce database calls
        Player player;

        //database access
        CharacterLINQDataContext npcbase;
        public ManageCharacterForm(Player playerData)
        {
            InitializeComponent();
            player = playerData;
            npcbase = new CharacterLINQDataContext();
        }

        //begins deletion of character
        private void deleteCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmDeleteForm cdf = new ConfirmDeleteForm(player);
                cdf.ShowDialog();
                if (player.getId() == -1)
                {
                    Close();
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

        //saves player if all of the fields are valid
        private void savePlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if stats are valid otherwise does not continue
                if (checkStats())
                {
                    //various field checks
                    int tempHolder;
                    if (!int.TryParse(levelTextBox.Text, out tempHolder) || tempHolder < 1)
                    {
                        MessageBox.Show("Level value is invalid, please enter an integer of at least 1");
                        levelTextBox.Focus();
                        return;
                    }

                    if (!int.TryParse(armorClassTextBox.Text, out tempHolder) || tempHolder < 0)
                    {
                        MessageBox.Show("Armor class value is invalid, please enter an integer of at least 0");
                        armorClassTextBox.Focus();
                        return;
                    }

                    if (!int.TryParse(experienceTextBox.Text, out tempHolder) || tempHolder < 0)
                    {
                        MessageBox.Show("Experience value is invalid, please enter an integer of at least 0");
                        experienceTextBox.Focus();
                        return;
                    }

                    if (classTextBox.Text == "")
                    {
                        MessageBox.Show("Class value is empty, please enter a class");
                        classTextBox.Focus();
                        return;
                    }

                    decimal decTempHolder;
                    if (!decimal.TryParse(moneyTextBox.Text, out decTempHolder) || decTempHolder < 0)
                    {
                        MessageBox.Show("Money value is invalid, please enter a decimal value of at least 0");
                        moneyTextBox.Focus();
                        return;
                    }

                    //creates character with all of the new data and the old character's Id, then saves that data and overwrites the old character
                    int idHolder = player.getId();
                    player = new Player(idHolder, int.Parse(strengthTextBox.Text), int.Parse(constitutionTextBox.Text),
                        int.Parse(dexterityTextBox.Text), int.Parse(wisdomTextBox.Text), int.Parse(intelligenceTextBox.Text),
                        int.Parse(charismaTextBox.Text), int.Parse(maxHealthTextBox.Text), int.Parse(speedTextBox.Text),
                        int.Parse(healthTextBox.Text), false, nameTextBox.Text, raceTextBox.Text, int.Parse(armorClassTextBox.Text),
                        int.Parse(levelTextBox.Text), tempHolder, classTextBox.Text, decTempHolder, true);
                    player.tryCharacterSave();

                    //alters the npc database to have the appropriate occupation and location after they are changed if the character is an NPC
                    if (!player.getIsPlayer())
                    {
                        foreach (NPC npc in new CharacterLINQDataContext().NPCs)
                        {
                            if (npc.CharacterId == idHolder)
                            {
                                npc.Occupation = occupationTextBox.Text;
                                npc.Location = locationTextBox.Text;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ensures that all of the entered stat values are integers within the appropriate range
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

        //fills the fields with the intitial values upon load
        private void ManageCharacterForm_Load(object sender, EventArgs e)
        {
            try
            {
                //populates stat displays
                strengthTextBox.Text = player.getStrength().ToString();
                constitutionTextBox.Text = player.getConstitution().ToString();
                dexterityTextBox.Text = player.getDexterity().ToString();
                wisdomTextBox.Text = player.getWisdom().ToString();
                intelligenceTextBox.Text = player.getIntelligence().ToString();
                charismaTextBox.Text = player.getCharisma().ToString();
                
                //populates the second column of text boxes
                nameTextBox.Text = player.getName();
                classTextBox.Text = player.getPlayerClass();
                raceTextBox.Text = player.getRace();
                speedTextBox.Text = player.getSpeed().ToString();
                levelTextBox.Text = player.getLevel().ToString();
                experienceTextBox.Text = player.getXP().ToString();

                //populates third row of text boxes
                maxHealthTextBox.Text = player.getMaxHealth().ToString();
                healthTextBox.Text = player.getHealth().ToString();
                moneyTextBox.Text = Math.Round(player.getMoney(), 2).ToString();
                armorClassTextBox.Text = player.getArmorClass().ToString();

                //populates the occupation and location text boxes if the player is an NPC
                if (!player.getIsPlayer())
                {
                    foreach (NPC npc in npcbase.NPCs)
                    {
                        if (npc.CharacterId == player.getId())
                        {
                            occupationTextBox.Text = npc.Occupation;
                            locationTextBox.Text = npc.Location;
                            return;
                        }
                    }
                }
                //defaults the occupaiton and location text boxes if the character is not an NPC
                occupationTextBox.Text = "N/A";
                locationTextBox.Text = "N/A";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

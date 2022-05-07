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
    public partial class NewCharacterForm : Form
    {
        bool dungeonMaster;
        public NewCharacterForm(bool dm)
        {
            InitializeComponent();
            dungeonMaster = dm;
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

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkStats())
                {
                    int tempHolder;
                    if(!int.TryParse(levelTextBox.Text, out tempHolder) || tempHolder < 1)
                    {
                        MessageBox.Show("Level value is invalid, please enter an integer of at least 1");
                        levelTextBox.Focus();
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
                    if(!decimal.TryParse(moneyTextBox.Text, out decTempHolder) || decTempHolder < 0)
                    {
                        MessageBox.Show("Money value is invalid, please enter a decimal value of at least 0");
                        moneyTextBox.Focus();
                        return;
                    }

                    Player playerStorage = new Player(-1, int.Parse(strengthTextBox.Text), int.Parse(constitutionTextBox.Text),
                        int.Parse(dexterityTextBox.Text), int.Parse(wisdomTextBox.Text), int.Parse(intelligenceTextBox.Text),
                        int.Parse(charismaTextBox.Text), int.Parse(maxHealthTextBox.Text), int.Parse(speedTextBox.Text), 
                        int.Parse(healthTextBox.Text), false, nameTextBox.Text, raceTextBox.Text, getAC(), 
                        int.Parse(levelTextBox.Text), tempHolder, classTextBox.Text, decTempHolder, true);
                    playerStorage.tryCharacterSaveAsNew();
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
                    levelTextBox.Focus();
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

        private int getAC()
        {
            try
            {
                if (int.Parse(dexterityTextBox.Text) < 2)
                {
                    return 5;
                }
                if (int.Parse(dexterityTextBox.Text) < 4)
                {
                    return 6;
                }
                if (int.Parse(dexterityTextBox.Text) < 6)
                {
                    return 7;
                }
                if (int.Parse(dexterityTextBox.Text) < 8)
                {
                    return 8;
                }
                if (int.Parse(dexterityTextBox.Text) < 10)
                {
                    return 9;
                }
                if (int.Parse(dexterityTextBox.Text) < 12)
                {
                    return 10;
                }
                if (int.Parse(dexterityTextBox.Text) < 14)
                {
                    return 11;
                }
                if (int.Parse(dexterityTextBox.Text) < 16)
                {
                    return 12;
                }
                if (int.Parse(dexterityTextBox.Text) < 18)
                {
                    return 13;
                }
                if (int.Parse(dexterityTextBox.Text) < 20)
                {
                    return 14;
                }
                if (int.Parse(dexterityTextBox.Text) < 22)
                {
                    return 15;
                }
                if (int.Parse(dexterityTextBox.Text) < 24)
                {
                    return 16;
                }
                if (int.Parse(dexterityTextBox.Text) < 26)
                {
                    return 17;
                }
                if (int.Parse(dexterityTextBox.Text) < 28)
                {
                    return 18;
                }
                if (int.Parse(dexterityTextBox.Text) < 30)
                {
                    return 19;
                }
                return 20;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 10;
        }

        private void createNPCButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dungeonMaster && checkStats())
                {
                    int tempHolder;
                    if (!int.TryParse(levelTextBox.Text, out tempHolder) || tempHolder < 1)
                    {
                        MessageBox.Show("Level value is invalid, please enter an integer of at least 1");
                        levelTextBox.Focus();
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

                    if (occupationTextBox.Text == "")
                    {
                        MessageBox.Show("Occupation value is empty, please enter an occupation");
                        occupationTextBox.Focus();
                        return;
                    }

                    if (locationTextBox.Text == "")
                    {
                        MessageBox.Show("Location value is empty, please enter a location");
                        locationTextBox.Focus();
                        return;
                    }

                    decimal decTempHolder;
                    if (!decimal.TryParse(moneyTextBox.Text, out decTempHolder) || decTempHolder < 0)
                    {
                        MessageBox.Show("Money value is invalid, please enter a decimal value of at least 0");
                        moneyTextBox.Focus();
                        return;
                    }

                    Player playerStorage = new Player(-1, int.Parse(strengthTextBox.Text), int.Parse(constitutionTextBox.Text),
                        int.Parse(dexterityTextBox.Text), int.Parse(wisdomTextBox.Text), int.Parse(intelligenceTextBox.Text),
                        int.Parse(charismaTextBox.Text), int.Parse(maxHealthTextBox.Text), int.Parse(speedTextBox.Text),
                        int.Parse(healthTextBox.Text), false, nameTextBox.Text, raceTextBox.Text, getAC(),
                        int.Parse(levelTextBox.Text), tempHolder, classTextBox.Text, decTempHolder, false);
                    playerStorage.tryCharacterSaveAsNew();

                    CharacterLINQDataContext npcbase = new CharacterLINQDataContext();
                    NPC npc = new NPC();
                    foreach(Character character in npcbase.Characters)
                    {
                        if(!character.PlayerCharacter)
                        {
                            npc.CharacterId = character.Id;
                        }
                    }
                    npc.Occupation = occupationTextBox.Text;
                    npc.Location = locationTextBox.Text;
                    npcbase.NPCs.InsertOnSubmit(npc);
                    npcbase.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createMonsterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dungeonMaster && checkStats())
                {
                    Being monsterStorage = new Being(-1, int.Parse(strengthTextBox.Text), int.Parse(constitutionTextBox.Text),
                        int.Parse(dexterityTextBox.Text), int.Parse(wisdomTextBox.Text), int.Parse(intelligenceTextBox.Text),
                        int.Parse(charismaTextBox.Text), int.Parse(maxHealthTextBox.Text), int.Parse(speedTextBox.Text),
                        int.Parse(healthTextBox.Text), true, nameTextBox.Text, raceTextBox.Text, getAC());
                    monsterStorage.trySaveAsNew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

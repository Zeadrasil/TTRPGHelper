/*Author: David Griffith
 Date: 5/8/2022
Description: form allowing the DM to choose a player, NPC, or monster to view and potentially edit, or create a new one*/
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
    public partial class DMForm : Form
    {
        //storage of players, npcs, and characters to reduce database calls
        List<Being> characterList;
        List<Player> playerList;

        //database access
        CharacterLINQDataContext characterbase;
        
        public DMForm()
        {
            InitializeComponent();
        }

        private void DMForm_Load(object sender, EventArgs e)
        {
            try
            {
                //populates storages and displays wioth NPCs. players, and monsters upon load
                resetCharacterList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCharacterButton_Click(object sender, EventArgs e)
        {
            //ensures that a character/monster is selected
            if(characterListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a character");
                characterListBox.Focus();
                return;
            }

            //chekcs to see if the selected character is a player or NPC, and creates the appropriate form if so
            foreach (Player player in playerList)
            {
                if (player.getId() == characterList[characterListBox.SelectedIndex].getId())
                {
                    CharacterSheetForm csf = new CharacterSheetForm(player);
                    Hide();
                    csf.ShowDialog();
                    Show();
                    resetCharacterList();
                    return;
                }
            }

            //creates the form for monsters if the selected item was not a player/NPC
            MonsterSheetForm msf = new MonsterSheetForm(characterList[characterListBox.SelectedIndex]);
            Hide();
            msf.ShowDialog();
            Show();
            resetCharacterList();
        }

        //opens form so that the DM can create a new player/NPC/monster
        private void newCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewCharacterForm ncf = new NewCharacterForm(true);
                Hide();
                ncf.ShowDialog();
                Show();
                resetCharacterList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void quitButton_Click(object sender, EventArgs e)
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

        private void resetCharacterList()
        {
            try
            {
                //resets variables in order to prevent stale data
                characterbase = new CharacterLINQDataContext();
                characterList = new List<Being>();
                playerList = new List<Player>();
                characterListBox.Items.Clear();

                foreach (Character character in characterbase.Characters)
                {
                    if (character.PlayerCharacter)
                    {
                        //adds item to the character and being lists if it is a player, then adds it to the display
                        characterListBox.Items.Add(character.CharacterName + ", Level " + character.Level.ToString()
                            + " " + character.Race + " " + character.Class + "(" + character.Id.ToString() + ")");
                        Player player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
                            character.Level, character.Experience, character.Class, character.Money, true);
                        characterList.Add(player);
                        playerList.Add(player);
                    }
                    else if (!character.Monster)
                    {
                        //collects the occupation and location for later use if the being is an NPC
                        string occupation = "", location = "";
                        foreach (NPC npc in characterbase.NPCs)
                        {
                            if (npc.CharacterId == character.Id)
                            {
                                occupation = npc.Occupation;
                                location = npc.Location;
                            }
                        }
                        //adds the NPC to the character and being lists, then adds the NPC to the display with its occupation and location
                        characterListBox.Items.Add(character.CharacterName + ", Level " + character.Level.ToString()
                            + " " + character.Race + " " + character.Class + ", " + occupation + " at " + location + "(" + character.Id.ToString() + ")");
                        Player player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
                            character.Level, character.Experience, character.Class, character.Money, true);
                        characterList.Add(player);
                        playerList.Add(player);
                    }
                    else
                    {
                        //adds the being to the being list and the display if it is a monster
                        characterListBox.Items.Add(character.CharacterName + " the " + character.Race);
                        Being being = new Being(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass);
                        characterList.Add(being);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

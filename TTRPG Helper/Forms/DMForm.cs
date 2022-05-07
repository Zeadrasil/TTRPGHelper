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
    public partial class DMForm : Form
    {
        List<Being> characterList;
        CharacterLINQDataContext characterbase;
        
        public DMForm()
        {
            InitializeComponent();
        }

        private void DMForm_Load(object sender, EventArgs e)
        {
            try
            {
                resetCharacterList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCharacterButton_Click(object sender, EventArgs e)
        {

        }

        private void newCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewCharacterForm ncf = new NewCharacterForm(true);
                this.Hide();
                ncf.ShowDialog();
                this.Show();
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
                this.Close();
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
                characterbase = new CharacterLINQDataContext();
                characterList = new List<Being>();
                characterListBox.Items.Clear();

                foreach (Character character in characterbase.Characters)
                {
                    if (character.PlayerCharacter)
                    {
                        characterListBox.Items.Add(character.CharacterName + ", Level " + character.Level.ToString()
                            + " " + character.Race + " " + character.Class + "(" + character.Id.ToString() + ")");
                        Player player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
                            character.Level, character.Experience, character.Class, character.Money, true);
                        characterList.Add(player);
                    }
                    else if (!character.Monster)
                    {
                        string occupation = "", location = "";
                        foreach (NPC npc in characterbase.NPCs)
                        {
                            if (npc.CharacterId == character.Id)
                            {
                                occupation = npc.Occupation;
                                location = npc.Location;
                            }
                        }
                        characterListBox.Items.Add(character.CharacterName + ", Level " + character.Level.ToString()
                            + " " + character.Race + " " + character.Class + ", " + occupation + " at " + location + "(" + character.Id.ToString() + ")");
                        Player player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
                            character.Level, character.Experience, character.Class, character.Money, true);
                        characterList.Add(player);
                    }
                    else
                    {
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

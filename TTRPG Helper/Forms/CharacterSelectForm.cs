/*Author: David Griffith
 Date: 5/8/2022
Description: allows the user to choose which character they wish to select for use, create a new character for use, or go to the dungeon master hub*/
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

namespace TTRPG_Helper
{
	public partial class characterSelect : Form
	{
		//storage of characters to limit database calls
		List<Player> characterList;

		//database access
		CharacterLINQDataContext playerbase;

		public characterSelect()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			try
			{
				//fills character storage and display upon load
				resetCharacterList();
			}
			catch(Exception ex)
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

        private void dungeonMasterModeButton_Click(object sender, EventArgs e)
        {
			try
			{
				//sends the user to the dungeon master hub
				DMForm dmf = new DMForm();
				Hide();
				dmf.ShowDialog();
				Show();
				resetCharacterList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void newCharacterButton_Click(object sender, EventArgs e)
        {
			try
			{
				//sends user to form in order to create a new character
				NewCharacterForm ncf = new NewCharacterForm(false);
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

        private void selectCharacterButton_Click(object sender, EventArgs e)
        {
			try
			{
				//opens the character sheet for the selected character if a character is selected
				if(playerListBox.SelectedIndex == -1)
                {
					MessageBox.Show("Please choose a character to select");
					playerListBox.Focus();
					return;
                }
				CharacterSheetForm csf = new CharacterSheetForm(characterList[playerListBox.SelectedIndex]);
				Hide();
				csf.ShowDialog();
				Show();
				resetCharacterList();
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
				//resets character storage and display, then refills each
				characterList = new List<Player>();
				playerbase = new CharacterLINQDataContext();
				playerListBox.Items.Clear();

				foreach (Character character in playerbase.Characters)
				{
					if (character.PlayerCharacter)
					{
						playerListBox.Items.Add(character.CharacterName + ", Level " + character.Level.ToString()
							+ " " + character.Race + " " + character.Class + "(" + character.Id.ToString() + ")");
						Player player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
							character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
							character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
							character.Level, character.Experience, character.Class, character.Money, true);
						characterList.Add(player);
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

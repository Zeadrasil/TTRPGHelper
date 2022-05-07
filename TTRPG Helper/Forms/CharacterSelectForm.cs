﻿using System;
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
		List<Player> characterList;
		CharacterLINQDataContext playerbase;

		public characterSelect()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			try
			{
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

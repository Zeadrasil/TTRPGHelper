/*Author: David Griffith
 Date: 5/7/2022
Description: class allowing for use of character data without excessive database access. Expands on the Being class in order to provide support for 
features that are not necessary for monsters to have but are important for NPCs and players*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	public class Player : Being
	{
		//fields that are unnecessary for monsters but important for NPCs and Players
		private int level, experience;
		private string playerClass;
		private decimal money;
		private bool isPlayer;
		public Player(int id, int str, int con, int dex, int wis, int intel, int cha, int max, int spd, int hlt, bool mon, string nme, string rce, 
			int ac, int lvl, int exp, string cls, decimal mny, bool ply) : base(id, str, con, dex, wis, intel, cha, max, spd, hlt, mon, nme, rce, ac)
		{
			
			level = lvl;
			experience = exp;
			playerClass = cls;
			money = mny;
			isPlayer = ply;
		}

		//setters and getters for added fields
		public int getLevel()
		{
			return level;
		}
		public void changeLevel(int lvl)
		{
			level = lvl;
		}

		public int getXP()
		{
			return experience;
		}
		public void changeXP(int exp)
		{
			experience = exp;
		}

		public string getPlayerClass()
		{
			return playerClass;
		}
		public void newClass(string cls)
		{
			playerClass = cls;
		}

		public decimal getMoney()
		{
			return money;
		}
		public void changeMoney(decimal mny)
		{
			money = mny;
		}

		public bool getIsPlayer()
		{
			return isPlayer;
		}
		public void setIsPlayer(bool ply)
		{
			isPlayer = ply;
		}

		//saves character either by creating a new database entry or modifying an existing one
		public void tryCharacterSave()
		{
			try
			{
				foreach (Character character2 in characterbase.Characters)
				{
					if (character2.Id == getId())
					{
						character2.Level = level;
						character2.Money = money;
						character2.Class = playerClass;
						character2.Experience = experience;
						character2.PlayerCharacter = isPlayer;
						characterbase.SubmitChanges();
						trySave();
						return;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void tryCharacterSaveAsNew()
		{
			try
			{
				character.Level = level;
				character.Money = money;
				character.Class = playerClass;
				character.Experience = experience;
				character.PlayerCharacter = isPlayer;
				character.CharacterName = getName();
				character.Race = getRace();
				characterbase.Characters.InsertOnSubmit(character);
				characterbase.SubmitChanges();
				trySave();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper
{
	class Entity
	{
		private int characterId, strength, constitution, dexterity, wisdom, intelligence, charisma, maxHealth, speed, health, armorClass;
		private bool isMonster;
		private string name, race;
		CharacterLINQDataContext characterbase;
		Character character;


		public Entity(int id, int str, int con, int dex, int wis, int intel, int cha, int max, int spd, int hlt, bool mon, string nme, string rce, int ac)
		{
			characterId = id;
			strength = str;
			constitution = con;
			dexterity = dex;
			wisdom = wis;
			intelligence = intel;
			charisma = cha;
			maxHealth = max;
			speed = spd;
			health = hlt;
			isMonster = mon;
			name = nme;
			race = rce;
			armorClass = ac;
			characterbase = new CharacterLINQDataContext();
			= new Character()
		}

		public int getId()
		{
			return characterID;
		}

		public int getStrength()
		{
			return strength;
		}
		public void newStrength(int str)
		{
			strength = str;
		}

		public int getConstitution()
		{
			return constitution;
		}
		public void newConstitution(int con)
		{
			constitution = con;
		}

		public int getDexterity()
		{
			return dexterity;
		}
		public void newDexterity(int dex)
		{
			dexterity = dex;
		}

		public int getWisdom()
		{
			return wisdom;
		}
		public void newWisdom(int wis)
		{
			wisdom = wis;
		}

		public int getIntelligence()
		{
			return intelligence;
		}
		public void newIntelligence(int intel)
		{
			intelligence = intel;
		}

		public int getCharisma()
		{
			return charisma;
		}
		public void newCharisma(int cha)
		{
			charisma = cha;
		}

		public int getMaxHealth()
		{
			return maxHealth;
		}
		public void newMaxHealth(int change)
		{
			maxHealth = change;
		}

		public int getSpeed()
		{
			return speed;
		}
		public void setSpeed(int spd)
		{
			speed = spd;
		}

		public int getHealth()
		{
			return health;
		}
		public void newHealth(int change)
		{
			health = change;
		}

		public string getName()
		{
			return name;
		}
		public void newName(string newName)
		{
			name = newName;
		}

		public bool getMonster()
		{
			return isMonster;
		}
		public void setMonster(bool monster)
		{
			isMonster = monster;
		}

		public string getRace()
		{
			return race;
		}
		public void newRace(string newRace)
		{
			race = newRace;
		}

		public int getArmorClass()
		{
			return armorClass;
		}
		public void changeArmorClass(int ac)
		{
			armorClass = ac;
		}

		public void trySave()
		{
			try
			{
				foreach(Character character2 in characterbase.Characters)
				{
					if(characterId == character.Id)
					{
						character2.Strength = strength;
						character2.Speed = speed;
						character2.Constitution = constitution;
						character2.Dexterity = dexterity;
						character2.Wisdom = wisdom;
						character2.Charisma = charisma;
						character2.Intelligence = intelligence;
						character2.MaxHealth = maxHealth;
						character2.Health = health;
						character2.Strength = strength;
						character2.CharacterName = name;
						character2.Race = race;
						character2.Monster = isMonster;
						characterbase.SubmitChanges();
						return;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void trySaveAsNew()
		{
			try
			{
				character.Strength = strength;
				character.Speed = speed;
				character.Constitution = constitution;
				character.Dexterity = dexterity;
				character.Wisdom = wisdom;
				character.Charisma = charisma;
				character.Intelligence = intelligence;
				character.MaxHealth = maxHealth;
				character.Health = health;
				character.Strength = strength;
				character.CharacterName = name;
				character.Race = race;
				character.Monster = isMonster;
				characterbase.Characters.InsertOnSubmit(character);
				characterbase.SubmitChanges();
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

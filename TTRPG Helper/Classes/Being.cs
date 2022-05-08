/*Author: David Griffith
 Date: 5/7/2022
Description: class for storing information about a character. This includes players. NPCs. and monsters. Players and NPCs should use the Player subclass,
as it contains additional features that are necessary for proper functions for those types of characters*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	public class Being
	{
		//storage for various information used by all types of characters
		private int characterId, strength, constitution, dexterity, wisdom, intelligence, charisma, maxHealth, speed, health, armorClass;
		private bool isMonster;
		private string name, race;

		//allows database access
		public CharacterLINQDataContext characterbase;
		public Character character;


		public Being(int id, int str, int con, int dex, int wis, int intel, int cha, int max, int spd, int hlt, bool mon, string nme, string rce, int ac)
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
			character = new Character();
		}

		//setters and getters for all of the various types of data stored
		public int getId()
		{
			return characterId;
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

		//allows saving of the character by either changing an existing character or creating a new database entry
		public void trySave()
		{
			try
			{
				foreach(Character character2 in characterbase.Characters)
				{
					if(characterId == character2.Id)
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//destroys the character and all associated items, spells, and bonuses, in addition to NPC data if applicable
		public void tryDelete()
		{
			try
			{
				ItemLINQDataContext itembase = new ItemLINQDataContext();

				//clears associated items
				foreach(Item item in itembase.Items)
				{
					if(item.OwnerId == characterId)
					{
						itembase.Items.DeleteOnSubmit(item);
					}
				}
				itembase.SubmitChanges();

				SpellLINQDataContext spellbase = new SpellLINQDataContext();

				//clears associated spells
				foreach(PreparedSpell spell in spellbase.PreparedSpells)
				{
					if(spell.CharacterId == characterId)
					{
						spellbase.PreparedSpells.DeleteOnSubmit(spell);
					}
				}
				spellbase.SubmitChanges();

				//clears associated npc data
				foreach(NPC npc in characterbase.NPCs)
                {
					if(npc.CharacterId == characterId)
                    {
						characterbase.NPCs.DeleteOnSubmit(npc);
                    }
                }

				//removes character from database
				foreach(Character character2 in characterbase.Characters)
				{
					if(character2.Id == characterId)
					{
						characterbase.Characters.DeleteOnSubmit(character2);
						characterbase.SubmitChanges();
						characterId = -1;
						return;
					}
				}
				MessageBox.Show("Could not find character in database");
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}
	}
}

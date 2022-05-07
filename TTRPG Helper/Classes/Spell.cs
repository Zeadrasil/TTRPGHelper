using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	class Spell
	{
		private int spellId, ownerId, diceAmount, diceSize;
		private string spellName;
		PreparedSpell spell;
		SpellLINQDataContext spellbase;

		public Spell(int id, int owner, int dice, int size, string name)
		{
			spellId = id;
			ownerId = owner;
			diceAmount = dice;
			diceSize = size;
			spellName = name;
			spell = new PreparedSpell();
			spellbase = new SpellLINQDataContext();
		}

		public int getId()
		{
			return spellId;
		}

		public int getOwnerId()
		{
			return ownerId;
		}
		public void setOwnerId(int newOwner)
		{
			ownerId = newOwner;
		}

		public int getDiceAmount()
		{
			return diceAmount;
		}
		public void setDiceAmount(int dice)
		{
			diceAmount = dice;
		}

		public int getDiceSize()
		{
			return diceSize;
		}
		public void setDiceSizze(int size)
		{
			diceSize = size;
		}

		public string getName()
		{
			return spellName;
		}
		public void setName(string name)
		{
			spellName = name;
		}

		public void trySave()
		{
			try
			{
				foreach(PreparedSpell spell2 in spellbase.PreparedSpells)
				{
					if(spell2.Id == spellId)
					{
						spell2.CharacterId = ownerId;
						spell2.DiceAmount = diceAmount;
						spell2.DiceSize = diceSize;
						spell2.SpellName = spellName;
						spellbase.SubmitChanges();
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
				spell.CharacterId = ownerId;
				spell.DiceAmount = diceAmount;
				spell.DiceSize = diceSize;
				spell.SpellName = spellName;
				spellbase.PreparedSpells.InsertOnSubmit(spell);
				spellbase.SubmitChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void tryDelete()
		{
			try
			{
				foreach(PreparedSpell spell2 in spellbase.PreparedSpells)
				{
					if(spellId == spell2.Id)
					{
						spellbase.PreparedSpells.DeleteOnSubmit(spell2);
						spellbase.SubmitChanges();
						spellId = -1;
						return;
					}
				}
				MessageBox.Show("Could not find spell in database");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

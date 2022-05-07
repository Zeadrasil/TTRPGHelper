using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	class Weapon : Object
	{
		private int itemId, ownerId, quantity, diceSize, diceAmount;
		private string itemName, itemType;
		private decimal cost;
		private Item item;
		private ItemLINQDataContext itembase;

		public Weapon(int id, int own, int quan, string name, string type, decimal cst, int dice, int size) : base(id, own, quan, name, type, cst)
		{
			diceSize = size;
			diceAmount = dice;
			itemId = id;
			ownerId = own;
			quantity = quan;
			itemName = name;
			itemType = type;
			cost = cst;
			item = new Item();
			itembase = new ItemLINQDataContext();
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
		public void setDiceSize(int size)
		{
			diceSize = size;
		}

		public void tryWeaponSave()
		{
			try
			{
				foreach(Item item2 in itembase.Items)
				{
					if(item2.Id == itemId)
					{
						item2.AttackDiceAmount = diceAmount;
						item2.AttackDiceSize = diceSize;
						itembase.SubmitChanges();
						this.trySave();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void tryWeaponSaveAsNew()
		{
			try
			{
				item.Cost = cost;
				item.OwnerId = ownerId;
				item.ItemName = itemName;
				item.ItemType = itemType;
				item.Quantity = quantity;
				item.AttackDiceAmount = diceAmount;
				item.AttackDiceSize = diceSize;
				itembase.Items.InsertOnSubmit(item);
				itembase.SubmitChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}
}

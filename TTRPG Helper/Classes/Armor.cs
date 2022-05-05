using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	class Armor : Object
	{
		private int itemId, ownerId, quantity, armorClass;
		private string itemName, itemType;
		private decimal cost;
		private Item item;
		private ItemLINQDataContext itembase;

		public Armor(int id, int own, int quan, string name, string type, decimal cst, int ac) : base(id, own, quan, name, type, cst)
		{
			armorClass = ac;
		}

		public int getArmorClass()
		{
			return armorClass;
		}
		public void setArmorClass(int ac)
		{
			armorClass = ac;
		}

		public void tryArmorSave()
		{
			try
			{
				foreach(Item item2 in itembase.Items)
				{
					if(item2.Id == itemId)
					{
						item2.ArmorClassProvided = armorClass;
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
		public void tryArmorSaveAsNew()
		{
			try
			{
				item.Cost = cost;
				item.OwnerId = ownerId;
				item.ItemName = itemName;
				item.ItemType = itemType;
				item.Quantity = quantity;
				item.ArmorClassProvided = armorClass;
				itembase.Items.InsertOnSubmit(item);
				itembase.SubmitChanges();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

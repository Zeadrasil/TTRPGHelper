using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
	class Object
	{
		private int itemId, ownerId, quantity;
		private string itemName, itemType;
		private decimal cost;
		private Item item;
		private ItemLINQDataContext itembase;
		
		public Object(int id, int own, int quan, string name, string type, decimal cst)
		{
			itemId = id;
			ownerId = own;
			quantity = quan;
			itemName = name;
			itemType = type;
			cost = cst;
			item = new Item();
			itembase = new ItemLINQDataContext();
		}

		public int getId()
		{
			return itemId;
		}

		public int getOwner()
		{
			return ownerId;
		}
		public void setOwner(int newOwner)
		{
			ownerId = newOwner;
		}

		public int getAmount()
		{
			return quantity;
		}
		public void setAmount(int amount)
		{
			quantity = amount;
		}

		public string getName()
		{
			return itemName;
		}
		public void setName(string name)
		{
			itemName = name;
		}

		public string getType()
		{
			return itemType;
		}
		public void setType(string type)
		{
			itemType = type;
		}

		public decimal getCost()
		{
			return cost;
		}
		public void setCost(decimal price)
		{
			cost = price;
		}

		public void trySave()
		{
			try
			{
				foreach(Item item2 in itembase.Items)
				{
					if(itemId == item2.Id)
					{
						item2.OwnerId = ownerId;
						item2.Quantity = quantity;
						item2.ItemName = itemName;
						item2.ItemType = itemType;
						item2.Cost = cost;
						itembase.SubmitChanges();
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
				item.Cost = cost;
				item.OwnerId = ownerId;
				item.ItemName = itemName;
				item.ItemType = itemType;
				item.Quantity = quantity;
				itembase.Items.InsertOnSubmit(item);
				itembase.SubmitChanges();
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
				foreach(Item item2 in itembase.Items)
                {
					if(item2.Id == itemId)
                    {
						itembase.Items.DeleteOnSubmit(item2);
						itembase.SubmitChanges();
						itemId = -1;
						return;
                    }
                }
				MessageBox.Show("Could not find item in database");
            }
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }
	}
}

/*Author: David Griffith
 Date: 5/7/2022
Description: class allowing data about items to be handled without excessive database calls. Subclasses for extra information based on whether the item
is a weapon or armor are best used in those situations, while this one is mainly for use for other types of items*/
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
		//stores various item data
		private int itemId, ownerId, quantity;
		private string itemName, itemType;
		private decimal cost;

		//database access
		public Item item;
		public ItemLINQDataContext itembase;
		
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

		//setters and getters for various fields
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

		//saves item by altering a database entry or creating a new one
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

		//deletes the item from the database
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

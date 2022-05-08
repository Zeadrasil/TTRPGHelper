/*Author: David Griffith
 Date: 5/7/2022
Description: class allowing storage and use of data pertaining to a piece of armor without excessive database calls*/
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
		//data storage for values that are not also values of parent class
		private int armorClass;

		public Armor(int id, int own, int quan, string name, string type, decimal cst, int ac) : base(id, own, quan, name, type, cst)
		{
			armorClass = ac;
		}

		//getters and setters
		public int getArmorClass()
		{
			return armorClass;
		}
		public void setArmorClass(int ac)
		{
			armorClass = ac;
		}

		//saves this armor, either as a brand new item or by changing data already present in the database
		public void tryArmorSave()
		{
			try
			{
				foreach(Item item2 in itembase.Items)
				{
					if(item2.Id == getId())
					{
						item2.ArmorClassProvided = armorClass;
						itembase.SubmitChanges();
						trySave();
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
				item.Cost = getCost();
				item.OwnerId = getOwner();
				item.ItemName = getName();
				item.ItemType = getType();
				item.Quantity = getAmount();
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

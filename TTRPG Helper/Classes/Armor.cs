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
		private int armorClass;

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
					if(item2.Id == this.getId())
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
				item.Cost = this.getCost();
				item.OwnerId = this.getOwner();
				item.ItemName = this.getName();
				item.ItemType = this.getType();
				item.Quantity = this.getAmount();
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

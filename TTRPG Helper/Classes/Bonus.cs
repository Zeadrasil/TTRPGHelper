/*Author: David griffith
 Date: 5/7/2022
Description: class allowing data about bonuses to be handled without excessive database calls*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Helper.Database_Files;
using System.Windows.Forms;

namespace TTRPG_Helper.Classes
{
    public class Bonus
    {
        //stores information about the bonus
        private int id, characterId;
        private string effect;

        //database access
        private CharacterLINQDataContext bonusbase;

        public Bonus(int bonusId, int ownerId, string bonusEffect)
        {
            id = bonusId;
            effect = bonusEffect;
            characterId = ownerId;
            bonusbase = new CharacterLINQDataContext();
        }

        //setters and getters for stored information
        public int getId()
        {
            return id;
        }

        public int getOwner()
        {
            return characterId;
        }
        public void setOwner(int newOwner)
        {
            characterId = newOwner;
        }

        public string getEffect()
        {
            return effect;
        }
        public void setEffect(string newEffect)
        {
            effect = newEffect;
        }

        //saves data either by altering existing database entries or by making a new one
        public void trySave()
        {
            try
            {
                foreach (Bonuses bonus in bonusbase.Bonuses)
                {
                    if (bonus.Id == id)
                    {
                        bonus.Effect = effect;
                        bonus.CharacterId = characterId;
                        bonusbase.SubmitChanges();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void trySaveAsNew()
        {
            try
            {
                Bonuses bonus = new Bonuses();
                bonus.Effect = effect;
                bonus.CharacterId = characterId;
                bonusbase.Bonuses.InsertOnSubmit(bonus);
                bonusbase.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //deletes the bonus
        public void tryDelete()
        {
            try
            {
                foreach (Bonuses bonus in bonusbase.Bonuses)
                {
                    if (bonus.Id == id)
                    {
                        bonusbase.Bonuses.DeleteOnSubmit(bonus);
                        bonusbase.SubmitChanges();
                        id = -1;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

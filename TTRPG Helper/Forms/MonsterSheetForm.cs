/*Author: David Griffith
 * Date: 5/8/2022
 Description: form allowing DMs to see data about a monster that they have selected, which leads to forms where all aspects of the monster can be altered*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTRPG_Helper.Classes;
using TTRPG_Helper.Database_Files;

namespace TTRPG_Helper.Forms
{
    public partial class MonsterSheetForm : Form
    {
        //storage structure allowing for less database calls
        Being being;

        //database access
        ItemLINQDataContext itembase;
        SpellLINQDataContext spellbase;
        CharacterLINQDataContext bonusbase;
        public MonsterSheetForm(Being temp)
        {
            InitializeComponent();
            being = temp;
            itembase = new ItemLINQDataContext();
            spellbase = new SpellLINQDataContext();
            bonusbase = new CharacterLINQDataContext();
            resetData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetData()
        {
            try
            {
                //clears out all of the storage structures for the monster information
                spellListBox.Items.Clear();
                itemListBox.Items.Clear();
                bonusesListBox.Items.Clear();
                List<Armor> armorsList = new List<Armor>();
                List<Weapon> weaponsList = new List<Weapon>();
                List<Classes.Object> objectsList = new List<Classes.Object>();
                List<Spell> attackSpellsList = new List<Spell>();
                List<Spell> otherSpellsList = new List<Spell>();

                //sets the texts of the stat displays to the appropriate value for each stat
                strengthStatDisplay.Text = being.getStrength().ToString();
                constitutionStatDisplay.Text = being.getConstitution().ToString();
                dexterityStatDisplay.Text = being.getDexterity().ToString();
                wisdomStatDisplay.Text = being.getWisdom().ToString();
                intelligenceStatDisplay.Text = being.getIntelligence().ToString();
                charismaStatDisplay.Text = being.getCharisma().ToString();

                //goes through each stat then gets its modifier, then displays the modifier with the appropriate symbol in front of it
                if (getModifier(being.getStrength()) < 0)
                {
                    strengthModDisplay.Text = getModifier(being.getStrength()).ToString();
                }
                else
                {
                    strengthModDisplay.Text = "+" + getModifier(being.getStrength()).ToString();
                }

                if (getModifier(being.getConstitution()) < 0)
                {
                    constitutionModDisplay.Text = getModifier(being.getConstitution()).ToString();
                }
                else
                {
                    constitutionModDisplay.Text = "+" + getModifier(being.getConstitution()).ToString();
                }

                if (getModifier(being.getDexterity()) < 0)
                {
                    dexterityModDisplay.Text = getModifier(being.getDexterity()).ToString();
                }
                else
                {
                    dexterityModDisplay.Text = "+" + getModifier(being.getDexterity()).ToString();
                }

                if (getModifier(being.getWisdom()) < 0)
                {
                    wisdomModDisplay.Text = getModifier(being.getWisdom()).ToString();
                }
                else
                {
                    wisdomModDisplay.Text = "+" + getModifier(being.getWisdom()).ToString();
                }

                if (getModifier(being.getIntelligence()) < 0)
                {
                    intelligenceModDisplay.Text = getModifier(being.getIntelligence()).ToString();
                }
                else
                {
                    intelligenceModDisplay.Text = "+" + getModifier(being.getIntelligence()).ToString();
                }

                if (getModifier(being.getCharisma()) < 0)
                {
                    charismaModDisplay.Text = getModifier(being.getCharisma()).ToString();
                }
                else
                {
                    charismaModDisplay.Text = "+" + getModifier(being.getCharisma()).ToString();
                }

                //sets the texts of various displays to the proper values
                healthDisplay.Text = being.getHealth().ToString() + "/" + being.getMaxHealth().ToString();
                speedDisplay.Text = being.getSpeed().ToString();
                armorClassDisplay.Text = being.getArmorClass().ToString();
                nameDisplay.Text = being.getName();
                raceDisplay.Text = being.getRace();

                //collects each item that the character has and stores them all in the appropriate lists in order to display them in their proper groups
                foreach (Item item in itembase.Items)
                {
                    if (item.OwnerId == being.getId())
                    {
                        if (item.ArmorClassProvided != null && item.ArmorClassProvided != 0)
                        {
                            armorsList.Add(new Armor(item.Id, item.OwnerId, item.Quantity ?? default(int), item.ItemName, item.ItemType,
                                item.Cost, item.ArmorClassProvided ?? default(int)));
                        }
                        else if (item.AttackDiceAmount != null && item.AttackDiceAmount != 0 && item.AttackDiceSize != 0)
                        {
                            weaponsList.Add(new Weapon(item.Id, item.OwnerId, item.Quantity ?? default(int), item.ItemName, item.ItemType,
                                item.Cost, item.AttackDiceAmount ?? default(int), item.AttackDiceSize ?? default(int)));
                        }
                        else
                        {
                            objectsList.Add(new Classes.Object(item.Id, item.OwnerId, item.Quantity ?? default(int), item.ItemName, item.ItemType,
                                item.Cost));
                        }
                    }
                }

                //adds items that fall under the armor group
                itemListBox.Items.Add("Armor:");
                foreach (Armor armor in armorsList)
                {
                    itemListBox.Items.Add(string.Format(armor.getAmount().ToString() + " " + armor.getName() + " (" + armor.getType()
                        + ") providing " + armor.getArmorClass().ToString() + " worth {0:C}", armor.getCost()));
                }

                //adds items that fall under the weapons group
                itemListBox.Items.Add("");
                itemListBox.Items.Add("Weapons:");
                foreach (Weapon weapon in weaponsList)
                {
                    itemListBox.Items.Add(string.Format(weapon.getAmount().ToString() + " " + weapon.getName() + " (" +
                        weapon.getType() + ") providing " + weapon.getDiceAmount().ToString() + "d" +
                        weapon.getDiceSize().ToString() + " damage worth {0:C}", weapon.getCost()));
                }

                //adds items that do not fit in the armor group or the weapons group
                itemListBox.Items.Add("");
                itemListBox.Items.Add("Other:");
                foreach (Classes.Object item in objectsList)
                {
                    itemListBox.Items.Add(string.Format(item.getAmount().ToString() + " " + item.getName() + " ("
                        + item.getType() + " worth {0:C}", item.getCost()));
                }

                //gets each spell that the character has prepared and sorts them into attack spells and other spells
                foreach (PreparedSpell spell in spellbase.PreparedSpells)
                {
                    if (spell.CharacterId == being.getId())
                    {
                        if (spell.DiceAmount != 0 && spell.DiceSize != 0)
                        {
                            attackSpellsList.Add(new Spell(spell.Id, spell.CharacterId, spell.DiceAmount, spell.DiceSize, spell.SpellName));
                        }
                        else
                        {
                            otherSpellsList.Add(new Spell(spell.Id, spell.CharacterId, spell.DiceAmount, spell.DiceSize, spell.SpellName));
                        }
                    }
                }

                //displays attack spells in their group
                spellListBox.Items.Add("Attack Spells:");
                foreach (Spell spell in attackSpellsList)
                {
                    spellListBox.Items.Add(spell.getName() + " dealing " + spell.getDiceAmount().ToString() +
                        "d" + spell.getDiceSize().ToString() + "damage");
                }

                //displays non-attack spells in their group
                spellListBox.Items.Add("");
                spellListBox.Items.Add("Other Spells:");
                foreach (Spell spell in otherSpellsList)
                {
                    spellListBox.Items.Add(spell.getName());
                }

                //collects and displays all of the bonuses that apply to this character
                foreach (Bonuses bonus in bonusbase.Bonuses)
                {
                    if (bonus.CharacterId == being.getId())
                    {
                        bonusesListBox.Items.Add(bonus.Effect);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getModifier(int stat)
        {
            try
            {
                //returns the appropriate stat modifier based off of the stat that needs to have its modifier checked
                if (stat < 2)
                {
                    return -5;
                }
                if (stat < 4)
                {
                    return -4;
                }
                if (stat < 6)
                {
                    return -3;
                }
                if (stat < 8)
                {
                    return -2;
                }
                if (stat < 10)
                {
                    return -1;
                }
                if (stat < 12)
                {
                    return 0;
                }
                if (stat < 14)
                {
                    return 1;
                }
                if (stat < 16)
                {
                    return 2;
                }
                if (stat < 18)
                {
                    return 3;
                }
                if (stat < 20)
                {
                    return 4;
                }
                if (stat < 22)
                {
                    return 5;
                }
                if (stat < 24)
                {
                    return 6;
                }
                if (stat < 26)
                {
                    return 7;
                }
                if (stat < 28)
                {
                    return 8;
                }
                if (stat < 30)
                {
                    return 9;
                }
                return 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            try
            {
                //loads the form to change the data on the monster, then closes this form if the monster was deleted
                ManageMonsterForm mcf = new ManageMonsterForm(being);
                this.Hide();
                mcf.ShowDialog();
                if (being.getId() == -1)
                {
                    this.Close();
                }
                this.Show();
                reloadData();
                resetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reloadData()
        {
            try
            {
                //goes through and resets the information stored about the character
                foreach (Character character in bonusbase.Characters)
                {
                    if (character.Id == being.getId())
                    {
                        being = new Being(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bonusesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //opens the bonuses form to allow the user to manage the bonuses that their character has
                BonusManagementForm bmf = new BonusManagementForm(being.getId(), being.getName());
                Hide();
                bmf.ShowDialog();
                resetData();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

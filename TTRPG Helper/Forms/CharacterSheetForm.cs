﻿/*Author:David Griffith
 Date: 5/8/2022
Description: displays all information about a character, and allows users to access forms to alter all of it*/
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
    public partial class CharacterSheetForm : Form
    {
        //player info storage to reduce database calls
        Player player;

        //database access
        ItemLINQDataContext itembase;
        SpellLINQDataContext spellbase;
        CharacterLINQDataContext bonusbase;
        public CharacterSheetForm(Player playerInfo)
        {
            InitializeComponent();
            player = playerInfo;
            itembase = new ItemLINQDataContext();
            spellbase = new SpellLINQDataContext();
            bonusbase = new CharacterLINQDataContext();
        }

        //clears character data from displays then reloads it all
        private void resetData()
        {
            try
            {
                //creates and clears storage structures to hold various data
                spellListBox.Items.Clear();
                itemListBox.Items.Clear();
                bonusesListBox.Items.Clear();
                List<Armor> armorsList = new List<Armor>();
                List<Weapon> weaponsList = new List<Weapon>();
                List<Classes.Object> objectsList = new List<Classes.Object>();
                List<Spell> attackSpellsList = new List<Spell>();
                List<Spell> otherSpellsList = new List<Spell>();

                //sends stat data directly to appropriate displays
                strengthStatDisplay.Text = player.getStrength().ToString();
                constitutionStatDisplay.Text = player.getConstitution().ToString();
                dexterityStatDisplay.Text = player.getDexterity().ToString();
                wisdomStatDisplay.Text = player.getWisdom().ToString();
                intelligenceStatDisplay.Text = player.getIntelligence().ToString();
                charismaStatDisplay.Text = player.getCharisma().ToString();

                //puts stats through functions to get the stat modifier then displays the modifier with the appropriate
                //leading symbol in the appropriate display
                if(getModifier(player.getStrength()) < 0)
                {
                    strengthModDisplay.Text = getModifier(player.getStrength()).ToString();
                }
                else
                {
                    strengthModDisplay.Text = "+" + getModifier(player.getStrength()).ToString();
                }

                if (getModifier(player.getConstitution()) < 0)
                {
                    constitutionModDisplay.Text = getModifier(player.getConstitution()).ToString();
                }
                else
                {
                    constitutionModDisplay.Text = "+" + getModifier(player.getConstitution()).ToString();
                }

                if (getModifier(player.getDexterity()) < 0)
                {
                    dexterityModDisplay.Text = getModifier(player.getDexterity()).ToString();
                }
                else
                {
                    dexterityModDisplay.Text = "+" + getModifier(player.getDexterity()).ToString();
                }

                if (getModifier(player.getWisdom()) < 0)
                {
                    wisdomModDisplay.Text = getModifier(player.getWisdom()).ToString();
                }
                else
                {
                    wisdomModDisplay.Text = "+" + getModifier(player.getWisdom()).ToString();
                }

                if (getModifier(player.getIntelligence()) < 0)
                {
                    intelligenceModDisplay.Text = getModifier(player.getIntelligence()).ToString();
                }
                else
                {
                    intelligenceModDisplay.Text = "+" + getModifier(player.getIntelligence()).ToString();
                }

                if (getModifier(player.getCharisma()) < 0)
                {
                    charismaModDisplay.Text = getModifier(player.getCharisma()).ToString();
                }
                else
                {
                    charismaModDisplay.Text = "+" + getModifier(player.getCharisma()).ToString();
                }

                //gets other data and displays it in the proper displays
                healthDisplay.Text = player.getHealth().ToString() + "/" + player.getMaxHealth().ToString();
                speedDisplay.Text = player.getSpeed().ToString();
                armorClassDisplay.Text = player.getArmorClass().ToString();
                levelDisplay.Text = player.getLevel().ToString();
                experienceDisplay.Text = player.getXP().ToString();
                moneyDisplay.Text = string.Format("{0:C}", player.getMoney());
                nameDisplay.Text = player.getName();
                raceDisplay.Text = player.getRace();
                classDisplay.Text = player.getPlayerClass();

                //collects items that the character owns into appropriate structures for their types
                foreach(Item item in itembase.Items)
                {
                    if(item.OwnerId == player.getId())
                    {
                        if(item.ArmorClassProvided != null && item.ArmorClassProvided != 0)
                        {
                            armorsList.Add(new Armor(item.Id, item.OwnerId, item.Quantity ?? default(int), item.ItemName, item.ItemType, 
                                item.Cost, item.ArmorClassProvided ?? default(int)));
                        }
                        else if(item.AttackDiceAmount != null && item.AttackDiceAmount != 0 && item.AttackDiceSize != 0)
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

                //adds the group of items that are different armors to the items display
                itemListBox.Items.Add("Armor:");
                foreach(Armor armor in armorsList)
                {
                    itemListBox.Items.Add(string.Format(armor.getAmount().ToString() + " " + armor.getName() + " (" + armor.getType() 
                        + ") providing " + armor.getArmorClass().ToString() + " worth {0:C}", armor.getCost()));
                }

                //adds the group of items that are different weapons to the items display
                itemListBox.Items.Add("");
                itemListBox.Items.Add("Weapons:");
                foreach (Weapon weapon in weaponsList)
                {
                    itemListBox.Items.Add(string.Format(weapon.getAmount().ToString() + " " + weapon.getName() + " (" + 
                        weapon.getType() + ") providing " + weapon.getDiceAmount().ToString() + "d" + 
                        weapon.getDiceSize().ToString() + " damage worth {0:C}", weapon.getCost()));
                }

                //adds the group of items that are neither weapons nor armors to the items display
                itemListBox.Items.Add("");
                itemListBox.Items.Add("Other:");
                foreach (Classes.Object item in objectsList)
                {
                    itemListBox.Items.Add(string.Format(item.getAmount().ToString() + " " + item.getName() + " (" 
                        + item.getType() + " worth {0:C}", item.getCost()));
                }

                //collects the spells that the character has prepared into groups depending on whether they are attack spells or not
                foreach(PreparedSpell spell in spellbase.PreparedSpells)
                {
                    if(spell.CharacterId == player.getId())
                    {
                        if(spell.DiceAmount != 0 && spell.DiceSize != 0)
                        {
                            attackSpellsList.Add(new Spell(spell.Id, spell.CharacterId, spell.DiceAmount, spell.DiceSize, spell.SpellName));
                        }
                        else
                        {
                            otherSpellsList.Add(new Spell(spell.Id, spell.CharacterId, spell.DiceAmount, spell.DiceSize, spell.SpellName));
                        }
                    }
                }

                //adds attack spells to the spells display
                spellListBox.Items.Add("Attack Spells:");
                foreach(Spell spell in attackSpellsList)
                {
                    spellListBox.Items.Add(spell.getName() + " dealing " + spell.getDiceAmount().ToString() +
                        "d" + spell.getDiceSize().ToString() + "damage");
                }

                //adds non-attack spells to the spells display
                spellListBox.Items.Add("");
                spellListBox.Items.Add("Other Spells:");
                foreach(Spell spell in otherSpellsList)
                {
                    spellListBox.Items.Add(spell.getName());
                }

                //adds the bonuses that apply to the character to the bonuses display
                foreach(Bonuses bonus in bonusbase.Bonuses)
                {
                    if(bonus.CharacterId == player.getId())
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

        private void CharacterSheetForm_Load(object sender, EventArgs e)
        {
            try
            {
                //fills all of the displays upon load
                resetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //gets the stat modifier based off of the stat value passed in
        private int getModifier(int stat)
        {
            try
            {
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

        //sends the user to the character management form, where they can alter character data
        private void characterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCharacterForm mcf = new ManageCharacterForm(player);
                Hide();
                mcf.ShowDialog();
                if (player.getId() == -1)
                {
                    Close();
                }
                Show();
                reloadData();
                resetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //resets the player data that is to be displayed
        private void reloadData()
        {
            try
            {

                foreach (Character character in bonusbase.Characters)
                {
                    if (character.Id == player.getId())
                    {
                        player = new Player(character.Id, character.Strength, character.Constitution, character.Dexterity,
                            character.Wisdom, character.Intelligence, character.Charisma, character.MaxHealth, character.Speed,
                            character.Health, false, character.CharacterName, character.Race, character.ArmorClass,
                            character.Level, character.Experience, character.Class, character.Money, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sends the user to the form to manage the bonuses
        private void bonusesButton_Click(object sender, EventArgs e)
        {
            try
            {
                BonusManagementForm bmf = new BonusManagementForm(player.getId(), player.getName());
                Hide();
                bmf.ShowDialog();
                Show();
                resetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {
            spellManagementForm spells = new spellManagementForm();
            Hide();
            spells.ShowDialog();
            Show();
            resetData();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            DiceForm spells = new DiceForm();
            spells.ShowDialog();
            Show();
            resetData();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryManagementForm inventory = new InventoryManagementForm();
            Hide();
            inventory.ShowDialog();
            Show();
            resetData();
        }
    }
}

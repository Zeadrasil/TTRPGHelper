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
        bool dungeonMaster;
        Player player;
        ItemLINQDataContext itembase;
        SpellLINQDataContext spellbase;
        CharacterLINQDataContext bonusbase;
        public CharacterSheetForm(bool isDM, Player playerInfo)
        {
            InitializeComponent();
            dungeonMaster = isDM;
            player = playerInfo;
            itembase = new ItemLINQDataContext();
            spellbase = new SpellLINQDataContext();
            bonusbase = new CharacterLINQDataContext();
        }

        private void resetData()
        {
            try
            {
                spellListBox.Items.Clear();
                itemListBox.Items.Clear();
                bonusesListBox.Items.Clear();
                List<Armor> armorsList = new List<Armor>();
                List<Weapon> weaponsList = new List<Weapon>();
                List<Classes.Object> objectsList = new List<Classes.Object>();
                List<Spell> attackSpellsList = new List<Spell>();
                List<Spell> otherSpellsList = new List<Spell>();


                strengthStatDisplay.Text = player.getStrength().ToString();
                constitutionStatDisplay.Text = player.getConstitution().ToString();
                dexterityStatDisplay.Text = player.getDexterity().ToString();
                wisdomStatDisplay.Text = player.getWisdom().ToString();
                intelligenceStatDisplay.Text = player.getIntelligence().ToString();
                charismaStatDisplay.Text = player.getCharisma().ToString();


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

                healthDisplay.Text = player.getHealth().ToString() + "/" + player.getMaxHealth().ToString();
                speedDisplay.Text = player.getSpeed().ToString();
                armorClassDisplay.Text = player.getArmorClass().ToString();
                levelDisplay.Text = player.getLevel().ToString();
                experienceDisplay.Text = player.getXP().ToString();
                moneyDisplay.Text = string.Format("{0:C}", player.getMoney());
                nameDisplay.Text = player.getName();
                raceDisplay.Text = player.getRace();
                classDisplay.Text = player.getPlayerClass();

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

                itemListBox.Items.Add("Armor:");
                foreach(Armor armor in armorsList)
                {
                    itemListBox.Items.Add(string.Format(armor.getAmount().ToString() + " " + armor.getName() + " (" + armor.getType() 
                        + ") providing " + armor.getArmorClass().ToString() + " worth {0:C}", armor.getCost()));
                }

                itemListBox.Items.Add("");
                itemListBox.Items.Add("Weapons:");
                foreach (Weapon weapon in weaponsList)
                {
                    itemListBox.Items.Add(string.Format(weapon.getAmount().ToString() + " " + weapon.getName() + " (" + 
                        weapon.getType() + ") providing " + weapon.getDiceAmount().ToString() + "d" + 
                        weapon.getDiceSize().ToString() + " damage worth {0:C}", weapon.getCost()));
                }

                itemListBox.Items.Add("");
                itemListBox.Items.Add("Other:");
                foreach (Classes.Object item in objectsList)
                {
                    itemListBox.Items.Add(string.Format(item.getAmount().ToString() + " " + item.getName() + " (" 
                        + item.getType() + " worth {0:C}", item.getCost()));
                }


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

                spellListBox.Items.Add("Attack Spells:");
                foreach(Spell spell in attackSpellsList)
                {
                    spellListBox.Items.Add(spell.getName() + " dealing " + spell.getDiceAmount().ToString() +
                        "d" + spell.getDiceSize().ToString() + "damage");
                }

                spellListBox.Items.Add("");
                spellListBox.Items.Add("Other Spells:");
                foreach(Spell spell in otherSpellsList)
                {
                    spellListBox.Items.Add(spell.getName());
                }


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
                resetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCharacterForm mcf = new ManageCharacterForm(player);
                this.Hide();
                mcf.ShowDialog();
                if (player.getId() == -1)
                {
                    this.Close();
                }
                this.Show();
                reloadData();
                resetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
    }
}

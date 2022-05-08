
namespace TTRPG_Helper.Forms
{
    partial class MonsterSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.characterButton = new System.Windows.Forms.Button();
            this.bonusesListBox = new System.Windows.Forms.ListBox();
            this.bonusesLabel = new System.Windows.Forms.Label();
            this.bonusesButton = new System.Windows.Forms.Button();
            this.spellsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.spellListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raceDisplay = new System.Windows.Forms.TextBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.armorClassDisplay = new System.Windows.Forms.TextBox();
            this.armorClassLabel = new System.Windows.Forms.Label();
            this.speedDisplay = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.healthDisplay = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.charismaModDisplay = new System.Windows.Forms.TextBox();
            this.charismaStatDisplay = new System.Windows.Forms.TextBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.intelligenceModDisplay = new System.Windows.Forms.TextBox();
            this.intelligenceStatDisplay = new System.Windows.Forms.TextBox();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.wisdomModDisplay = new System.Windows.Forms.TextBox();
            this.wisdomStatDisplay = new System.Windows.Forms.TextBox();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.dexterityModDisplay = new System.Windows.Forms.TextBox();
            this.dexterityStatDisplay = new System.Windows.Forms.TextBox();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.constitutionModDisplay = new System.Windows.Forms.TextBox();
            this.constitutionStatDisplay = new System.Windows.Forms.TextBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.strengthModDisplay = new System.Windows.Forms.TextBox();
            this.strengthStatDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(713, 385);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 55);
            this.backButton.TabIndex = 95;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(349, 383);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 55);
            this.attackButton.TabIndex = 94;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // characterButton
            // 
            this.characterButton.Location = new System.Drawing.Point(268, 383);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(75, 55);
            this.characterButton.TabIndex = 93;
            this.characterButton.Text = "Manage Monster";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // bonusesListBox
            // 
            this.bonusesListBox.FormattingEnabled = true;
            this.bonusesListBox.Location = new System.Drawing.Point(525, 284);
            this.bonusesListBox.Name = "bonusesListBox";
            this.bonusesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.bonusesListBox.Size = new System.Drawing.Size(263, 95);
            this.bonusesListBox.TabIndex = 92;
            this.bonusesListBox.TabStop = false;
            // 
            // bonusesLabel
            // 
            this.bonusesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusesLabel.Location = new System.Drawing.Point(521, 258);
            this.bonusesLabel.Name = "bonusesLabel";
            this.bonusesLabel.Size = new System.Drawing.Size(122, 23);
            this.bonusesLabel.TabIndex = 91;
            this.bonusesLabel.Text = "Bonuses:";
            // 
            // bonusesButton
            // 
            this.bonusesButton.Location = new System.Drawing.Point(187, 383);
            this.bonusesButton.Name = "bonusesButton";
            this.bonusesButton.Size = new System.Drawing.Size(75, 55);
            this.bonusesButton.TabIndex = 90;
            this.bonusesButton.Text = "Manage Bonuses";
            this.bonusesButton.UseVisualStyleBackColor = true;
            this.bonusesButton.Click += new System.EventHandler(this.bonusesButton_Click);
            // 
            // spellsButton
            // 
            this.spellsButton.Location = new System.Drawing.Point(106, 383);
            this.spellsButton.Name = "spellsButton";
            this.spellsButton.Size = new System.Drawing.Size(75, 55);
            this.spellsButton.TabIndex = 89;
            this.spellsButton.Text = "Manage Spells";
            this.spellsButton.UseVisualStyleBackColor = true;
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(25, 383);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(75, 55);
            this.inventoryButton.TabIndex = 88;
            this.inventoryButton.Text = "Manage Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // spellListBox
            // 
            this.spellListBox.FormattingEnabled = true;
            this.spellListBox.Location = new System.Drawing.Point(525, 160);
            this.spellListBox.Name = "spellListBox";
            this.spellListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.spellListBox.Size = new System.Drawing.Size(263, 95);
            this.spellListBox.TabIndex = 87;
            this.spellListBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 86;
            this.label2.Text = "Spells:";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(525, 36);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.itemListBox.Size = new System.Drawing.Size(263, 95);
            this.itemListBox.TabIndex = 85;
            this.itemListBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Inventory:";
            // 
            // raceDisplay
            // 
            this.raceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceDisplay.Location = new System.Drawing.Point(396, 255);
            this.raceDisplay.Name = "raceDisplay";
            this.raceDisplay.ReadOnly = true;
            this.raceDisplay.Size = new System.Drawing.Size(100, 26);
            this.raceDisplay.TabIndex = 81;
            this.raceDisplay.TabStop = false;
            // 
            // raceLabel
            // 
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.Location = new System.Drawing.Point(268, 258);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(122, 23);
            this.raceLabel.TabIndex = 80;
            this.raceLabel.Text = "Race:";
            this.raceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameDisplay
            // 
            this.nameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(396, 204);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.ReadOnly = true;
            this.nameDisplay.Size = new System.Drawing.Size(100, 26);
            this.nameDisplay.TabIndex = 79;
            this.nameDisplay.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(268, 207);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 23);
            this.nameLabel.TabIndex = 78;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // armorClassDisplay
            // 
            this.armorClassDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorClassDisplay.Location = new System.Drawing.Point(396, 105);
            this.armorClassDisplay.Name = "armorClassDisplay";
            this.armorClassDisplay.ReadOnly = true;
            this.armorClassDisplay.Size = new System.Drawing.Size(100, 26);
            this.armorClassDisplay.TabIndex = 71;
            this.armorClassDisplay.TabStop = false;
            // 
            // armorClassLabel
            // 
            this.armorClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorClassLabel.Location = new System.Drawing.Point(268, 108);
            this.armorClassLabel.Name = "armorClassLabel";
            this.armorClassLabel.Size = new System.Drawing.Size(122, 23);
            this.armorClassLabel.TabIndex = 70;
            this.armorClassLabel.Text = "Armor Class:";
            this.armorClassLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // speedDisplay
            // 
            this.speedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedDisplay.Location = new System.Drawing.Point(396, 53);
            this.speedDisplay.Name = "speedDisplay";
            this.speedDisplay.ReadOnly = true;
            this.speedDisplay.Size = new System.Drawing.Size(100, 26);
            this.speedDisplay.TabIndex = 69;
            this.speedDisplay.TabStop = false;
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(268, 56);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(122, 23);
            this.speedLabel.TabIndex = 68;
            this.speedLabel.Text = "Speed:";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // healthDisplay
            // 
            this.healthDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthDisplay.Location = new System.Drawing.Point(396, 6);
            this.healthDisplay.Name = "healthDisplay";
            this.healthDisplay.ReadOnly = true;
            this.healthDisplay.Size = new System.Drawing.Size(100, 26);
            this.healthDisplay.TabIndex = 67;
            this.healthDisplay.TabStop = false;
            // 
            // healthLabel
            // 
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(268, 9);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(122, 23);
            this.healthLabel.TabIndex = 66;
            this.healthLabel.Text = "Health:";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // charismaLabel
            // 
            this.charismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaLabel.Location = new System.Drawing.Point(140, 207);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(122, 23);
            this.charismaLabel.TabIndex = 65;
            this.charismaLabel.Text = "Charisma";
            this.charismaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // charismaModDisplay
            // 
            this.charismaModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaModDisplay.Location = new System.Drawing.Point(170, 233);
            this.charismaModDisplay.Name = "charismaModDisplay";
            this.charismaModDisplay.ReadOnly = true;
            this.charismaModDisplay.Size = new System.Drawing.Size(60, 44);
            this.charismaModDisplay.TabIndex = 64;
            this.charismaModDisplay.TabStop = false;
            this.charismaModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charismaStatDisplay
            // 
            this.charismaStatDisplay.Location = new System.Drawing.Point(182, 283);
            this.charismaStatDisplay.Name = "charismaStatDisplay";
            this.charismaStatDisplay.ReadOnly = true;
            this.charismaStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.charismaStatDisplay.TabIndex = 63;
            this.charismaStatDisplay.TabStop = false;
            this.charismaStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligenceLabel.Location = new System.Drawing.Point(140, 108);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(122, 23);
            this.intelligenceLabel.TabIndex = 62;
            this.intelligenceLabel.Text = "Intelligence";
            this.intelligenceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // intelligenceModDisplay
            // 
            this.intelligenceModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligenceModDisplay.Location = new System.Drawing.Point(170, 134);
            this.intelligenceModDisplay.Name = "intelligenceModDisplay";
            this.intelligenceModDisplay.ReadOnly = true;
            this.intelligenceModDisplay.Size = new System.Drawing.Size(60, 44);
            this.intelligenceModDisplay.TabIndex = 61;
            this.intelligenceModDisplay.TabStop = false;
            this.intelligenceModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intelligenceStatDisplay
            // 
            this.intelligenceStatDisplay.Location = new System.Drawing.Point(182, 184);
            this.intelligenceStatDisplay.Name = "intelligenceStatDisplay";
            this.intelligenceStatDisplay.ReadOnly = true;
            this.intelligenceStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.intelligenceStatDisplay.TabIndex = 60;
            this.intelligenceStatDisplay.TabStop = false;
            this.intelligenceStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomLabel.Location = new System.Drawing.Point(140, 9);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(122, 23);
            this.wisdomLabel.TabIndex = 59;
            this.wisdomLabel.Text = "Wisdom";
            this.wisdomLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wisdomModDisplay
            // 
            this.wisdomModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomModDisplay.Location = new System.Drawing.Point(170, 35);
            this.wisdomModDisplay.Name = "wisdomModDisplay";
            this.wisdomModDisplay.ReadOnly = true;
            this.wisdomModDisplay.Size = new System.Drawing.Size(60, 44);
            this.wisdomModDisplay.TabIndex = 58;
            this.wisdomModDisplay.TabStop = false;
            this.wisdomModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wisdomStatDisplay
            // 
            this.wisdomStatDisplay.Location = new System.Drawing.Point(182, 85);
            this.wisdomStatDisplay.Name = "wisdomStatDisplay";
            this.wisdomStatDisplay.ReadOnly = true;
            this.wisdomStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.wisdomStatDisplay.TabIndex = 57;
            this.wisdomStatDisplay.TabStop = false;
            this.wisdomStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityLabel.Location = new System.Drawing.Point(12, 207);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(122, 23);
            this.dexterityLabel.TabIndex = 56;
            this.dexterityLabel.Text = "Dexterity";
            this.dexterityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dexterityModDisplay
            // 
            this.dexterityModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityModDisplay.Location = new System.Drawing.Point(42, 233);
            this.dexterityModDisplay.Name = "dexterityModDisplay";
            this.dexterityModDisplay.ReadOnly = true;
            this.dexterityModDisplay.Size = new System.Drawing.Size(60, 44);
            this.dexterityModDisplay.TabIndex = 55;
            this.dexterityModDisplay.TabStop = false;
            this.dexterityModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dexterityStatDisplay
            // 
            this.dexterityStatDisplay.Location = new System.Drawing.Point(54, 283);
            this.dexterityStatDisplay.Name = "dexterityStatDisplay";
            this.dexterityStatDisplay.ReadOnly = true;
            this.dexterityStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.dexterityStatDisplay.TabIndex = 54;
            this.dexterityStatDisplay.TabStop = false;
            this.dexterityStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionLabel.Location = new System.Drawing.Point(12, 108);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(122, 23);
            this.constitutionLabel.TabIndex = 53;
            this.constitutionLabel.Text = "Constitution";
            this.constitutionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // constitutionModDisplay
            // 
            this.constitutionModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionModDisplay.Location = new System.Drawing.Point(42, 134);
            this.constitutionModDisplay.Name = "constitutionModDisplay";
            this.constitutionModDisplay.ReadOnly = true;
            this.constitutionModDisplay.Size = new System.Drawing.Size(60, 44);
            this.constitutionModDisplay.TabIndex = 52;
            this.constitutionModDisplay.TabStop = false;
            this.constitutionModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // constitutionStatDisplay
            // 
            this.constitutionStatDisplay.Location = new System.Drawing.Point(54, 184);
            this.constitutionStatDisplay.Name = "constitutionStatDisplay";
            this.constitutionStatDisplay.ReadOnly = true;
            this.constitutionStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.constitutionStatDisplay.TabIndex = 51;
            this.constitutionStatDisplay.TabStop = false;
            this.constitutionStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // strengthLabel
            // 
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.Location = new System.Drawing.Point(12, 9);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(122, 23);
            this.strengthLabel.TabIndex = 50;
            this.strengthLabel.Text = "Strength";
            this.strengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // strengthModDisplay
            // 
            this.strengthModDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthModDisplay.Location = new System.Drawing.Point(42, 35);
            this.strengthModDisplay.Name = "strengthModDisplay";
            this.strengthModDisplay.ReadOnly = true;
            this.strengthModDisplay.Size = new System.Drawing.Size(60, 44);
            this.strengthModDisplay.TabIndex = 49;
            this.strengthModDisplay.TabStop = false;
            this.strengthModDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // strengthStatDisplay
            // 
            this.strengthStatDisplay.Location = new System.Drawing.Point(54, 85);
            this.strengthStatDisplay.Name = "strengthStatDisplay";
            this.strengthStatDisplay.ReadOnly = true;
            this.strengthStatDisplay.Size = new System.Drawing.Size(34, 20);
            this.strengthStatDisplay.TabIndex = 48;
            this.strengthStatDisplay.TabStop = false;
            this.strengthStatDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonsterSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.characterButton);
            this.Controls.Add(this.bonusesListBox);
            this.Controls.Add(this.bonusesLabel);
            this.Controls.Add(this.bonusesButton);
            this.Controls.Add(this.spellsButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.spellListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceDisplay);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.nameDisplay);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.armorClassDisplay);
            this.Controls.Add(this.armorClassLabel);
            this.Controls.Add(this.speedDisplay);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.healthDisplay);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.charismaModDisplay);
            this.Controls.Add(this.charismaStatDisplay);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.intelligenceModDisplay);
            this.Controls.Add(this.intelligenceStatDisplay);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.wisdomModDisplay);
            this.Controls.Add(this.wisdomStatDisplay);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.dexterityModDisplay);
            this.Controls.Add(this.dexterityStatDisplay);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.constitutionModDisplay);
            this.Controls.Add(this.constitutionStatDisplay);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.strengthModDisplay);
            this.Controls.Add(this.strengthStatDisplay);
            this.Name = "MonsterSheetForm";
            this.Text = "MonsterSheetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.ListBox bonusesListBox;
        private System.Windows.Forms.Label bonusesLabel;
        private System.Windows.Forms.Button bonusesButton;
        private System.Windows.Forms.Button spellsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.ListBox spellListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox raceDisplay;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox nameDisplay;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox armorClassDisplay;
        private System.Windows.Forms.Label armorClassLabel;
        private System.Windows.Forms.TextBox speedDisplay;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox healthDisplay;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.TextBox charismaModDisplay;
        private System.Windows.Forms.TextBox charismaStatDisplay;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.TextBox intelligenceModDisplay;
        private System.Windows.Forms.TextBox intelligenceStatDisplay;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.TextBox wisdomModDisplay;
        private System.Windows.Forms.TextBox wisdomStatDisplay;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.TextBox dexterityModDisplay;
        private System.Windows.Forms.TextBox dexterityStatDisplay;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.TextBox constitutionModDisplay;
        private System.Windows.Forms.TextBox constitutionStatDisplay;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.TextBox strengthModDisplay;
        private System.Windows.Forms.TextBox strengthStatDisplay;
    }
}
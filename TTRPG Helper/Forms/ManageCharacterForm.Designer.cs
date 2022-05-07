
namespace TTRPG_Helper.Forms
{
    partial class ManageCharacterForm
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
            this.savePlayerButton = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.maxHealthTextBox = new System.Windows.Forms.TextBox();
            this.maxHealthLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.charismaTextBox = new System.Windows.Forms.TextBox();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.wisdomTextBox = new System.Windows.Forms.TextBox();
            this.wisdomlabel = new System.Windows.Forms.Label();
            this.dexterityTextBox = new System.Windows.Forms.TextBox();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.constitutionTextBox = new System.Windows.Forms.TextBox();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.armorClassTextBox = new System.Windows.Forms.TextBox();
            this.armorClassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(319, 247);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 35);
            this.backButton.TabIndex = 75;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // savePlayerButton
            // 
            this.savePlayerButton.Location = new System.Drawing.Point(15, 247);
            this.savePlayerButton.Name = "savePlayerButton";
            this.savePlayerButton.Size = new System.Drawing.Size(90, 35);
            this.savePlayerButton.TabIndex = 74;
            this.savePlayerButton.Text = "Save Changes";
            this.savePlayerButton.UseVisualStyleBackColor = true;
            this.savePlayerButton.Click += new System.EventHandler(this.savePlayerButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(307, 220);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 73;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(304, 204);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(79, 13);
            this.locationLabel.TabIndex = 72;
            this.locationLabel.Text = "Location(NPC):";
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.Location = new System.Drawing.Point(307, 181);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(100, 20);
            this.occupationTextBox.TabIndex = 71;
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Location = new System.Drawing.Point(304, 165);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(93, 13);
            this.occupationLabel.TabIndex = 70;
            this.occupationLabel.Text = "Occupation(NPC):";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(307, 103);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.moneyTextBox.TabIndex = 68;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(304, 87);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(42, 13);
            this.moneyLabel.TabIndex = 67;
            this.moneyLabel.Text = "Money:";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(307, 64);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(100, 20);
            this.healthTextBox.TabIndex = 66;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(304, 48);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(41, 13);
            this.healthLabel.TabIndex = 65;
            this.healthLabel.Text = "Health:";
            // 
            // maxHealthTextBox
            // 
            this.maxHealthTextBox.Location = new System.Drawing.Point(307, 25);
            this.maxHealthTextBox.Name = "maxHealthTextBox";
            this.maxHealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxHealthTextBox.TabIndex = 64;
            // 
            // maxHealthLabel
            // 
            this.maxHealthLabel.AutoSize = true;
            this.maxHealthLabel.Location = new System.Drawing.Point(304, 9);
            this.maxHealthLabel.Name = "maxHealthLabel";
            this.maxHealthLabel.Size = new System.Drawing.Size(88, 13);
            this.maxHealthLabel.TabIndex = 63;
            this.maxHealthLabel.Text = "Maximum Health:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(160, 142);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 62;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(157, 126);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 61;
            this.speedLabel.Text = "Speed:";
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.Location = new System.Drawing.Point(160, 220);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(100, 20);
            this.experienceTextBox.TabIndex = 60;
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Location = new System.Drawing.Point(157, 204);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(63, 13);
            this.experienceLabel.TabIndex = 59;
            this.experienceLabel.Text = "Experience:";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(160, 181);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 20);
            this.levelTextBox.TabIndex = 58;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(157, 165);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 57;
            this.levelLabel.Text = "Level:";
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(160, 103);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(100, 20);
            this.raceTextBox.TabIndex = 56;
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(157, 87);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 55;
            this.raceLabel.Text = "Race:";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(160, 64);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 54;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(157, 48);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 53;
            this.classLabel.Text = "Class:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 52;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(157, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 51;
            this.nameLabel.Text = "Name:";
            // 
            // charismaTextBox
            // 
            this.charismaTextBox.Location = new System.Drawing.Point(15, 220);
            this.charismaTextBox.Name = "charismaTextBox";
            this.charismaTextBox.Size = new System.Drawing.Size(100, 20);
            this.charismaTextBox.TabIndex = 50;
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(12, 204);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(53, 13);
            this.charismaLabel.TabIndex = 49;
            this.charismaLabel.Text = "Charisma:";
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.Location = new System.Drawing.Point(15, 181);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.intelligenceTextBox.TabIndex = 48;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(12, 165);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            this.intelligenceLabel.TabIndex = 47;
            this.intelligenceLabel.Text = "Intelligence:";
            // 
            // wisdomTextBox
            // 
            this.wisdomTextBox.Location = new System.Drawing.Point(15, 142);
            this.wisdomTextBox.Name = "wisdomTextBox";
            this.wisdomTextBox.Size = new System.Drawing.Size(100, 20);
            this.wisdomTextBox.TabIndex = 46;
            // 
            // wisdomlabel
            // 
            this.wisdomlabel.AutoSize = true;
            this.wisdomlabel.Location = new System.Drawing.Point(12, 126);
            this.wisdomlabel.Name = "wisdomlabel";
            this.wisdomlabel.Size = new System.Drawing.Size(48, 13);
            this.wisdomlabel.TabIndex = 45;
            this.wisdomlabel.Text = "Wisdom:";
            // 
            // dexterityTextBox
            // 
            this.dexterityTextBox.Location = new System.Drawing.Point(15, 103);
            this.dexterityTextBox.Name = "dexterityTextBox";
            this.dexterityTextBox.Size = new System.Drawing.Size(100, 20);
            this.dexterityTextBox.TabIndex = 44;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(12, 87);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(51, 13);
            this.dexterityLabel.TabIndex = 43;
            this.dexterityLabel.Text = "Dexterity:";
            // 
            // constitutionTextBox
            // 
            this.constitutionTextBox.Location = new System.Drawing.Point(15, 64);
            this.constitutionTextBox.Name = "constitutionTextBox";
            this.constitutionTextBox.Size = new System.Drawing.Size(100, 20);
            this.constitutionTextBox.TabIndex = 42;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(12, 48);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(65, 13);
            this.constitutionLabel.TabIndex = 41;
            this.constitutionLabel.Text = "Constitution:";
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Location = new System.Drawing.Point(15, 25);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.strengthTextBox.TabIndex = 40;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(12, 9);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(50, 13);
            this.strengthLabel.TabIndex = 39;
            this.strengthLabel.Text = "Strength:";
            // 
            // deleteCharacterButton
            // 
            this.deleteCharacterButton.Location = new System.Drawing.Point(165, 251);
            this.deleteCharacterButton.Name = "deleteCharacterButton";
            this.deleteCharacterButton.Size = new System.Drawing.Size(90, 35);
            this.deleteCharacterButton.TabIndex = 76;
            this.deleteCharacterButton.Text = "Delete Character";
            this.deleteCharacterButton.UseVisualStyleBackColor = true;
            this.deleteCharacterButton.Click += new System.EventHandler(this.deleteCharacterButton_Click);
            // 
            // armorClassTextBox
            // 
            this.armorClassTextBox.Location = new System.Drawing.Point(307, 142);
            this.armorClassTextBox.Name = "armorClassTextBox";
            this.armorClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.armorClassTextBox.TabIndex = 78;
            // 
            // armorClassLabel
            // 
            this.armorClassLabel.AutoSize = true;
            this.armorClassLabel.Location = new System.Drawing.Point(304, 126);
            this.armorClassLabel.Name = "armorClassLabel";
            this.armorClassLabel.Size = new System.Drawing.Size(65, 13);
            this.armorClassLabel.TabIndex = 77;
            this.armorClassLabel.Text = "Armor Class:";
            // 
            // ManageCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 298);
            this.Controls.Add(this.armorClassTextBox);
            this.Controls.Add(this.armorClassLabel);
            this.Controls.Add(this.deleteCharacterButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.savePlayerButton);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.maxHealthTextBox);
            this.Controls.Add(this.maxHealthLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(this.experienceLabel);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.charismaTextBox);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.intelligenceTextBox);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.wisdomTextBox);
            this.Controls.Add(this.wisdomlabel);
            this.Controls.Add(this.dexterityTextBox);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.constitutionTextBox);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.strengthTextBox);
            this.Controls.Add(this.strengthLabel);
            this.Name = "ManageCharacterForm";
            this.Text = "ManageCharacterForm";
            this.Load += new System.EventHandler(this.ManageCharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button savePlayerButton;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.Label occupationLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox maxHealthTextBox;
        private System.Windows.Forms.Label maxHealthLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox charismaTextBox;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.TextBox intelligenceTextBox;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.TextBox wisdomTextBox;
        private System.Windows.Forms.Label wisdomlabel;
        private System.Windows.Forms.TextBox dexterityTextBox;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.TextBox constitutionTextBox;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Button deleteCharacterButton;
        private System.Windows.Forms.TextBox armorClassTextBox;
        private System.Windows.Forms.Label armorClassLabel;
    }
}
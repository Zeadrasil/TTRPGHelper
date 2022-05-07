
namespace TTRPG_Helper
{
	partial class characterSelect
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.selectCharacterButton = new System.Windows.Forms.Button();
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.dungeonMasterModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(16, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(318, 20);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select Your Character";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(16, 33);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(318, 199);
            this.playerListBox.TabIndex = 1;
            // 
            // selectCharacterButton
            // 
            this.selectCharacterButton.Location = new System.Drawing.Point(16, 239);
            this.selectCharacterButton.Name = "selectCharacterButton";
            this.selectCharacterButton.Size = new System.Drawing.Size(75, 40);
            this.selectCharacterButton.TabIndex = 2;
            this.selectCharacterButton.Text = "Select";
            this.selectCharacterButton.UseVisualStyleBackColor = true;
            this.selectCharacterButton.Click += new System.EventHandler(this.selectCharacterButton_Click);
            // 
            // newCharacterButton
            // 
            this.newCharacterButton.Location = new System.Drawing.Point(97, 239);
            this.newCharacterButton.Name = "newCharacterButton";
            this.newCharacterButton.Size = new System.Drawing.Size(75, 40);
            this.newCharacterButton.TabIndex = 3;
            this.newCharacterButton.Text = "New Character";
            this.newCharacterButton.UseVisualStyleBackColor = true;
            this.newCharacterButton.Click += new System.EventHandler(this.newCharacterButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(259, 238);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 40);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // dungeonMasterModeButton
            // 
            this.dungeonMasterModeButton.Location = new System.Drawing.Point(178, 239);
            this.dungeonMasterModeButton.Name = "dungeonMasterModeButton";
            this.dungeonMasterModeButton.Size = new System.Drawing.Size(75, 40);
            this.dungeonMasterModeButton.TabIndex = 5;
            this.dungeonMasterModeButton.Text = "DM Mode";
            this.dungeonMasterModeButton.UseVisualStyleBackColor = true;
            this.dungeonMasterModeButton.Click += new System.EventHandler(this.dungeonMasterModeButton_Click);
            // 
            // characterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 291);
            this.Controls.Add(this.dungeonMasterModeButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newCharacterButton);
            this.Controls.Add(this.selectCharacterButton);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "characterSelect";
            this.Text = "Character Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button selectCharacterButton;
        private System.Windows.Forms.Button newCharacterButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button dungeonMasterModeButton;
    }
}


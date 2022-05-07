
namespace TTRPG_Helper.Forms
{
    partial class DMForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.selectCharacterButton = new System.Windows.Forms.Button();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(351, 237);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 40);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Back";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // newCharacterButton
            // 
            this.newCharacterButton.Location = new System.Drawing.Point(187, 237);
            this.newCharacterButton.Name = "newCharacterButton";
            this.newCharacterButton.Size = new System.Drawing.Size(75, 40);
            this.newCharacterButton.TabIndex = 9;
            this.newCharacterButton.Text = "New Character";
            this.newCharacterButton.UseVisualStyleBackColor = true;
            this.newCharacterButton.Click += new System.EventHandler(this.newCharacterButton_Click);
            // 
            // selectCharacterButton
            // 
            this.selectCharacterButton.Location = new System.Drawing.Point(12, 236);
            this.selectCharacterButton.Name = "selectCharacterButton";
            this.selectCharacterButton.Size = new System.Drawing.Size(75, 40);
            this.selectCharacterButton.TabIndex = 8;
            this.selectCharacterButton.Text = "Select";
            this.selectCharacterButton.UseVisualStyleBackColor = true;
            this.selectCharacterButton.Click += new System.EventHandler(this.selectCharacterButton_Click);
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.Location = new System.Drawing.Point(12, 32);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(414, 199);
            this.characterListBox.TabIndex = 7;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(414, 20);
            this.instructionLabel.TabIndex = 6;
            this.instructionLabel.Text = "Select Character";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 285);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newCharacterButton);
            this.Controls.Add(this.selectCharacterButton);
            this.Controls.Add(this.characterListBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "DMForm";
            this.Text = "Dungeon Master Hub";
            this.Load += new System.EventHandler(this.DMForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button newCharacterButton;
        private System.Windows.Forms.Button selectCharacterButton;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.Label instructionLabel;
    }
}
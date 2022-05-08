
namespace TTRPG_Helper.Forms
{
    partial class BonusManagementForm
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
            this.bonusLabel = new System.Windows.Forms.Label();
            this.bonusListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveNewButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.effectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bonusLabel
            // 
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.Location = new System.Drawing.Point(13, 13);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(775, 23);
            this.bonusLabel.TabIndex = 0;
            this.bonusLabel.Text = "label1";
            this.bonusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bonusListBox
            // 
            this.bonusListBox.FormattingEnabled = true;
            this.bonusListBox.Location = new System.Drawing.Point(13, 40);
            this.bonusListBox.Name = "bonusListBox";
            this.bonusListBox.Size = new System.Drawing.Size(775, 316);
            this.bonusListBox.TabIndex = 1;
            this.bonusListBox.SelectedIndexChanged += new System.EventHandler(this.bonusListBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Bonus";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveNewButton
            // 
            this.saveNewButton.Location = new System.Drawing.Point(94, 363);
            this.saveNewButton.Name = "saveNewButton";
            this.saveNewButton.Size = new System.Drawing.Size(75, 36);
            this.saveNewButton.TabIndex = 3;
            this.saveNewButton.Text = "Save Bonus As New";
            this.saveNewButton.UseVisualStyleBackColor = true;
            this.saveNewButton.Click += new System.EventHandler(this.saveNewButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(713, 363);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 36);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(602, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 36);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Bonus";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // effectTextBox
            // 
            this.effectTextBox.Location = new System.Drawing.Point(175, 372);
            this.effectTextBox.Name = "effectTextBox";
            this.effectTextBox.Size = new System.Drawing.Size(421, 20);
            this.effectTextBox.TabIndex = 6;
            // 
            // BonusManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.effectTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveNewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bonusListBox);
            this.Controls.Add(this.bonusLabel);
            this.Name = "BonusManagementForm";
            this.Text = "BonusManagementForm";
            this.Load += new System.EventHandler(this.BonusManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.ListBox bonusListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveNewButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox effectTextBox;
    }
}
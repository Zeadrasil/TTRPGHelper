
namespace TTRPG_Helper
{
    partial class DiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceForm));
            this.d20PB = new System.Windows.Forms.PictureBox();
            this.d100PB = new System.Windows.Forms.PictureBox();
            this.d4PB = new System.Windows.Forms.PictureBox();
            this.d6PB = new System.Windows.Forms.PictureBox();
            this.d8PB = new System.Windows.Forms.PictureBox();
            this.d10PB = new System.Windows.Forms.PictureBox();
            this.d12PB = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.d20TB = new System.Windows.Forms.TextBox();
            this.d12TB = new System.Windows.Forms.TextBox();
            this.d10TB = new System.Windows.Forms.TextBox();
            this.d8TB = new System.Windows.Forms.TextBox();
            this.d6TB = new System.Windows.Forms.TextBox();
            this.d4TB = new System.Windows.Forms.TextBox();
            this.d100TB = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.d100OutTB = new System.Windows.Forms.TextBox();
            this.d4OutTB = new System.Windows.Forms.TextBox();
            this.d6OutTB = new System.Windows.Forms.TextBox();
            this.d8OutTB = new System.Windows.Forms.TextBox();
            this.d10OutTB = new System.Windows.Forms.TextBox();
            this.d12OutTB = new System.Windows.Forms.TextBox();
            this.d20OutTB = new System.Windows.Forms.TextBox();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.bonusTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.d20PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12PB)).BeginInit();
            this.SuspendLayout();
            // 
            // d20PB
            // 
            this.d20PB.BackColor = System.Drawing.Color.Transparent;
            this.d20PB.Image = ((System.Drawing.Image)(resources.GetObject("d20PB.Image")));
            this.d20PB.Location = new System.Drawing.Point(12, 12);
            this.d20PB.Name = "d20PB";
            this.d20PB.Size = new System.Drawing.Size(80, 80);
            this.d20PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d20PB.TabIndex = 0;
            this.d20PB.TabStop = false;
            this.d20PB.Click += new System.EventHandler(this.d20PB_Click);
            // 
            // d100PB
            // 
            this.d100PB.BackColor = System.Drawing.Color.Transparent;
            this.d100PB.Image = ((System.Drawing.Image)(resources.GetObject("d100PB.Image")));
            this.d100PB.Location = new System.Drawing.Point(528, 12);
            this.d100PB.Name = "d100PB";
            this.d100PB.Size = new System.Drawing.Size(80, 80);
            this.d100PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d100PB.TabIndex = 1;
            this.d100PB.TabStop = false;
            this.d100PB.Click += new System.EventHandler(this.d100PB_Click);
            // 
            // d4PB
            // 
            this.d4PB.BackColor = System.Drawing.Color.Transparent;
            this.d4PB.Image = ((System.Drawing.Image)(resources.GetObject("d4PB.Image")));
            this.d4PB.Location = new System.Drawing.Point(442, 12);
            this.d4PB.Name = "d4PB";
            this.d4PB.Size = new System.Drawing.Size(80, 80);
            this.d4PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d4PB.TabIndex = 2;
            this.d4PB.TabStop = false;
            this.d4PB.Click += new System.EventHandler(this.d4PB_Click);
            // 
            // d6PB
            // 
            this.d6PB.BackColor = System.Drawing.Color.Transparent;
            this.d6PB.Image = ((System.Drawing.Image)(resources.GetObject("d6PB.Image")));
            this.d6PB.InitialImage = ((System.Drawing.Image)(resources.GetObject("d6PB.InitialImage")));
            this.d6PB.Location = new System.Drawing.Point(356, 12);
            this.d6PB.Name = "d6PB";
            this.d6PB.Size = new System.Drawing.Size(80, 80);
            this.d6PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d6PB.TabIndex = 3;
            this.d6PB.TabStop = false;
            this.d6PB.Click += new System.EventHandler(this.d6PB_Click);
            // 
            // d8PB
            // 
            this.d8PB.BackColor = System.Drawing.Color.Transparent;
            this.d8PB.Image = ((System.Drawing.Image)(resources.GetObject("d8PB.Image")));
            this.d8PB.Location = new System.Drawing.Point(270, 12);
            this.d8PB.Name = "d8PB";
            this.d8PB.Size = new System.Drawing.Size(80, 80);
            this.d8PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d8PB.TabIndex = 4;
            this.d8PB.TabStop = false;
            this.d8PB.Click += new System.EventHandler(this.d8PB_Click);
            // 
            // d10PB
            // 
            this.d10PB.BackColor = System.Drawing.Color.Transparent;
            this.d10PB.Image = ((System.Drawing.Image)(resources.GetObject("d10PB.Image")));
            this.d10PB.Location = new System.Drawing.Point(184, 12);
            this.d10PB.Name = "d10PB";
            this.d10PB.Size = new System.Drawing.Size(80, 80);
            this.d10PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d10PB.TabIndex = 5;
            this.d10PB.TabStop = false;
            this.d10PB.Click += new System.EventHandler(this.d10PB_Click);
            // 
            // d12PB
            // 
            this.d12PB.BackColor = System.Drawing.Color.Transparent;
            this.d12PB.Image = ((System.Drawing.Image)(resources.GetObject("d12PB.Image")));
            this.d12PB.Location = new System.Drawing.Point(98, 12);
            this.d12PB.Name = "d12PB";
            this.d12PB.Size = new System.Drawing.Size(80, 80);
            this.d12PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d12PB.TabIndex = 6;
            this.d12PB.TabStop = false;
            this.d12PB.Click += new System.EventHandler(this.d12PB_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(614, 12);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(614, 121);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalTB
            // 
            this.totalTB.Enabled = false;
            this.totalTB.Location = new System.Drawing.Point(528, 160);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(80, 20);
            this.totalTB.TabIndex = 9;
            // 
            // d20TB
            // 
            this.d20TB.Enabled = false;
            this.d20TB.Location = new System.Drawing.Point(12, 98);
            this.d20TB.Name = "d20TB";
            this.d20TB.Size = new System.Drawing.Size(80, 20);
            this.d20TB.TabIndex = 10;
            this.d20TB.Text = "0";
            // 
            // d12TB
            // 
            this.d12TB.Enabled = false;
            this.d12TB.Location = new System.Drawing.Point(98, 98);
            this.d12TB.Name = "d12TB";
            this.d12TB.Size = new System.Drawing.Size(80, 20);
            this.d12TB.TabIndex = 11;
            this.d12TB.Text = "0";
            // 
            // d10TB
            // 
            this.d10TB.Enabled = false;
            this.d10TB.Location = new System.Drawing.Point(184, 98);
            this.d10TB.Name = "d10TB";
            this.d10TB.Size = new System.Drawing.Size(80, 20);
            this.d10TB.TabIndex = 12;
            this.d10TB.Text = "0";
            // 
            // d8TB
            // 
            this.d8TB.Enabled = false;
            this.d8TB.Location = new System.Drawing.Point(270, 98);
            this.d8TB.Name = "d8TB";
            this.d8TB.Size = new System.Drawing.Size(80, 20);
            this.d8TB.TabIndex = 13;
            this.d8TB.Text = "0";
            // 
            // d6TB
            // 
            this.d6TB.Enabled = false;
            this.d6TB.Location = new System.Drawing.Point(356, 98);
            this.d6TB.Name = "d6TB";
            this.d6TB.Size = new System.Drawing.Size(80, 20);
            this.d6TB.TabIndex = 14;
            this.d6TB.Text = "0";
            // 
            // d4TB
            // 
            this.d4TB.Enabled = false;
            this.d4TB.Location = new System.Drawing.Point(442, 98);
            this.d4TB.Name = "d4TB";
            this.d4TB.Size = new System.Drawing.Size(80, 20);
            this.d4TB.TabIndex = 15;
            this.d4TB.Text = "0";
            // 
            // d100TB
            // 
            this.d100TB.Enabled = false;
            this.d100TB.Location = new System.Drawing.Point(528, 98);
            this.d100TB.Name = "d100TB";
            this.d100TB.Size = new System.Drawing.Size(80, 20);
            this.d100TB.TabIndex = 16;
            this.d100TB.Text = "0";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(614, 160);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(488, 163);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total:";
            // 
            // d100OutTB
            // 
            this.d100OutTB.Enabled = false;
            this.d100OutTB.Location = new System.Drawing.Point(528, 124);
            this.d100OutTB.Name = "d100OutTB";
            this.d100OutTB.Size = new System.Drawing.Size(80, 20);
            this.d100OutTB.TabIndex = 25;
            this.d100OutTB.Text = "0";
            // 
            // d4OutTB
            // 
            this.d4OutTB.Enabled = false;
            this.d4OutTB.Location = new System.Drawing.Point(442, 124);
            this.d4OutTB.Name = "d4OutTB";
            this.d4OutTB.Size = new System.Drawing.Size(80, 20);
            this.d4OutTB.TabIndex = 24;
            this.d4OutTB.Text = "0";
            // 
            // d6OutTB
            // 
            this.d6OutTB.Enabled = false;
            this.d6OutTB.Location = new System.Drawing.Point(356, 124);
            this.d6OutTB.Name = "d6OutTB";
            this.d6OutTB.Size = new System.Drawing.Size(80, 20);
            this.d6OutTB.TabIndex = 23;
            this.d6OutTB.Text = "0";
            // 
            // d8OutTB
            // 
            this.d8OutTB.Enabled = false;
            this.d8OutTB.Location = new System.Drawing.Point(270, 124);
            this.d8OutTB.Name = "d8OutTB";
            this.d8OutTB.Size = new System.Drawing.Size(80, 20);
            this.d8OutTB.TabIndex = 22;
            this.d8OutTB.Text = "0";
            // 
            // d10OutTB
            // 
            this.d10OutTB.Enabled = false;
            this.d10OutTB.Location = new System.Drawing.Point(184, 124);
            this.d10OutTB.Name = "d10OutTB";
            this.d10OutTB.Size = new System.Drawing.Size(80, 20);
            this.d10OutTB.TabIndex = 21;
            this.d10OutTB.Text = "0";
            // 
            // d12OutTB
            // 
            this.d12OutTB.Enabled = false;
            this.d12OutTB.Location = new System.Drawing.Point(98, 124);
            this.d12OutTB.Name = "d12OutTB";
            this.d12OutTB.Size = new System.Drawing.Size(80, 20);
            this.d12OutTB.TabIndex = 20;
            this.d12OutTB.Text = "0";
            // 
            // d20OutTB
            // 
            this.d20OutTB.Enabled = false;
            this.d20OutTB.Location = new System.Drawing.Point(12, 124);
            this.d20OutTB.Name = "d20OutTB";
            this.d20OutTB.Size = new System.Drawing.Size(80, 20);
            this.d20OutTB.TabIndex = 19;
            this.d20OutTB.Text = "0";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(58, 165);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(40, 13);
            this.bonusLabel.TabIndex = 27;
            this.bonusLabel.Text = "Bonus:";
            // 
            // bonusTB
            // 
            this.bonusTB.Location = new System.Drawing.Point(98, 162);
            this.bonusTB.Name = "bonusTB";
            this.bonusTB.Size = new System.Drawing.Size(80, 20);
            this.bonusTB.TabIndex = 26;
            this.bonusTB.Text = "0";
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 195);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.bonusTB);
            this.Controls.Add(this.d100OutTB);
            this.Controls.Add(this.d4OutTB);
            this.Controls.Add(this.d6OutTB);
            this.Controls.Add(this.d8OutTB);
            this.Controls.Add(this.d10OutTB);
            this.Controls.Add(this.d12OutTB);
            this.Controls.Add(this.d20OutTB);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.d100TB);
            this.Controls.Add(this.d4TB);
            this.Controls.Add(this.d6TB);
            this.Controls.Add(this.d8TB);
            this.Controls.Add(this.d10TB);
            this.Controls.Add(this.d12TB);
            this.Controls.Add(this.d20TB);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.d12PB);
            this.Controls.Add(this.d10PB);
            this.Controls.Add(this.d8PB);
            this.Controls.Add(this.d6PB);
            this.Controls.Add(this.d4PB);
            this.Controls.Add(this.d100PB);
            this.Controls.Add(this.d20PB);
            this.Name = "DiceForm";
            this.Text = "Dice Form";
            this.Load += new System.EventHandler(this.DiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d20PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox d20PB;
        private System.Windows.Forms.PictureBox d100PB;
        private System.Windows.Forms.PictureBox d4PB;
        private System.Windows.Forms.PictureBox d6PB;
        private System.Windows.Forms.PictureBox d8PB;
        private System.Windows.Forms.PictureBox d10PB;
        private System.Windows.Forms.PictureBox d12PB;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox d20TB;
        private System.Windows.Forms.TextBox d12TB;
        private System.Windows.Forms.TextBox d10TB;
        private System.Windows.Forms.TextBox d8TB;
        private System.Windows.Forms.TextBox d6TB;
        private System.Windows.Forms.TextBox d4TB;
        private System.Windows.Forms.TextBox d100TB;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox d100OutTB;
        private System.Windows.Forms.TextBox d4OutTB;
        private System.Windows.Forms.TextBox d6OutTB;
        private System.Windows.Forms.TextBox d8OutTB;
        private System.Windows.Forms.TextBox d10OutTB;
        private System.Windows.Forms.TextBox d12OutTB;
        private System.Windows.Forms.TextBox d20OutTB;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.TextBox bonusTB;
    }
}
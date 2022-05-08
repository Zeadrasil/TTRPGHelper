using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTRPG_Helper
{
    public partial class DiceForm : Form
    {
        public DiceForm()
        {
            InitializeComponent();
        }

        private void DiceForm_Load(object sender, EventArgs e)
        {

        }

        private int roll20(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 21); // creates a number between 1 and 20
                    total = total + nRoll;
                    times = times - 1;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll12(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 13); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll10(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 11); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll8(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 9); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll6(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 7); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll4(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 5); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private int roll100(string count)
        {
            int total = 0;
            try
            {
                int times = Int32.Parse(count);
                while (times != 0)
                {
                    Random rnd = new Random();
                    int nRoll = rnd.Next(1, 101); // creates a number between 1 and 20
                    total = total + nRoll;
                    times--;
                }
                return total;
            }
            catch
            {
                MessageBox.Show("Could not roll please try once more");
                return total;
            }
        }

        private void d20PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d20TB.Text) + 1;
            d20TB.Text = "" + total;
        }

        private void d12PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d12TB.Text) + 1;
            d12TB.Text = "" + total;
        }

        private void d10PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d10TB.Text) + 1;
            d10TB.Text = "" + total;
        }

        private void d8PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d8TB.Text) + 1;
            d8TB.Text = "" + total;
        }

        private void d6PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d6TB.Text) + 1;
            d6TB.Text = "" + total;
        }

        private void d4PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d4TB.Text) + 1;
            d4TB.Text = "" + total;
        }

        private void d100PB_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(d100TB.Text) + 1;
            d100TB.Text = "" + total;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                d20TB.Text = "0";
                d12TB.Text = "0";
                d10TB.Text = "0";
                d8TB.Text = "0";
                d6TB.Text = "0";
                d4TB.Text = "0";
                d100TB.Text = "0";

                d20OutTB.Text = "0";
                d12OutTB.Text = "0";
                d10OutTB.Text = "0";
                d8OutTB.Text = "0";
                d6OutTB.Text = "0";
                d4OutTB.Text = "0";
                d100OutTB.Text = "0";

                totalTB.Text = "";
            }
            catch
            {
                MessageBox.Show("Could not clear dice information");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string totalAll()
        {
            try
            {
                int cal = Int32.Parse(d20OutTB.Text) + Int32.Parse(d12OutTB.Text) + Int32.Parse(d10OutTB.Text) + Int32.Parse(d8OutTB.Text) + Int32.Parse(d6OutTB.Text) + Int32.Parse(d4OutTB.Text) + Int32.Parse(d100OutTB.Text);

                string total = "" + cal;
                return total;
            }
            catch
            {
                int total2 = 0;
                MessageBox.Show("Please Select Die to roll!");
                return "" + total2;
            }
            
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (d20TB.Text != "0")
                {
                    int total = roll20(d20TB.Text);
                    d20OutTB.Text = "" + total;
                }
                if (d12TB.Text != "0")
                {
                    int total = roll12(d12TB.Text);
                    d12OutTB.Text = "" + total;
                }
                if (d10TB.Text != "0")
                {
                    int total = roll10(d10TB.Text);
                    d10OutTB.Text = "" + total;
                }
                if (d8TB.Text != "0")
                {
                    int total = roll8(d8TB.Text);
                    d8OutTB.Text = "" + total;
                }
                if (d6TB.Text != "0")
                {
                    int total = roll6(d6TB.Text);
                    d6OutTB.Text = "" + total;
                }
                if (d4TB.Text != "0")
                {
                    int total = roll4(d4TB.Text);
                    d4OutTB.Text = "" + total;
                }
                if (d100TB.Text != "0")
                {
                    int total = roll100(d100TB.Text);
                    d100OutTB.Text = "" + total;
                }
                totalTB.Text = totalAll();
            }
            catch
            {
                MessageBox.Show("Unable to roll nothing. Please click what you wish to roll");
            }
        }
    }
}

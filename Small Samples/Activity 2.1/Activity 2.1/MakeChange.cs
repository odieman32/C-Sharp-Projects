using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2._1
{
    public partial class MakeChange : Form
    {
        public MakeChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries input then throws exception if wrong
            if (int.TryParse(textBox1.Text, out int totalDollars))
            {
                // Calculate the number of twenties, tens, fives, and ones
                int twenties = totalDollars / 20;
                totalDollars %= 20;

                int tens = totalDollars / 10;
                totalDollars %= 10;

                int fives = totalDollars / 5;
                totalDollars %= 5;

                int ones = totalDollars;

                //Output
                label2.Text = $"Twenties: {twenties}\n" +
                                 $"Tens: {tens}\n" +
                                 $"Fives: {fives}\n" +
                                 $"Ones: {ones}";
            }
            else
            {
                //Exeption Handling
                label2.Text = "Please enter a valid number of dollars.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4._1_Detterman
{
    public partial class GuessingGame : Form
    {
        private int randomNumber;
        public GuessingGame()
        {
            InitializeComponent();
            //Generates random number when form loads
            GenerateRandomNumber();
        }
        private void GenerateRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 11); // Generates a number between 1 and 10
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Try to parse the user's input as a number
            if (int.TryParse(textBox1.Text, out int userGuess))
            {
                //Check if the guess is too high, too low, or correct
                if (userGuess < randomNumber)
                {
                    label2.Text = $"Too low! The random number was {randomNumber}. Try again.";
                    label2.ForeColor = System.Drawing.Color.Red;
                }
                else if (userGuess > randomNumber)
                {
                    label2.Text = $"Too high! The random number was {randomNumber}. Try again.";
                    label2.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label2.Text = $"Correct! The random number was {randomNumber}. Well done!";
                    label2.ForeColor = System.Drawing.Color.Green;
                }

                // Generate a new random number for the next round
                GenerateRandomNumber();
            }
            else
            {
                label2.Text = "Please enter a valid number between 1 and 10.";
                label2.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}

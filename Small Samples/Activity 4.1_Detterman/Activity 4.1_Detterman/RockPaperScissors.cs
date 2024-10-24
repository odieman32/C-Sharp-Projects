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
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the user's input (r, p, or s)
            string userChoice = textBox1.Text.ToLower();

            //Validate the user's input
            if (userChoice != "r" && userChoice != "p" && userChoice != "s")
            {
                label2.Text = "Invalid input! Please enter 'r' for Rock, 'p' for Paper, or 's' for Scissors.";
                label2.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //Generate the computer (1 = Rock, 2 = Paper, 3 = Scissors)
            Random random = new Random();
            int computerChoice = random.Next(1, 4); // Random number between 1 and 3

            string computerChoiceStr = ""; // To store the computer's choice as a string
            if (computerChoice == 1)
                computerChoiceStr = "r"; // Rock
            else if (computerChoice == 2)
                computerChoiceStr = "p"; // Paper
            else
                computerChoiceStr = "s"; // Scissors

            //Determine the winner
            string result = DetermineWinner(userChoice, computerChoiceStr);

            //Display the result
            label2.Text = $"Computer chose {ConvertChoiceToString(computerChoiceStr)}.\nYou {result}!";
            label2.ForeColor = System.Drawing.Color.Blue;
        }

        //Method to determine the winner based on user and computer choices
        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
                return "tied"; // It's a tie!

            if ((userChoice == "r" && computerChoice == "s") || // Rock beats Scissors
                (userChoice == "s" && computerChoice == "p") || // Scissors beats Paper
                (userChoice == "p" && computerChoice == "r"))   // Paper beats Rock
            {
                return "won"; // User wins
            }
            else
            {
                return "lost"; // Computer wins
            }
        }

        //Convert 'r', 'p', 's' to full words "Rock", "Paper", or "Scissors"
        private string ConvertChoiceToString(string choice)
        {
            if (choice == "r") return "Rock";
            if (choice == "p") return "Paper";
            return "Scissors";
        }
    }
}

        

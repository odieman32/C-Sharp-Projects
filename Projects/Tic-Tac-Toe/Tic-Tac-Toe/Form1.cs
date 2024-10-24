using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private char[,] board; //2d array for the board
        private bool xTurn; //keep track whose turn (true = x, false = o)
        private int moves; //Track the number of moves
        private int xScore = 0; //score of x player
        private int oScore = 0; //score of o player
        public Form1()
        {
            InitializeComponent();
            ResetGame(); //start new game
        }
        //Initialize or Reset Game
        private void ResetGame()
        {
            board = new char[3, 3]; //reset game board back to 3x3
            xTurn = true; //X starts first
            moves = 0; //Reset move count

            //reset buttons and enable them
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("button"))
                {
                    control.Text = "";
                    control.Enabled = true;
                }
            }
            //Sets label to X's turn
            label1.Text = "X's Turn";
        }
        //event handler for button clicks (X or O)
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //Get the button's position from name (button00)
            int row = int.Parse(btn.Name.Substring(6, 1));
            int col = int.Parse(btn.Name.Substring(7, 1));

            //Place the current player's mark on board (X or O)
            board[row, col] = xTurn ? 'X' : 'O';
            btn.Text = xTurn ? "X" : "O";
            btn.Enabled = false; //disable the button
            moves++; //increase moves by 1 when button clicked

            //Check if game won or tied
            if (CheckForWinner(row, col))
            {
                label1.Text = $"{btn.Text} Wins!";
                UpdateScore(xTurn ? 'X' : 'O'); //Update the score
                EndGame();
            }
            else if (moves == 9) //if all moves are made and no winner, tie
            {
                label1.Text = "It's a Tie!";
                EndGame();
            }
            else
            {
                xTurn = !xTurn; //Switch turns between X and O
                label1.Text = xTurn ? "X's Turn" : "O's Turn";
            }
        }

        //update score based on winner
        private void UpdateScore(char winner)
        {
            if (winner == 'X')
            {
                xScore++;
                label5.Text = $"{xScore}";
            }
            else if (winner == 'O')
            {
                oScore++;
                label6.Text = $"{oScore}";
            }
        }

        //Check if the current move won the game
        private bool CheckForWinner(int row, int col)
        {
            char player = board[row, col];

            //Check current row
            if (board[row, 0] == player && board[row, 1] == player && board[row, 2] == player)
                return true;

            //Check current column
            if (board[0, col] == player && board[1, col] == player && board[2, col] == player)
                return true;

            //Check the diagonals (if players has clicked on diagonal button)
            if (row == col && board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true;

            if (row + col == 2 && board[0, 2] == player && board[1, 1] == player && board[2,0] == player)
                return true;

            return false; //no winner
        }

        //End the game by disabling all buttons
        private void EndGame()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("button"))
                {
                    control.Enabled = false;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void buttonResetScores_Click(object sender, EventArgs e)
        {
            xScore = 0;
            oScore = 0;
            label5.Text = $"{xScore}";
            label6.Text = $"{oScore}";
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        private const decimal CreditLimit = 8000m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to parse the input value as a decimal
            if (decimal.TryParse(textBox1.Text, out decimal purchasePrice))
            {
                //Check if the purchase price exceeds the credit limit
                if (purchasePrice > CreditLimit)
                { //throws error if it exceeds the credit limit
                    label2.Text = "Error: Purchase exceeds the credit limit of $8000.";
                    label2.ForeColor = System.Drawing.Color.Red; // Set text color to red
                }
                else
                { //send approved if it is below
                    label2.Text = "Approved";
                    label2.ForeColor = System.Drawing.Color.Green; // Set text color to green
                }
            }
            else
            {
                //Display error message if the input is invalid (not a number)
                label2.Text = "Error: Please enter a valid purchase price.";
                label2.ForeColor = System.Drawing.Color.Red; // Set text color to red
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

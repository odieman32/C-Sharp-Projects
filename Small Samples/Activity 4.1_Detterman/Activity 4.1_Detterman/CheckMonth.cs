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
    public partial class CheckMonth : Form
    {
        public CheckMonth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to parse the entered value as an integer
            if (int.TryParse(textBox1.Text, out int month))
            {
                //Checks if the month is between 1 and 12
                if (month >= 1 && month <= 12)
                {   //If the number is valid it throws this
                    label2.Text = $"{month} is a valid month.";
                    label2.ForeColor = System.Drawing.Color.Green; //displays green color
                }
                else
                {   //If the number is not valid it throws this
                    label2.Text = "Error: The month must be between 1 and 12.";
                    label2.ForeColor = System.Drawing.Color.Red; //displays red color
                }
            }
            else
            {
                //Display an error if the input is not a number
                label2.Text = "Error: Please enter a valid number for the month.";
                label2.ForeColor = System.Drawing.Color.Red; //displays red color
            }
        }
    }
}

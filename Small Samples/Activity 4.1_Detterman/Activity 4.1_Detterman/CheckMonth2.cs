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
    public partial class CheckMonth2 : Form
    {
        public CheckMonth2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to parse the month and day entered by the user to an int
            if (int.TryParse(textBox1.Text, out int month) && int.TryParse(textBox2.Text, out int day))
            {
                //Check if the month is valid
                if (month < 1 || month > 12)
                {   //Exception if the month is not correct
                    label3.Text = "Error: The month must be between 1 and 12.";
                    label3.ForeColor = System.Drawing.Color.Red; //displays red text
                }
                else
                {
                    //Check if the day is valid based on the month
                    if (IsDayValid(month, day))
                    {   //displays this output if correct
                        label3.Text = $"{month}/{day} is a valid date.";
                        label3.ForeColor = System.Drawing.Color.Green; //displays green text
                    }
                    else
                    {   //exception if day in incorrect
                        label3.Text = $"Error: The day {day} is not valid for month {month}.";
                        label3.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            else
            {   //exception if value is not a number
                // Display an error if either input is not a valid number
                label3.Text = "Error: Please enter valid numbers for both month and day.";
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        //Method to check if the day is valid based on the month
        private bool IsDayValid(int month, int day)
        {
            //Number of days in each month (index 0 is not used)
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //Check for February and leap years
            if (month == 2)
            {
                //Allow up to 29 days for February in a leap year
                if (day <= 29)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Check if the day is valid for the given month
            if (day < 1 || day > daysInMonth[month])
            {
                return false;
            }

            return true;
        }
    }
}
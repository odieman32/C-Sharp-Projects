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
    public partial class MonthNames : Form
    {
        //Enumeration gives a value to the string and increments by 1, so declaring January as 1 will increment for each month after
        enum Month 
        {
            JANUARY = 1,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULY,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER
        }
        public MonthNames()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries input from text box to to see if value is correct 
            if (int.TryParse(textBox1.Text, out int monthNumber))
            {
                //Checks if number is 1 - 12
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    //Convert the integer to the Month Enumeration to display the correct month
                    Month selectedMonth = (Month)monthNumber;
                    label2.Text = $"The month is: {selectedMonth}";
                }
                else
                {
                    //Display error if value is not 1 - 12
                    label2.Text = "Please enter a number between 1 and 12.";
                }
            }
            else
            {
                //Display error if the value is incorrect
                label2.Text = "Please enter a valid number.";
            }
        }
    }
}

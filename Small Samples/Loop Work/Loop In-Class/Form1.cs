using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_In_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Clear list box for new items

            //Try to parse input number into an int
            if (int.TryParse(textBox1.Text, out int number))
            {
                //loop to generate even numbers from 0 up to entered number
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i); //add the even numbers to list box
                    }
                }
            }
            else
            {   //Throws excpetion if parse fails
                MessageBox.Show("Please Enter Valid Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //clear list before displaying items
            //Try parse to turn text box input into int
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number >= 0)
                {   //Variable to store facotrial result
                    int factorial = 1;
                    //copy of original number
                    int tempNum = number;

                    //While loop to determine factorial
                    while (tempNum > 1)
                    {
                        factorial *= tempNum; //Multiplies the input number until it is less than 1
                        tempNum--; //Decreases input number each time
                    }
                    listBox1.Items.Add($"Factorial of {number} is: {factorial}"); //Output

                }
                else
                {   //excpetion for entering a negative number
                    MessageBox.Show("Please enter a non-negative number");
                }
            }
            else
            {   //exception for not entering a number
                MessageBox.Show("Please enter a valid number");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Clear list box when button clicks
            //List of Strings
            List<string> items = new List<string>
            {
                "Apple",
                "Cheese",
                "Beans",
                "Chicken",
                "Honey",
                "Pumpkin",
                "Watermelon",
                "Pear",
                "Apricot",
                "Plum",
            };
            //for loop to count the number of strings
            for (int i = 0; i < items.Count; i++)
            {
                //add each item to the List Box
                listBox1.Items.Add(items[i]);
            }
        }
    }
}

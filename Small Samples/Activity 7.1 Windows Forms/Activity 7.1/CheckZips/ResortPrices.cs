using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckZips
{
    public partial class ResortPrices : Form
    {
        public ResortPrices()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the input from the TextBox
            if (int.TryParse(textBox1.Text, out int numDays) && numDays > 0)
            {
                decimal pricePerNight = 0;

                // Determine the price per night based on the number of days
                if (numDays == 1 || numDays == 2)
                {
                    pricePerNight = 200m;
                }
                else if (numDays == 3 || numDays == 4)
                {
                    pricePerNight = 180m;
                }
                else if (numDays >= 5 && numDays <= 7)
                {
                    pricePerNight = 160m;
                }
                else if (numDays >= 8)
                {
                    pricePerNight = 145m;
                }

                // Calculate the total price
                decimal totalPrice = pricePerNight * numDays;

                // Display the results
                label2.Text = $"Price per night: ${pricePerNight:0.00}";
                label3.Text = $"Total price: ${totalPrice:0.00}";
            }
            else
            {
                label2.Text = "Please enter a valid number of days.";
                label3.Text = string.Empty;
            }
        }
    }
}

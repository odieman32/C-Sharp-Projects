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
    public partial class DeliveryCharges : Form
    {
        // Array to hold delivery area zip codes
        private readonly int[] deliveryZips = { 12345, 54321, 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888 };
        // Parallel array to hold delivery charges for each zip code
        private readonly decimal[] deliveryCharges = { 5.99m, 7.49m, 6.00m, 8.25m, 5.50m, 9.99m, 10.50m, 4.75m, 6.89m, 3.99m };

        public DeliveryCharges()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Get the input zip code from the TextBox
            if (int.TryParse(textBox1.Text, out int zipCode))
            {
                // Find the index of the entered zip code in the array
                int index = Array.IndexOf(deliveryZips, zipCode);

                // Check if the zip code is in the delivery area
                if (index != -1)
                {
                    // Display the corresponding delivery charge
                    label1.Text = $"The delivery charge for {zipCode} is ${deliveryCharges[index]:0.00}.";
                }
                else
                {
                    label1.Text = "Sorry, we do not deliver to this area.";
                }
            }
            else
            {
                label1.Text = "Please enter a valid numeric zip code.";
            }
        }
    }
}

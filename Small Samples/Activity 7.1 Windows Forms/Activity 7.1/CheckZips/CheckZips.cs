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
    public partial class CheckZips : Form
    {
        // Array to hold delivery area zip codes
        private readonly int[] deliveryZips = { 12345, 54321, 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888 };

        public CheckZips()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Get the input zip code from the TextBox
            if (int.TryParse(textBox1.Text, out int zipCode))
            {
                // Check if the zip code is in the delivery area
                if (Array.Exists(deliveryZips, zip => zip == zipCode))
                {
                    label1.Text = "This zip code is within the delivery area.";
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

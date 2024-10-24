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
    public partial class InchesToCentimeters : Form
    {
        public InchesToCentimeters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double inches)) //tries to see if the user put a number in, if not then handle will be thrown
            {
                // Conversion: 1 inch = 2.54 centimeters
                double centimeters = inches * 2.54;
                // Display result
                label2.Text = $"{inches} inches = {centimeters} cm";
            }
            else
            {
                // Handle invalid input
                label2.Text = "Please enter a valid number.";
            }
        }
    }
}

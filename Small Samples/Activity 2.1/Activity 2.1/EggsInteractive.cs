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
    public partial class EggsInteractive : Form
    {
        public EggsInteractive()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int totalEggs = 0;

            //Tries the value of the input and throws exception if wrong
            if (int.TryParse(textBox1.Text, out int eggs1) &&
                int.TryParse(textBox2.Text, out int eggs2) &&
                int.TryParse(textBox3.Text, out int eggs3) &&
                int.TryParse(textBox4.Text, out int eggs4) &&
                int.TryParse(textBox5.Text, out int eggs5))
            {
                //Sum all the eggs
                totalEggs = eggs1 + eggs2 + eggs3 + eggs4 + eggs5;

                //Calculate dozens and remaining eggs
                int dozens = totalEggs / 12;
                int remainderEggs = totalEggs % 12;

                //Output
                label6.Text = $"Total eggs: {totalEggs} ({dozens} dozen and {remainderEggs} eggs)";
            }
            else
            {
                // Handle invalid input
                label6.Text = "Please enter valid integers for all chicken egg counts.";
            }
        }
    }
}

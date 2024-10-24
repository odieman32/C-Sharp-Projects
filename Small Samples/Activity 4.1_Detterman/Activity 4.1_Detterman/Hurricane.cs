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
    public partial class Hurricane : Form
    {
        public Hurricane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to int parse the wind speed input
            if (int.TryParse(textBox1.Text, out int windSpeed))
            {
                //Determine the hurricane category based on wind speed
                if (windSpeed >= 157)
                {
                    label2.Text = "Category 5 Hurricane";
                    label2.ForeColor = System.Drawing.Color.Red; //Display in red
                }
                else if (windSpeed >= 130)
                {
                    label2.Text = "Category 4 Hurricane";
                    label2.ForeColor = System.Drawing.Color.Orange;//display orange
                }
                else if (windSpeed >= 111)
                {
                    label2.Text = "Category 3 Hurricane";
                    label2.ForeColor = System.Drawing.Color.Purple;//display purple
                }
                else if (windSpeed >= 96)
                {
                    label2.Text = "Category 2 Hurricane";
                    label2.ForeColor = System.Drawing.Color.Green;//display green
                }
                else if (windSpeed >= 74)
                {
                    label2.Text = "Category 1 Hurricane";
                    label2.ForeColor = System.Drawing.Color.Blue;//display blue
                }
                else
                {
                    label2.Text = "Not a hurricane";
                    label2.ForeColor = System.Drawing.Color.Gray;//Display in gray for non-hurricane
                }
            }
            else
            {
                //If the input is not a valid number, display an error message
                label2.Text = "Error: Please enter a valid number for wind speed.";
                label2.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}

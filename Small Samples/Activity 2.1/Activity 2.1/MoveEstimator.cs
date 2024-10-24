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
    public partial class MoveEstimator : Form
    {
        public MoveEstimator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries both boxes to see if value is correct. if not it throws exception
            if (double.TryParse(textBox1.Text, out double hours) && double.TryParse(textBox2.Text, out double miles)) 
            {
                //Base rate
                double baseRate = 200;

                //Calculate fee based on hours and miles
                double fee = baseRate + (hours * 150) + (miles * 2);

                //Output
                label3.Text = $"The total moving fee is: ${fee:F2}";
            }
            else
            {
                //Exception Message
                label3.Text = "Please enter valid numbers for hours and miles.";
            }
        }
    }
}

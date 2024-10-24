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
    public partial class TestsInteractive : Form
    {
        public TestsInteractive()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double test1, test2, test3, test4, test5;
            double totalScore, averageScore;

            //Tries to see if value is correct, if not it throws exception
            if (double.TryParse(textBox1.Text, out test1) &&
                double.TryParse(textBox2.Text, out test2) &&
                double.TryParse(textBox3.Text, out test3) &&
                double.TryParse(textBox4.Text, out test4) &&
                double.TryParse(textBox5.Text, out test5))
            {
                //Calculations
                totalScore = test1 + test2 + test3 + test4 + test5;
                averageScore = totalScore / 5;

                //F2 displays in 2 decimal places
                label7.Text = $"The average score is: {averageScore:F2}";
            }
            else
            {
                //Exception Handling
                label7.Text = "Please enter valid numeric values for all test scores.";
            }
        }
    }
}

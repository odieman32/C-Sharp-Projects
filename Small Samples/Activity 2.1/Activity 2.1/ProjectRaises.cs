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
    public partial class ProjectRaises : Form
    {
        public ProjectRaises()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input
            if (double.TryParse(textBox1.Text, out double currentSalary)) //tries to see if the input is the correct value, if not exception is thrown
            {
                // Calculates the salary with a 4% raise
                double newSalary = currentSalary * 1.04;

                // Display the result
                label2.Text = $"Current salary: ${currentSalary:F2}\n" +
                                 $"Next year's salary with 4% raise: ${newSalary:F2}";
            }
            else
            {
                // Handle invalid input
                label2.Text = "Please enter a valid salary amount.";
            }
        }
    }
}

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
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to double parse the GPA and test score inputs
            if (double.TryParse(textBox1.Text, out double gpa) && int.TryParse(textBox2.Text, out int testScore))
            {
                //Check if the student meets the admission requirements
                if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
                {   //This displays if the student meets the requirements
                    label3.Text = "Accept";
                    label3.ForeColor = System.Drawing.Color.Green; // Display the result in green if accepted
                }
                else
                {   //This displays if the student is rejected
                    label3.Text = "Reject";
                    label3.ForeColor = System.Drawing.Color.Red; // Display the result in red if rejected
                }
            }
            else
            {
                //If input values are invalid, display an error message
                label3.Text = "Error: Please enter valid numbers.";
                label3.ForeColor = System.Drawing.Color.Red; // Display the error message in red
            }
        }
    }
}

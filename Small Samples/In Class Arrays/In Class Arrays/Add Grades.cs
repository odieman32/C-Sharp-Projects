using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Class_Arrays
{
    public partial class Add_Grades : Form
    {
        double[] grades = new double[10]; //variable for grades array
        int gradeCount = 0; //variable for the grade count
        public Add_Grades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Try parse the grade entered to store it in array
                if (double.TryParse(textBox1.Text, out double grade))
                {
                    if (grade > 100)
                    {
                        throw new ArgumentOutOfRangeException("grade", "Can not add grades above 100");
                    }
                    //if statement add a grade into the array
                    if (gradeCount < grades.Length)
                    {
                        grades[gradeCount] = grade;
                        gradeCount++;
                        textBox1.Clear();
                        MessageBox.Show("Grade added successfully");
                    }
                    else
                    {
                        //shows if array is full
                        MessageBox.Show("Grade array is full");
                    }
                }
                else
                {
                    //shows if something else is put instead of a number
                    MessageBox.Show("Please enter a valid number");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clears text box
            textBox2.Clear();
            //for loop to display each grade in the array
            for (int i = 0; i < gradeCount; i++)
            {
                //output text for the text box
                textBox2.AppendText($"Grade {i + 1}: {grades[i]}{Environment.NewLine}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creates new array
            grades = new double[10];
            //sets grade count back to 0
            gradeCount = 0;
            //clears text box
            textBox2.Clear();

            MessageBox.Show("Array cleared successfully!");
        }
    }
}

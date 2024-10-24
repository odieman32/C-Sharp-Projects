using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_In_Class_Work
{
    public partial class Calculator : Form
    {   //Variables Declared
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") || (isOperationPerformed))
            {
                textBox2.Clear();
                isOperationPerformed = false;
            }
            Button button = (Button)sender;
            textBox2.Text += button.Text;
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button5.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                if (Double.TryParse(textBox2.Text, out result))
                {
                    isOperationPerformed = true;
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            textBox1.Text = result + " " + operation;
            textBox2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {   //Checks to see if there is already a decimal point
            if (!textBox2.Text.Contains("."))
            {
                textBox2.Text += "."; //Puts the decimal point in text box
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double secondNumber;
            if (!Double.TryParse(textBox2.Text, out secondNumber))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            switch (operation)
            {
                case "+":
                    textBox2.Text = (result + secondNumber).ToString();
                    break;
                case "-":
                    textBox2.Text = (result - secondNumber).ToString();
                    break;
                case "*":
                    textBox2.Text = (result * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        textBox2.Text = (result / secondNumber).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        textBox2.Text = result.ToString();
                    }
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox2.Text);
            textBox1.Text = "";
            operation = "";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = "";
            result = 0;
            operation = "";
            isOperationPerformed = false;
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

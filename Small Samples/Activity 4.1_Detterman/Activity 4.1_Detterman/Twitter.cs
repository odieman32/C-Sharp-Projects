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
    public partial class Twitter : Form
    {
        private const int CharacterLimit = 140;
        public Twitter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the user's message from the textbox
            string message = textBox1.Text;

            //Check if the message length is within the limit
            if (message.Length <= CharacterLimit)
            {   //If text is good this message is displayed
                label2.Text = $"Message is good ({message.Length}/140 characters)";
                label2.ForeColor = System.Drawing.Color.Green; // Display the result in green if valid
            }
            else
            {   //If message is too long this message will display
                label2.Text = $"Message is too long ({message.Length}/140 characters)";
                label2.ForeColor = System.Drawing.Color.Red; // Display the result in red if too long
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }

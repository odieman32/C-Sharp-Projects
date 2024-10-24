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
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }
        private string ConvertToPigLatin(string word)
        {
            // Trim any leading/trailing spaces and convert to lowercase for simplicity
            word = word.Trim().ToLower();

            // If the word starts with a vowel, add "yay" to the end
            if ("aeiou".IndexOf(word[0]) >= 0)
            {
                return word + "yay";
            }
            else
            {
                // Find the index of the first vowel
                int vowelIndex = -1;
                for (int i = 0; i < word.Length; i++)
                {
                    if ("aeiou".IndexOf(word[i]) >= 0)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                // If a vowel is found, move all consonants before the first vowel to the end, and add "ay"
                if (vowelIndex != -1)
                {
                    string consonantCluster = word.Substring(0, vowelIndex);
                    string restOfWord = word.Substring(vowelIndex);
                    return restOfWord + consonantCluster + "ay";
                }
                else
                {
                    // If no vowel is found (which is rare), return the original word
                    return word;
                }
            }
        }
                private void button1_Click(object sender, EventArgs e)
                {
                // Get the input word from the textbox
                string word = textBox1.Text;

                // Check if the input is not empty
                if (!string.IsNullOrEmpty(word))
                {
                    // Convert the word to Pig Latin
                    string pigLatinWord = ConvertToPigLatin(word);

                    // Display the result
                    label2.Text = $"Pig Latin: {pigLatinWord}";
                }
                else
                {
                    // Display a message if the input is empty
                    label2.Text = "Please enter a word.";
                }
            }
        }
    }

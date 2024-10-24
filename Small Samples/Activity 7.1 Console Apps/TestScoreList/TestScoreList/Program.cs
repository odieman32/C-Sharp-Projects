using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoreList
{
    internal class Program
    {
        static void Main()
        {
            const int NUM_SCORES = 8; // Number of test scores
            int[] testScores = new int[NUM_SCORES]; // Array to store test scores

            // Get test scores from the user
            for (int i = 0; i < NUM_SCORES; i++)
            {
                Console.Write($"Enter test score #{i + 1}: ");
                testScores[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the average of the scores
            double average = CalculateAverage(testScores);

            // Display each score and how far it is from the average
            Console.WriteLine("\nTest scores and how far they are from the average:");
            foreach (int score in testScores)
            {
                double difference = score - average;
                Console.WriteLine($"Score: {score}, Difference from average: {difference:F2}");
            }

            Console.ReadLine(); // Keep console window open
        }

        // Method to calculate the average of an array of integers
        static double CalculateAverage(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return (double)sum / scores.Length;
        }
    }
}

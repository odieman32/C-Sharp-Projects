using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturesComparison
{
    internal class Program
    {
        static void Main()
        {
            const int NUM_TEMPS = 5;
            int[] temperatures = new int[NUM_TEMPS];
            bool gettingWarmer = true;
            bool gettingCooler = true;

            // Input temperatures from the user
            for (int i = 0; i < NUM_TEMPS; i++)
            {
                temperatures[i] = GetValidTemperature(i + 1);

                // Compare the current temperature with the previous one, starting from the second temperature
                if (i > 0)
                {
                    if (temperatures[i] <= temperatures[i - 1])
                    {
                        gettingWarmer = false;
                    }
                    if (temperatures[i] >= temperatures[i - 1])
                    {
                        gettingCooler = false;
                    }
                }
            }

            // Display the pattern message
            if (gettingWarmer)
            {
                Console.WriteLine("Getting warmer.");
            }
            else if (gettingCooler)
            {
                Console.WriteLine("Getting cooler.");
            }
            else
            {
                Console.WriteLine("It's a mixed bag.");
            }

            // Display the temperatures
            Console.WriteLine("\nTemperatures entered:");
            foreach (int temp in temperatures)
            {
                Console.Write(temp + " ");
            }

            // Display the average
            double average = CalculateAverage(temperatures);
            Console.WriteLine($"\n\nAverage temperature: {average:F2}°F");

            Console.ReadLine(); // Keep console window open
        }

        // Method to get a valid temperature from the user (between -30 and 130)
        static int GetValidTemperature(int day)
        {
            int temp;
            do
            {
                Console.Write($"Enter temperature for day {day} (-30 to 130°F): ");
                temp = int.Parse(Console.ReadLine());

                if (temp < -30 || temp > 130)
                {
                    Console.WriteLine("Invalid temperature! Please enter a value between -30 and 130.");
                }
            } while (temp < -30 || temp > 130);

            return temp;
        }

        // Method to calculate the average of the temperatures
        static double CalculateAverage(int[] temps)
        {
            int sum = 0;
            foreach (int temp in temps)
            {
                sum += temp;
            }
            return (double)sum / temps.Length;
        }
    }
}

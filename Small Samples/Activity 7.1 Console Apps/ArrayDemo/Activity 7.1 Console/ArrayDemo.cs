using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_7._1_Console
{
    internal class ArrayDemo
    {
        static void Main()
        {
            // Initialize the array with 10 integers
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; // Example values for the array (1 to 10)
            }

            // Variable to store the user's menu choice
            int choice;

            do
            {
                // Display menu options
                Console.WriteLine("\nArray Demo Menu:");
                Console.WriteLine("1. View the list from first to last position");
                Console.WriteLine("2. View the list from last to first position");
                Console.WriteLine("3. View a specific position");
                Console.WriteLine("4. Quit the application");
                Console.Write("Enter your choice (1-4): ");

                // Read the user's choice
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // View the list from first to last position
                        Console.WriteLine("\nArray from first to last:");
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine(); // New line
                        break;

                    case 2:
                        // View the list from last to first position
                        Console.WriteLine("\nArray from last to first:");
                        for (int i = numbers.Length - 1; i >= 0; i--)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine(); // New line
                        break;

                    case 3:
                        // View a specific position
                        Console.Write("\nEnter the position you want to view (0-9): ");
                        int position = Convert.ToInt32(Console.ReadLine());

                        if (position >= 0 && position < numbers.Length)
                        {
                            Console.WriteLine($"The value at position {position} is: {numbers[position]}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid position! Please enter a value between 0 and 9.");
                        }
                        break;

                    case 4:
                        // Quit the application
                        Console.WriteLine("Exiting the application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }

            } while (choice != 4); // Loop until the user chooses to quit
        }
    }
}

using System;
using System.Collections.Generic;

namespace UserInputExample
{
    class Program
    {
        // Function to get a valid integer input
        static int GetIntegerInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        // Function to get a valid string input
        static string GetStringInput(string prompt)
        {
            string result;
            while (true)
            {
                Console.WriteLine(prompt);
                result = Console.ReadLine();
                if (!string.IsNullOrEmpty(result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
            }
        }

        // Function to get a valid choice from the menu
        static int GetMenuChoice(int maxChoice)
        {
            int choice;
            while (true)
            {
                choice = GetIntegerInput($"Please choose an option (1-{maxChoice}):");
                if (choice >= 1 && choice <= maxChoice)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine($"Invalid choice. Please choose a number between 1 and {maxChoice}.");
                }
            }
        }

        // Function to display the menu
        static void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter your name");
            Console.WriteLine("2. Enter your age");
            Console.WriteLine("3. Enter your favorite color");
            Console.WriteLine("4. Calculate your birth year");
            Console.WriteLine("5. Exit");
        }

        static void Main(string[] args)
        {
            string userName = string.Empty;
            int userAge = 0;
            string favoriteColor = string.Empty;

            bool running = true;
            while (running)
            {
                DisplayMenu();
                int choice = GetMenuChoice(5);

                switch (choice)
                {
                    case 1:
                        userName = GetStringInput("Please enter your name:");
                        Console.WriteLine($"Hello, {userName}!");
                        break;
                    case 2:
                        userAge = GetIntegerInput("Please enter your age:");
                        Console.WriteLine($"You are {userAge} years old.");
                        break;
                    case 3:
                        favoriteColor = GetStringInput("Please enter your favorite color:");
                        Console.WriteLine($"Your favorite color is {favoriteColor}.");
                        break;
                    case 4:
                        if (userAge > 0)
                        {
                            int birthYear = DateTime.Now.Year - userAge;
                            Console.WriteLine($"You were born in {birthYear}.");
                        }
                        else
                        {
                            Console.WriteLine("Please enter your age first.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu.");
                        break;
                }

                // Ask if the user wants to continue
                if (running)
                {
                    string continueChoice = GetStringInput("Do you want to continue? (yes/no):").ToLower();
                    if (continueChoice != "yes")
                    {
                        running = false;
                        Console.WriteLine("Exiting the program...");
                    }
                }
            }
        }
    }
}
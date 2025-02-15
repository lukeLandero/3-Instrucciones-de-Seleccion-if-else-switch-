using System;

class Program
{
    static void Main()
    {
        // Asks the user for a number
        Console.Write("Enter a number: ");

        // Reads the entered number and convert it to an integer
        string input = Console.ReadLine();

        // Trys to convert the string to an integer
        if (int.TryParse(input, out int number))
        {
            // Determines if the number is positive, negative, or zero using if-else
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            // Error message if the input is not a valid number
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        // Asks the user for a number between 1 and 7 to represent a day of the week
        Console.Write("Enter a number (1-7) to represent a day of the week: ");

        // Reads the user's input
        string input = Console.ReadLine();

        // Trys to convert the input to an integer
        if (int.TryParse(input, out int day))
        {
            // Uses switch to determine the day name
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    // Error message if the number is not within the allowed range
                    Console.WriteLine("Error: Please enter a number between 1 and 7.");
                    break;
            }
        }
        else
        {
            // Error message if the input is not a valid number
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}
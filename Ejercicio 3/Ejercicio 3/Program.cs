using System;

class Program
{
    static void Main()
    {
        // Asks the user for three numbers
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        // Determines which is the largest using if and else statements
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine($"The largest number is: {num1}");
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine($"The largest number is: {num2}");
        }
        else
        {
            Console.WriteLine($"The largest number is: {num3}");
        }
    }
}
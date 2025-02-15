using System;

class Program
{
    static void Main()
    {
        // Asks for the student's numeric grade
        Console.Write("Enter the student's numeric grade (0-100) and I'll provide you with the letter grade!: ");
        int grade = int.Parse(Console.ReadLine());

        // Uses a switch to determine the letter grade
        switch (grade)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("The grade is A");
                break;
            case int n when (n >= 80 && n < 90):
                Console.WriteLine("The grade is B");
                break;
            case int n when (n >= 70 && n < 80):
                Console.WriteLine("The grade is C");
                break;
            case int n when (n >= 60 && n < 70):
                Console.WriteLine("The grade is D");
                break;
            case int n when (n >= 0 && n < 60):
                Console.WriteLine("The grade is F");
                break;
            default:
                Console.WriteLine("Error: The entered grade is invalid.");
                break;
        }
    }
}
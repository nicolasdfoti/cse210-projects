using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int favoriteNumber = Console.ReadLine();

            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number
        }

        static string DisplayResult(string firstName, int squared)
        {
            Console.WriteLine($"{firstName}, the square of your number is {squared}");
        }
}
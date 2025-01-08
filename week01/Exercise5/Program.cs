using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);

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
            string number = Console.ReadLine();
            int favoriteNumber = int.Parse(number);

            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;

            return squared;
        }

        static void DisplayResult(string firstName, int squared)
        {
            Console.WriteLine($"{firstName}, the square of your number is {squared}");
        }
}
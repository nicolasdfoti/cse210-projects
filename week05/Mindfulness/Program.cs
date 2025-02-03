using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Choose one of the following: ");
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity.");
        Console.WriteLine("2. Reflecting Activity.");
        Console.WriteLine("3. Listing Activity.");

        string option = Console.ReadLine();

        while (option != "quit".ToLower()) {

            if (option == "1") {

            }

            else if (option == "2") {

            }

            else if (option == "3") {

            }

            else {
                Console.WriteLine("Please, choose a valid answer in numbers");
            }

        }

        Console.WriteLine("Thanks! Have a great day!");

    }
}
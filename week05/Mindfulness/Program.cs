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
        Console.WriteLine();
        Console.Write("Enter your option here: ");

        string option = Console.ReadLine();
        Console.WriteLine();

        while (option != "quit".ToLower()) {

            if (option == "1") {

                BreathingActivity activity1 = new BreathingActivity(30);
                activity1.Run();
                break;

            }

            else if (option == "2") {
                ReflectingActivity activity2 = new ReflectingActivity();
                // activity2.Run();

            }

            else if (option == "3") {
                ListingActivity activity3 = new ListingActivity();
                // activity3.Run();

            }

            else {
                Console.WriteLine("Please, choose a valid answer in numbers");
            }

        }

        Console.WriteLine("Thanks! Have a great day!");

    }
}
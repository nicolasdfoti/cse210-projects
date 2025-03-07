using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        string option = "";

        while (option != "quit".ToLower()) {

            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose one of the following: ");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity.");
            Console.WriteLine("2. Reflecting Activity.");
            Console.WriteLine("3. Listing Activity.");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine();
            Console.Write("Enter your option here, or write QUIT to exit: ");

            option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1") {

                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();

            }

            else if (option == "2") {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();

            }

            else if (option == "3") {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();

            }

            else if (option == "4") {
                VisualizationActivity activity4 = new VisualizationActivity();
                activity4.Run();

            }

            else if (option != "1" && option != "2" && option != "3" && option != "4" && option != "quit".ToLower()) {
                Console.WriteLine("Please, choose a valid answer in numbers");
            }

            Console.WriteLine();

        }

        Console.WriteLine("Thanks! Have a great day!");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        string answer = "";

        while (answer != "5") {
            Console.WriteLine("1. Add event");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
        }

        if (answer == "1") {

            Entry entry = new Entry();

            entry.DisplayEntry();

        }

        else if (answer == "2") {
            
            DisplayEntry();

        }

        else if (answer == "3") {

        }

        else if (answer == "4") {

        }

        else if (answer == "5") {
            Console.WriteLine("Thanks for using the Journal App! Goodbye!");
        }

    }
}
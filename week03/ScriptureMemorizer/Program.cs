using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();

        Reference reference = new Reference("Joshua", 1, 9 );

        string text = "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.";

        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "quit") {

            if (choice == "") {

                scripture.HideRandomWords(3);

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden()) {
                    break;
                }

                Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
                choice = Console.ReadLine();

            }
        }

        Console.WriteLine("Thanks! Goodbye!");
    }
}
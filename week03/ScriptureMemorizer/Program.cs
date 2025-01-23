using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();

        Reference reference = new Reference("Joshua", 1, 9);
        reference.GetDisplayText();

        Scripture scripture = new Scripture();
        scripture.DisplayScripture();
        string text = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "quit") {

            if (choice == "") {
            Word word = new Word(text);
            word.GetDisplayText();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
            choice = Console.ReadLine();
            }
        }

        Console.WriteLine("Thanks! Goodbye!");
    }
}
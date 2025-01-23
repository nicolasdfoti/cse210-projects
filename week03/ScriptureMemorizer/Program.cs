using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();

        Reference reference = new Reference("Joshua", 1, 9);
        reference.GetDisplayText();

        Scripture2 scripture = new Scripture2();
        scripture.DisplayScripture();
        Console.WriteLine();

        Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "quit") {

            foreach (letter in scripture)

            if (choice == "") {
            Word word = new Word();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
            choice = Console.ReadLine();
            }
        }

        Console.WriteLine("Thanks! Goodbye!");
    }
}
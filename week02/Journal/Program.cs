using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();
        Menu menu = new Menu();

        string answer = "";

        while (answer != "5") {
            
            menu.DisplayMenu();
            answer = Console.ReadLine();

            if (answer == "1") {

            string prompt = randomPrompt.GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");

            Console.WriteLine("Add your event here:");
            string memory = Console.ReadLine();

            Console.WriteLine("Add the date here:");
            string date = Console.ReadLine();
            
            Entry entry = new Entry();
            entry._prompt = prompt;
            entry._memory = memory;
            entry._date = date;

            entry.DisplayEntry();
            journal.AddEvent(entry);
        
            }

            else if (answer == "2") {

                journal.DisplayJournal();

            }

            else if (answer == "3") {

            }

            else if (answer == "4") {

            }

        }

        Console.WriteLine("Thanks for using the Journal App! Goodbye!");
    }
 
}
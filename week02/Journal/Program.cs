using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Menu menu = new Menu();
        Journal journal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();

        string answer = "";

        while (answer != "5") {
            
            menu.DisplayMenu();
            answer = Console.ReadLine();

            if (answer == "1") {

            string prompt = randomPrompt.GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");

            Console.Write("Add your event here: ");
            string memory = Console.ReadLine();

            DateTime currentTime = DateTime.Now;
            string date = currentTime.ToShortDateString();
            
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

                Console.Write("Add the file's name: ");
                string fileName = Console.ReadLine();
                journal.saveToFile(fileName);
                Console.WriteLine($"Entry saved to {fileName}");
                
            }

            else if (answer == "4") {

            }

        }

        Console.WriteLine("Thanks for using the Journal App! Goodbye!");
    }
 
}
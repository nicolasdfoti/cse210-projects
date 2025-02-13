using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.Clear();

        GoalsManager manager = new GoalsManager();
        manager.Start();
    }
}
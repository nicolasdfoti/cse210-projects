using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int randomNumber = 6;
        int answer = 0; 

        while (answer != randomNumber)
        {
            Console.Write("What is your guess? ");
            string choice = Console.ReadLine();
            answer = int.Parse(choice);
        } 

        Console.WriteLine($"Congrats! {randomNumber} was the correct answer!");

    }
}
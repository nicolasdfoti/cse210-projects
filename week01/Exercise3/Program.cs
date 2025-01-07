using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int randomNumber = 6

        do
        {
            Console.WriteLine("What is your guess? ");
            string answer = Console.ReadLine();
            int answer = int.Parse(answer);
        } while (answer != randomNumber);

        if (answer == randomNumber)
            {
                Console.WriteLine($"Congrats! {randomNumber} was the correct answer!")
            }

    }
}
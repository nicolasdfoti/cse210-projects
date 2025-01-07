using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 101);
        int answer = 0; 

        while (answer != randomNumber)
        {
            Console.Write("What is your guess? ");
            string choice = Console.ReadLine();
            answer = int.Parse(choice);

            if (answer > randomNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (answer < randomNumber)
            {
                Console.WriteLine("Higher");
            }

        } 

        Console.WriteLine($"Congrats! {randomNumber} was the correct answer!");

    }
}
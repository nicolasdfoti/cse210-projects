using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string keepPlaying = "yes";

        while (keepPlaying == "yes")

        {

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(0, 101);

            int guesses = 0;
            int answer = 0; 

            while (answer != randomNumber)
            {
                guesses++;
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

                else
                {
                    Console.WriteLine("Please, enter a valid number.")
                }

            } 

            Console.WriteLine($"Congrats! {randomNumber} was the correct answer! You guessed {guesses} times");

            Console.WriteLine("Do you want to keep playing? ");
            keepPlaying = Console.ReadLine();
        }

    }
}
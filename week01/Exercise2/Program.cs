using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage? ");
        string gradeAnswer = Console.ReadLine();
        int grade = int.Parse(gradeAnswer);

        if (grade >= 90)
            {
                Console.WriteLine("You've got an A");
            }

        else if (grade > 80 && grade < 90)
            {
                Console.WriteLine("You've got a B.");
            }

        else if (grade > 70 && grade < 80)
            {
                Console.WriteLine("You've got a C.");
            }

        else if (grade > 60 && grade <= 70)
            {
                Console.WriteLine("You've got a D.");
            }
        
        else if (grade < 60)
            {
                Console.WriteLine("You've got an F.");
            }

        if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course");
            }
        
        else
            {
                Console.WriteLine("Sorry, try again next semester!");
            }

    }
}
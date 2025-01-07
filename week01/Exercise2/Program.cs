using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage? ");
        string gradeAnswer = Console.ReadLine();
        int grade = int.Parse(gradeAnswer);

        string letter = "A";

        if (grade >= 90)
            {
                letter = "A";
            }

        else if (grade > 80 && grade < 90)
            {
                letter = "B";
            }

        else if (grade > 70 && grade < 80)
            {
                letter = "C";
            }

        else if (grade > 60 && grade <= 70)
            {
                letter = "D";
            }
        
        else if (grade < 60)
            {
                letter = "F";
            }

        Console.WriteLine($"You've got an {letter}.");

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
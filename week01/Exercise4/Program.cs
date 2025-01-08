using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = sum / (float)numbers.Count;

        Console.WriteLine($"The SUM is up to {sum}");
        Console.WriteLine($"The AVERAGE is up to {average}");

    }
}
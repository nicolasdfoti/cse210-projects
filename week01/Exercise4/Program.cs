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
        float average = 0;
        int max = 0;
        int min = 1000000;

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

            if (num > max)
            {
                max = num;
            }

            if (num > 0 && num < min)
            {
                min = num;
            }
        }

        average = sum / (float)numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The SUM is up to {sum}");
        Console.WriteLine($"The AVERAGE is up to {average}");
        Console.WriteLine($"The MAXIMUM is {max}");
        Console.WriteLine($"The MINIMUM is {min}");
        
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
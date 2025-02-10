using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        Square square = new Square(4, "red");
        Console.WriteLine($"The square has an area of {square.GetArea()} and it's {square.GetColor()}");

        Rectangle rectangle = new Rectangle(30, 20, "green");
        Console.WriteLine($"The rectangle has an area of {rectangle.GetArea()} and it's {rectangle.GetColor()}");

        Circle circle = new Circle(10, "brown");
        Console.WriteLine($"The circle has an area of {circle.GetArea()} and it's {circle.GetColor()}");
    }
}
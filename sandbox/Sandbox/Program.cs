using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Player player = new Player();

        Console.Write("Which player are you entering? ");
        player._name = Console.ReadLine();

        Console.Write("Enter the surname: ");
        player._surname = Console.ReadLine();

        Console.Write("Enter the team: ");
        player._team = Console.ReadLine();

        player.Presentation();
    }

    public class Player
    {
        public string _name = "";
        public string _surname = "";
        public string _team = "";

        public void Presentation()
        {
        Console.WriteLine($"{_name}, {_surname}, {_team}");
        }


    }

    
}
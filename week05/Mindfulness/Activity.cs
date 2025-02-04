public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
    }

    public void GetTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thanks for using the {_name}!");
    }

    public void ShowSpinner(int seconds)
    {

        List<char> _array = new List<char> {'/', '-', '\\', '|'};

        while (seconds > 0)
        {
            seconds--;

            foreach (char item in _array) {
                Console.Write(item);
                Console.Write("\b \b");
                Thread.Sleep(500);
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        
        while (seconds > 0)
        {
            Console.WriteLine($"{seconds}");
            seconds--;
            Thread.Sleep(1000);
        }
        
    }

}
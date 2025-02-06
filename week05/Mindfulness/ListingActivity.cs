public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0) {
        _count = 0;
    }

    Random random = new Random();

    public string SelectRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        string question = _prompts[index];
        return question;
    }

    public int GetCount()
    {
        return _count;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetDescription());

        ShowSpinner(5);
        Console.WriteLine();

        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Console.WriteLine("Get ready... ");
        ShowSpinner(3);

        List<string> _items = new List<string>();
    
        Console.WriteLine("List as many responses as you can to the following prompt: ");

        Console.WriteLine(SelectRandomPrompt());
        Console.WriteLine();

        Console.Write("You may begin in: ");

        ShowCountDown(5);

        while (DateTime.Now < futureTime) 
        {
            Console.Write("- ");
            string answer = Console.ReadLine();
            _items.Add(answer);
            _count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You've listed {GetCount()} items! Good job!");

        DisplayEndingMessage();

        ShowSpinner(3);
        
        Console.Clear();

    }
        
}
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
    }

    public string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string question = _prompts[index];
        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();

        ShowSpinner(5);
        Console.WriteLine();

        List<string> _items = new List<string>();

        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine(SelectRandomPrompt());
        Console.WriteLine();

        Console.WriteLine("Think about that prompt... Take a few seconds!");

        DisplayEndingMessage();
    }


}
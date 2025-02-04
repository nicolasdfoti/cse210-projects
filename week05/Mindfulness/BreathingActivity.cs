class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        ShowSpinner(3);

        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        Console.WriteLine();

        DisplayEndingMessage();

        ShowSpinner(3);
        
        Console.Clear();

    }
}
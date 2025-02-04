class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

        GetTime();
        int duration = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Console.WriteLine("Let's get started...  ");
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

    }
}
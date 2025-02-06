public class VisualizationActivity : Activity
{

    private List<string> _prompts = new List<string>() {
        "Imagine yourself in a beautiful place...",
        "Imagine yourself with a person you love...", 
        "Imagine yourself walking barefoot on soft, warm sand...",
        "Imagine the gentle sound of waves crashing on the shore...",
        "Imagine yourself in a peaceful forest, surrounded by tall trees...",
        "Imagine a golden sunset painting the sky with warm colors...",
        "Imagine yourself lying on a soft, grassy hill, looking at the stars...",
        "Imagine the scent of fresh flowers filling the air around you...",
        "Imagine the warmth of the sun gently touching your skin...",
        "Imagine yourself floating on calm water, feeling weightless...",
        "Imagine hearing the laughter of a loved one nearby...",
        "Imagine a cozy fireplace crackling as you sip a warm drink...",
        "Imagine yourself in a quiet library, surrounded by the scent of old books...",
        "Imagine the sound of birds singing in the early morning...",
        "Imagine yourself sitting on a swing, feeling the wind rush past you...",
        "Imagine a gentle rain falling, bringing a fresh, earthy aroma...",
        "Imagine yourself wrapped in a warm blanket, feeling completely safe..."
    };
    public VisualizationActivity() : base("Visualization Activity", "This activity will help you relax while you can imagine, visualize and feel.", 0)
    {}

    public string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

        Console.Write("Let's get started! ");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine();

        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Console.WriteLine("Take a deep breath...");
        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(SelectRandomPrompt());
            ShowCountDown(3);
        }

        DisplayEndingMessage();

        ShowSpinner(3);
        
        Console.Clear();

    }
}
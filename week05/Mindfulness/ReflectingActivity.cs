public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "How did this experience shape your perspective on similar situations?",
        "How did you feel when it was complete?",
        "What advice would you give to someone going through a similar experience?",
        "What would you do differently if you could relive this experience?",
        "What made this time different than other times when you were not as successful?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"
    };
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
    }

    public string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string SelectRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

        Console.WriteLine("Let's reflect on the following question:");
        Console.WriteLine($"{SelectRandomPrompt()}");

        ShowSpinner(3);

        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {

            foreach (var question in _questions)
            {
                Console.WriteLine(SelectRandomQuestion());
                Thread.Sleep(1000);
                ShowSpinner(3);

                if (DateTime.Now >= futureTime)
                {
                    break;
                }
            };

        }

        Console.WriteLine();
    }

}
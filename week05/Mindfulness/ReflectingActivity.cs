public class ReflectingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
    }

    public ReflectingActivity(int count, List<string> prompts, int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = count;
        _prompts = prompts;
    }

}
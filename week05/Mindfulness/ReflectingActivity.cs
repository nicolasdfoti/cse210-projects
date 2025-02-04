public class ReflectingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ReflectingActivity()
    {
        _count = 0;
        // _prompts = List<string>;
    }

    public ReflectingActivity(int count, List<string> prompts, int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = count;
        _prompts = prompts;
    }

}
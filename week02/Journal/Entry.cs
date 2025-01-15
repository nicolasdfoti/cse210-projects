public class Entry 
{
    public string _prompt = "";
    public string _memory = "";
    public string _date = "";
    public string _feeling = "";

    public void DisplayEntry() {

        Console.WriteLine($"Prompt: {_prompt} - Memory: {_memory} - Feeling {_feeling} - Date: {_date}");

    }
    
}
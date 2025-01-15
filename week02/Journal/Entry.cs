using System.Diagnostics.Contracts;

public class Entry 
{
    public string _prompt = "";
    public string _memory = "";
    public string _date = "";

    public void DisplayEntry() {

        Console.WriteLine($"Prompt: {_prompt} - Memory: {_memory} - Date: {_date}");
        
    }
    
}
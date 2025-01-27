class Comment 
{
    public string _person;
    public string _text;

    public Comment(string person, string text) {
        _person = person;
        _text = text;
    }

    public void DisplayComment() {
        Console.WriteLine($"Author: {_person}");
        Console.WriteLine($"Comment: {_text}");
    }

}
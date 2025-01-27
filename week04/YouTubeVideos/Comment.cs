class Comment
{
    public string _person;
    public string _comment;

    public Comment(string person, string comment) {
        _person = person;
        _comment = comment;
    }

    public void DisplayComment() {
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine($"Author: {_person}");
    }

}
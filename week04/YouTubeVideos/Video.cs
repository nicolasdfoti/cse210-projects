using System.Net;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();
    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public void NumberOfComments() {
        Console.WriteLine($"Number of comments: {_commentList.Count()}");
    }

    public void DisplayInfo() {

        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");

    }

    public void GetComment() {

        foreach(var comment in _commentList) {
            comment.DisplayComment();
        }

    }

    public void AddComment(Comment comment) {
        _commentList.Add(comment);
    }

}
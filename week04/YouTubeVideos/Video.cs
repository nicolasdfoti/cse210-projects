class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Video: {_title} - Author: {_author} - Length: {_length}");
    }

    public void DisplayComments() {
        
        foreach (var comment in _comments) {
            comment.DisplayComment();
        }

    }

    public void AddComment(string author, string comment) {

        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }

}
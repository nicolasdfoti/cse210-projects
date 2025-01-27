using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        string title = "Messi's best goals";
        string author = "Lionel Messi";
        int length = 600;

        Video video = new Video(author, title, length);

        string person = "Nicolás Foti";
        string comment = "He's certainly the best!";

        video.DisplayInfo();
        video.AddComment(person, comment);
        video.DisplayComment(person, comment);

    }
}
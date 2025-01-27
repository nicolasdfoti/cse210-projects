using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Video 1
        string title = "Messi's best goals";
        string author = "Lionel Messi";
        int length = 600;

        Video video = new Video(author, title, length);
        video.DisplayInfo();

        string person = "Nicolás Foti";
        string comment = "He's certainly the best!";
        video.AddComment(person, comment);

        string person1 = "John Doe";
        string comment1 = "Wow! Brilliant!";
        video.AddComment(person1, comment1);

        video.DisplayComments();
        
        Console.WriteLine();
        Console.WriteLine();

        // Video 2
        string title1 = "Welcome to Argentina!";
        string author1 = "Javier Milei";
        int length1 = 500;

        Video video1 = new Video(title1, author1, length1);
        video1.DisplayInfo();

        string person2 = "Zack Brown";
        string comment2 = "I'd love to go to Argentina";
        video.AddComment(person2, comment2);

        string person3 = "Alice Cooper";
        string comment3 = "Amazing country, beautiful culture!";
        video1.AddComment(person3, comment3);

        video1.DisplayComments();


    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();


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
        video1.AddComment(person2, comment2);

        string person3 = "Alice Cooper";
        string comment3 = "Amazing country, beautiful culture!";
        video1.AddComment(person3, comment3);

        video1.DisplayComments();


        // Video 3
        string title2 = "Top 10 Programming Languages in 2025";
        string author2 = "Tech Guru";
        int length2 = 800;

        Video video2 = new Video(title2, author2, length2);
        video2.DisplayInfo();

        string person4 = "Dev Lover";
        string comment4 = "C# and Python are definitely the best!";
        video2.AddComment(person4, comment4);

        string person5 = "Code Master";
        string comment5 = "JavaScript all the way!";
        video2.AddComment(person5, comment5);

        video2.DisplayComments();

    }
}
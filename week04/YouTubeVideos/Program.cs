using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        // Video 1
        Video firstVideo = new Video("Best Messi Goals", "Lionel Messi", 500);
        videos.Add(firstVideo);

        Comment firstComment = new Comment("Nicolás Foti", "He's certainly the best!");
        firstVideo.AddComment(firstComment);


        // Video 2
        Video secondVideo = new Video("Welcome to Argentina!", "Javier Milei", 500);
        videos.Add(secondVideo);

        Comment fourthComment = new Comment("Zack Brown", "I'd love to go to Argentina");
        secondVideo.AddComment(fourthComment);


        foreach (var video in videos) {
            video.DisplayInfo();
            video.GetComment();
        }

    }
}
























//         // Video 2
//         string title1 = "Welcome to Argentina!";
//         string author1 = "Javier Milei";
//         int length1 = 500;

//         Video video1 = new Video(title1, author1, length1);
//         videos.Add(video1);
//         video1.DisplayInfo();

//         string person4 = "Zack Brown";
//         string comment4 = "I'd love to go to Argentina";
//         video1.AddComment(person4, comment4);

//         string person5 = "Alice Cooper";
//         string comment5 = "Amazing country, beautiful culture!";
//         video1.AddComment(person5, comment5);

//         string person6 = "Sofía Ortega";
//         string comment6 = "I love my country!";
//         video1.AddComment(person6, comment6);

//         video1.GetComment();
//         Console.WriteLine($"Number of Comments: {video1.NumberOfComments()}");

//         Console.WriteLine();
//         Console.WriteLine();


//         // Video 3
//         string title2 = "Top 10 Programming Languages in 2025";
//         string author2 = "Tech Guru";
//         int length2 = 800;

//         Video video2 = new Video(title2, author2, length2);
//         videos.Add(video2);
//         video2.DisplayInfo();

//         string person7 = "Dev Lover";
//         string comment7 = "C# and Python are definitely the best!";
//         video2.AddComment(person7, comment7);

//         string person8 = "Code Master";
//         string comment8 = "JavaScript all the way!";
//         video2.AddComment(person8, comment8);

//         string person9 = "JavaGamer";
//         string comment9 = "Wow! Should I learn to code?";
//         video2.AddComment(person9, comment9);

//         video2.GetComment();
//         Console.WriteLine($"Number of Comments: {video2.NumberOfComments()}");

//         Console.WriteLine();
//         Console.WriteLine();


//         // Video 4
//         string title3 = "The Best Pizza Places in New York";
//         string author3 = "Food Explorer";
//         int length3 = 400;

//         Video video3 = new Video(title3, author3, length3);
//         videos.Add(video3);
//         video3.DisplayInfo();

//         string person10 = "Foodie Lover";
//         string comment10 = "I can't wait to try these places!";
//         video3.AddComment(person10, comment10);

//         string person11 = "Pizza Enthusiast";
//         string comment11 = "This is making me so hungry!";
//         video3.AddComment(person11, comment11);

//         string person12 = "John the Traveler";
//         string comment12 = "I love New York's food scene.";
//         video3.AddComment(person12, comment12);

//         string person13 = "Food Critic";
//         string comment13 = "New York pizza is legendary!";
//         video3.AddComment(person13, comment13);

//         video3.GetComment();
//         Console.WriteLine($"Number of Comments: {video3.NumberOfComments()}");

//     }
// }
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

        Comment secondComment = new Comment("Cristiano Ronaldo", "Wow! Amazing!");
        firstVideo.AddComment(secondComment);

        Comment thirdComment = new Comment("Wayne Rooney", "The best, by far!");
        firstVideo.AddComment(thirdComment);


        // Video 2
        Video secondVideo = new Video("Welcome to Argentina!", "Javier Milei", 500);
        videos.Add(secondVideo);

        Comment fourthComment = new Comment("Zack Brown", "I'd love to go to Argentina");
        secondVideo.AddComment(fourthComment);

        Comment fifthComment = new Comment("Alice Cooper", "Amazing country, beautiful culture!");
        secondVideo.AddComment(fifthComment);

        Comment sixthComment = new Comment("Sofía Ortega", "I love my country!");
        secondVideo.AddComment(sixthComment);


        // Video 3
        Video thirdVideo = new Video("Top 10 Programming Languages in 2025", "Tech Guru", 800);
        videos.Add(thirdVideo);

        Comment seventhComment = new Comment("Dev Lover", "C# and Python are definitely the best!");
        thirdVideo.AddComment(seventhComment);

        Comment eighthComment = new Comment("Code Master", "JavaScript all the way!");
        thirdVideo.AddComment(eighthComment);

        Comment ninethComment = new Comment("JavaGamer", "Wow! Should I learn to code?");
        thirdVideo.AddComment(ninethComment);


        // Video 4
        Video fourthVideo = new Video("The Best Pizza Places in New York", "Food Explorer", 400);
        videos.Add(fourthVideo);

        Comment tenthComment = new Comment("Foodie Lover", "I can't wait to try these places!");
        fourthVideo.AddComment(tenthComment);

        Comment eleventhComment = new Comment("Pizza Enthusiast", "This is making me so hungry!");
        fourthVideo.AddComment(eleventhComment);

        Comment twelvethComment = new Comment("John the Traveler", "I love New York's food scene.");
        fourthVideo.AddComment(twelvethComment);

        Comment thirteenthComment = new Comment("Food Critic", "New York pizza is legendary!");
        fourthVideo.AddComment(thirteenthComment);


        // Iterating through the list
        foreach (var video in videos) {
            video.DisplayInfo();
            video.GetComment();
            video.NumberOfComments();
            Console.WriteLine();
        }

    }
}
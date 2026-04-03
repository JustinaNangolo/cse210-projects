using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Video 1
        Video video1 = new Video("How to improve programming skills", "Programming Pro", 600);
        video1.AddComment(new Comment("FutureProgrammer", "This is very helpful!"));
        video1.AddComment(new Comment("DeverloperGuru", "Very easy to follow along."));
        video1.AddComment(new Comment("Iamnew", "You rock man!"));
        videoList.Add(video1);

        // Video 2
        Video video2 = new Video("Public Speaking for Beginners", "Speaking Expert", 450);
        video2.AddComment(new Comment("Thatgirl", "I have enjoyed this video."));
        video2.AddComment(new Comment("newUser", "I feel more confident about public speaking now."));
        video2.AddComment(new Comment("Onlineexpert", "I have stage fright, thank you for the tips!"));
        videoList.Add(video2);

        // Video 3
        Video video3 = new Video("Easy Hair Styling", "Beauty Gurus", 1200);
        video3.AddComment(new Comment("Colorful", "Tip #4 is a game changer."));
        video3.AddComment(new Comment("HairLover", "I am going to try this tonight!"));
        video3.AddComment(new Comment("StyleEnthusiast", "Solid advice for beginners falling in love with hair styling."));
        videoList.Add(video3);

        Console.WriteLine("YouTube Video Tracking System");
        Console.WriteLine("\n");

        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();
        }
    }
}
using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to hold all video objects
            List<Video> videos = new List<Video>();

            // --- Video 1 ---
            Video video1 = new Video("C# Object-Oriented Programming Tutorial", "CodeAcademy", 600);
            video1.AddComment(new Comment("Alice", "Great explanation of classes!"));
            video1.AddComment(new Comment("Bob", "This helped me pass my programming assignment."));
            video1.AddComment(new Comment("Charlie", "Can you cover inheritance in the next video?"));
            videos.Add(video1);

            // --- Video 2 ---
            Video video2 = new Video("Top 10 C# Tips and Tricks", "DevTips", 450);
            video2.AddComment(new Comment("David", "Tip #3 blew my mind!"));
            video2.AddComment(new Comment("Eva", "Short, sweet, and to the point. Thanks!"));
            video2.AddComment(new Comment("Frank", "Loved the examples used here."));
            video2.AddComment(new Comment("Grace", "Subscribed!"));
            videos.Add(video2);

            // --- Video 3 ---
            Video video3 = new Video("Building web apps with .NET Core", "TechWithTim", 1200);
            video3.AddComment(new Comment("Hank", "Very detailed walkthrough!"));
            video3.AddComment(new Comment("Ivy", "What version of .NET are you using?"));
            video3.AddComment(new Comment("Jack", "Thanks for keeping it easy to follow."));
            videos.Add(video3);

            // --- Display All Videos and Comments ---
            Console.WriteLine("YOUTUBE VIDEO MONITORING SYSTEM\n");

            foreach (Video video in videos)
            {
                video.DisplayInfo();
            }
        }
    }
}
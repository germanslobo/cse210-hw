using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // Length in seconds
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        // Method to return the total number of comments
        public int GetCommentCount()
        {
            return Comments.Count;
        }

        // Helper method to add a comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Method to display all video details and associated comments
        public void DisplayInfo()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in Comments)
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }

            Console.WriteLine("==================================================\n");
        }
    }
}
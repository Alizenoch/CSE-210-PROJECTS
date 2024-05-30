using System;
using System.Collections.Generic;

namespace YouTubeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create 3-4 videos and add comments
            Video video1 = new Video("Abstraction", "Alison", 480);
            video1.AddComment(new Comment("Miller Enoch", "The video was interesting!"));
            video1.AddComment(new Comment("Ali", "It was good!"));
            video1.AddComment(new Comment("Maggi", "I will watch again."));
            videos.Add(video1);

            Video video2 = new Video("Encapsulation", "Alison", 480);
            video2.AddComment(new Comment("Arnold", "I like it."));
            video2.AddComment(new Comment("Ame", "That was worth my time!"));
            videos.Add(video2);

            Video video3 = new Video("Inheritance", "Alison", 480);
            video3.AddComment(new Comment("Miriam John", "I will share it."));
            video3.AddComment(new Comment("Jack Kyu", "I enjoyed it to the end"));
            video3.AddComment(new Comment("Efi", "Will watch again!"));
            video3.AddComment(new Comment("Jonah Meg", "Fasinating."));
            videos.Add(video3);

            // Iterate through the list of videos and display information
            foreach (var video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length (in seconds): " + video.Length);
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
                }

                Console.WriteLine();
            }
        }
    }
}
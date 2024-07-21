using System;

class Program
{


    static void Main(string[] args)
    {
        // Chat GPT wrote the video titles and comments and whatnot because I didn't want to waste time on that when I could focus on the code more.
        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Yoga for Beginners", "Yoga with Adriene", 900);
        Video video3 = new Video("Learn C# in One Hour", "CodeAcademy", 3600);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can't wait to try this recipe."));
        video1.AddComment(new Comment("Lugi","MAMA MIA MY PASTARONI, OH MARIO WHY IS-A THE WORLD SO CRUEL!!!"));


        video2.AddComment(new Comment("Dave", "Loved this session!"));
        video2.AddComment(new Comment("Eve", "Very relaxing, thank you."));
        video2.AddComment(new Comment("Frank", "Perfect for beginners."));
        video2.AddComment(new Comment("Gottem","First!!!"));


        video3.AddComment(new Comment("Grace", "Excellent tutorial."));
        video3.AddComment(new Comment("Heidi", "Well explained."));
        video3.AddComment(new Comment("Ivan", "Helped me a lot, thanks!"));
        video3.AddComment(new Comment("KissTheCoder","This is the best tutorial I have ever scene. I would die for you."));



        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.VideoLengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }


}

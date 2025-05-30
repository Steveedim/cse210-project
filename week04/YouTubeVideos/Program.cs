using System;

class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Video class tracks title, author, length, and comments
class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthSeconds { get; }  // length in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("How to Bake Bread", "Jane Baker", 600);
        video1.AddComment(new Comment("Stephen", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Andy", "I love baking bread now."));
        video1.AddComment(new Comment("Asian", "Can you show a gluten-free recipe?"));

        var video2 = new Video("Top 10 Travel Destinations 2025", "TravelGuru", 900);
        video2.AddComment(new Comment("Tessa", "I want to visit all these places!"));
        video2.AddComment(new Comment("James", "Nice video, very informative."));
        video2.AddComment(new Comment("Claridge", "Add Bali to the list!"));

        var video3 = new Video("JavaScript Basics for Beginners", "CodeMaster", 1200);
        video3.AddComment(new Comment("George", "Just what I needed, thanks!"));
        video3.AddComment(new Comment("Hanna", "Can you do an advanced tutorial?"));
        video3.AddComment(new Comment("Ian", "Very clear explanations."));

        var videos = new List<Video> { video1, video2, video3 };

        // Display info for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();  // blank line between videos
        }
    }
}

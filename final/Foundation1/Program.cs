
using System;

class Video
{  
    static void Main (string[] args)
    {
        Console.WriteLine("Hello Foundation World!");
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.Comments.Add(new Comment("Commenter 1", "Comment 1"));
        video1.Comments.Add(new Comment("Commenter 2", "Comment 2"));
        video1.Comments.Add(new Comment("Commenter 3", "Comment 3"));
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 240);
        video2.Comments.Add(new Comment("Commenter 4", "Comment 4"));
        video2.Comments.Add(new Comment("Commenter 5", "Comment 5"));
        videos.Add(video2);

        Video video3 = new Video("Title 3", "Author 3", 300);
        video3.Comments.Add(new Comment("Commenter 6", "Comment 6"));
        video3.Comments.Add(new Comment("Commenter 7", "Comment 7"));
        video3.Comments.Add(new Comment("Commenter 8", "Comment 8"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
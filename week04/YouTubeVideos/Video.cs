public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment}");
        }
        Console.WriteLine();
    }

}
using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length; // length in seconds
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Length: {_length / 60}m {_length % 60}s");
        Console.WriteLine($"Number of Comments: {CountComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}: \"{comment.GetText()}\"");
        }

        Console.WriteLine();
    }
}

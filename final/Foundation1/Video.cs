using System;

public class Video
{
    public string _author;
    public string _title;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideoInfo()
    {
    Console.WriteLine($"Video: {_title} by {_author} ({_length} seconds)\n");

    Console.WriteLine($"Number of comments: {_comments.Count}\n");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }

        
    }

    public void AddComment (Comment comment)
    {
        _comments.Add(comment);
    }
}


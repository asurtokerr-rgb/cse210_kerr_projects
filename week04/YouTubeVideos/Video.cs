using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Video
{
    // title, author, and length (in seconds) of the video, comments list

    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();
    public List<Video> _videos = new List<Video>();
    public int CountComments()
    {
        int _count = _comments.Count;
        return _count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments({CountComments()})");

    }

    public void Display()
    {
        Console.WriteLine("");
        foreach (Video v in _videos)
        {
            v.DisplayVideoDetails();
            foreach (Comment c in _comments)
            {
                c.DisplayComments();
            }
        }

    }
}
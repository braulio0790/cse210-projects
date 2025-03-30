using System;
using System.Collections.Generic;

// Video class to store video details and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    //The reason we use an object inside the list, is to ensure we capture the different values we need in each row
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        //Preparing the spaces in the memory to store values
        Title = title;
        Author = author;
        Length = length;
        //We have this list to get rows with multiple values
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
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
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine("-----------------------------");
    }
}
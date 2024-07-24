using System;

public class Comment
{
    public string _name;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"    - {_commentText} | {_name}");
    }
}
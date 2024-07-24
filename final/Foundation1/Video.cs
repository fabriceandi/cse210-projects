using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        int number = _comments.Count;
        return number;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayInfo()
    {
        foreach(Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}
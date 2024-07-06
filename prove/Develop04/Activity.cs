using System;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}.");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string>();
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        int i = 0;
        while(DateTime.Now < end)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for(int m = seconds; m > 0; m--)
        {
            Console.Write(m);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}
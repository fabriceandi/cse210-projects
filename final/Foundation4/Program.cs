using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        List<Activity> activity = new List<Activity>();
        Running running = new Running();
        Cycling cycling = new Cycling();
        Swimming swimming = new Swimming();
        activity.Add(running);
        activity.Add(cycling);
        activity.Add(swimming);
        foreach(Activity a in activity)
        {
            a.GetSummary();
        }
    }
}
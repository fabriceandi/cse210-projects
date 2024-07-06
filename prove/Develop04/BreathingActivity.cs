using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        int duration = GetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        while(DateTime.Now < end)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
    }
}
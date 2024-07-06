using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public int GetCount()
    {
        return _count;
    }
    public void Run()
    {
        int duration = GetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        Console.WriteLine();
        List<string> list = new List<string>();
        while(DateTime.Now < end)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            list = GetListFromUser(userInput);
        }
        Console.WriteLine($"You listed {_count} items!");
    }
    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int option = randomGenerator.Next(_prompts.Count);
        string prompt= _prompts[option];

        Console.WriteLine($"--- {prompt} ---");
    }
    public List<string> GetListFromUser(string line)
    {
        List<string> list = [line];
        _count = _count + 1;

        return list;
    }
}
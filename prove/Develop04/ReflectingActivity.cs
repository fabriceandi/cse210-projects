using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _list = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void Run()
    {
        int duration = GetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");
        string enter = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        while(DateTime.Now < end)
        {
            DisplayQuestions();
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int option = randomGenerator.Next(_prompts.Count);
        string prompt= _prompts[option];

        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int option = randomGenerator.Next(_questions.Count);
        string question = _questions[option];

        return question;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        while(_list.Contains(question))
        {
            question = GetRandomQuestion();
        }
        _list.Add(question);
        if(_list.Count == _questions.Count)
        {
            _list.Clear();
        }
        Console.Write($"> {question} ");
    }
}
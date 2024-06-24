public class PromptGenerator
{
    public List<string> _prompt;
    public string GetRandomGenerator()
    {
        _prompt= new List<string>()
        { 
            "Who was the most interesting person I interacted with today?",
            "What is the thing that brought me joy today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Who in my life am I thankful for?",
            "What have I learned from the scriptures that I read today?",
            "What is one habit I want to start or stop?",
            "What am I grateful for today?",
            "What is something new I learned today?",
            "How did I make someone else’s day better?"
        };
        Random randomGenerator = new Random();
        int option = randomGenerator.Next(_prompt.Count);
        string prompt= _prompt[option];
        
        return prompt; 
    }

}
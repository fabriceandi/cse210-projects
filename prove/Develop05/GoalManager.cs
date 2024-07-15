using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for(int i = 0; i < _goals.Count; i ++)
            {
                string name = _goals[i].GetName();
                Console.WriteLine($"{i + 1}. {name}");
            }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for(int i = 0; i < _goals.Count; i ++)
        {
            string list = _goals[i].GetDetailsString();
            Console.WriteLine($"{i + 1}. {list}");
        }
    }
    public void CreateGoal(int choice)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if(choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if(choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else if(choice == 4)
        {
            NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
            _goals.Add(negativeGoal);
        }
    }
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int option = int.Parse(Console.ReadLine());
        int points = 0;
        Type name = typeof(string);
        for(int i = 0; i < _goals.Count; i ++)
        {
            int j = i + 1;
            if(option == j)
            {
                points = _goals[i].RecordEvent();
                name = _goals[i].GetType();           
            }
        }
        if(name == typeof(NegativeGoal))
        {
            _score = _score - points;
            Console.WriteLine($"You loose {points} points for this bad habit!");
        }
        else
        {
            _score = _score + points;
            string text = "Congratulations!";
            char[] letters = text.ToCharArray(); 
            foreach (char c in letters)
            {             
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine($" You have earned {points} points!");
        }
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {   
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                string list= goal.GetStringRepresentation();
                outputFile.WriteLine(list);
            }
        } 
    }
    public void LoadGoals(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);   
        for(int i = 1; i < lines.Count(); i ++)
        {
            string[] parts = lines[i].Split(",");
            string[] part= parts[0].Split(":");
            string type = part[0];
            string name = part[1];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            if(type == "SimpleGoal")
            {
                bool isComplete = Convert.ToBoolean(parts[3]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                simpleGoal.SetComplete(isComplete);
                _goals.Add(simpleGoal);
            }
            else if(type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if(type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);
                _goals.Add(checklistGoal);
            }
            else if(type == "NegativeGoal")
            {
                bool isComplete = Convert.ToBoolean(parts[3]);
                NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
                negativeGoal.SetComplete(isComplete);
                _goals.Add(negativeGoal);
            }
        }
    }
}
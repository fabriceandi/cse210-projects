using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string isCompleted = " "; 
        if (IsComplete() == true)
        {
            isCompleted = "X";
        }
        string goal = $"[{isCompleted}] {_shortName} ({_description})";

        return goal;
    }
    public abstract string GetStringRepresentation();
}
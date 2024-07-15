using System;

public class NegativeGoal : Goal
{
    private bool _isComplete;

    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        int points = GetPoints();

        return points;
    }
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
        return _isComplete == true;
    }
    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string goal = $"{this.GetType()}:{name},{description},{points},{_isComplete}";

        return goal;
    }
}
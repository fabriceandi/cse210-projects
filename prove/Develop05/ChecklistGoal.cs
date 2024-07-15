using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        int points = GetPoints();
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            points += _bonus;
            return points;
        }
        else
        {
            return points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string name = GetName();
        string description = GetDescription();
        string isCompleted = " ";
        if (IsComplete() == true)
        {
            isCompleted = "X";
        }
        string goal = $"[{isCompleted}] {name} ({description}) -- Currently completed: {_amountCompleted}/{_target}";

        return goal;
    }
    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string goal = $"{this.GetType()}:{name},{description},{points},{_bonus},{_target},{_amountCompleted}";

        return goal;
    }
}
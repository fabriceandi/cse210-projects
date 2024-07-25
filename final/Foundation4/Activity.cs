using System;

public class Activity
{
    private string _date;
    private int _activityLength;

    public virtual double Distance()
    {
        
        return 0;
    }
    public virtual double Speed(double distance)
    {

        return 0;
    }
    public virtual double Pace()
    {
        return 0;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {GetType()} ({_activityLength} min)- Distance {} miles, Speed {} mph, Pace: {} min per mile");
    }

}
using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture()
    {
        _title = "Budgeting and Forecasting for Small Businesses";
        _description = "Learn how to create effective budgets, forecast future financial performance, and adjust your strategies based on financial data.";
        _date = "August 12, 2024";
        _time = "09:00 AM";
        _address = "Sunset Plaza, 1010 Maple Lane";
        _speakerName = "Christopher Bill";
        _capacity = 2;
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Speaker: {_speakerName} Capacity: {_capacity}h");
    }
}
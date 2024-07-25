using System;

public class OutDoorGathering : Event
{
    private string _weatherStatement;   
    public OutDoorGathering()
    {
        _title = "Summer Garden Picnic";
        _description = "Join us for a delightful Summer Garden Picnic in the heart of our city\'s most beautiful park. This casual outdoor gathering is perfect for families, friends, and neighbors to come together and enjoy a relaxing day in nature.";
        _date = "July 10, 2024";
        _time = "11:00 PM";
        _address = "Central Park, Great Lawn, 123 Park Avenue";
        _weatherStatement = "The weather for our Summer Garden Picnic is expected to be sunny.";
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"{_weatherStatement}");
    }
}
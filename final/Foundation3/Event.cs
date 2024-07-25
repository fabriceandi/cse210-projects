using System;
using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event()
    {
        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
    }
    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}\n{_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Title: {_title}\nEvent Type: {GetType()}\nDate: {_date}");
    }

}
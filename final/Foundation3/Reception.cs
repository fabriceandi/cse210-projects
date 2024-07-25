using System;

public class Reception : Event
{
    private string _email;

    public Reception()
    {
        _title = "Product Launch Reception";
        _description = "Celebrate the launch of our latest product at an exclusive reception event.";
        _date = "September 05, 2024";
        _time = "02:00 PM";
        _address = "Harvest Meadow Park, 456 Oak Street";
        _email = "We would be delighted to have you join us for this event. Please register by using this link: 'event.com'. Feel free to contact us for any questions.";
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"{_email}");
    }
    
}
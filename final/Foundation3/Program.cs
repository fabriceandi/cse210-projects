using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        Reception reception = new Reception();
        OutDoorGathering outDoorGathering = new OutDoorGathering();
        Console.WriteLine("Short Description");
        lecture.ShortDescription();
        Console.WriteLine("Full Details:");
        lecture.FullDetails();
        Console.WriteLine("Short Description");
        reception.ShortDescription();
        Console.WriteLine("Full Details:");
        reception.FullDetails();
        Console.WriteLine("Short Description");
        outDoorGathering.ShortDescription();
        Console.WriteLine("Full Details:");
        outDoorGathering.FullDetails();
    }
}
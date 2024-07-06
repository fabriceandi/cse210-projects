//No random questions are selected until they have all been used at least once.
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Activity activity = new Activity();
            Console.Clear();
            if(choice == 1)
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                activity1.SetDuration(duration);
                Console.Clear();
                activity1.Run();
                Console.WriteLine();
                activity1.DisplayEndingMessage();
            }
            else if(choice == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                activity2.SetDuration(duration);
                Console.Clear();
                activity2.Run();
                Console.WriteLine();
                activity2.DisplayEndingMessage();
            }
            else if(choice == 3)
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                activity3.SetDuration(duration);
                Console.Clear();
                activity3.Run();
                Console.WriteLine();
                activity3.DisplayEndingMessage();
            }
        }
    }
}
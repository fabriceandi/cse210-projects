// Text animation finishing recording event. Adding negative goals where user lose points for bad habit.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        int choice = 0;
        GoalManager manager = new GoalManager();
        while(choice != 6)
        {   
            Console.WriteLine();
            manager.DisplayPlayerInfo(); 
            manager.Start();
            choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.WriteLine("   4. Negative Goal");
                Console.Write("Which type of goal would you like to create? ");
                int option = int.Parse(Console.ReadLine());
                manager.CreateGoal(option);
            }
            else if(choice == 2)
            {
                manager.ListGoalDetails();
            }
            else if(choice == 3)
            {
                Console.Write("What is the filename for the goal life? ");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if(choice == 4)
            {
                Console.Write("What is the filename for the goal life? ");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if(choice == 5)
            {
                manager.ListGoalNames();
                manager.RecordEvent();
            }
        }
    }
}
// Exceeding requirement by saving other information (Adding the hour of the entry) in the journal entry.
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Console.WriteLine(" \nWelcome to the Journal Program!");
        Journal journal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write an new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit \n");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
        
            if (choice == 1) 
            {        
                PromptGenerator prompt = new PromptGenerator();
                string option = prompt.GetRandomGenerator();
                Console.WriteLine(option);
                Console.Write("> ");
                string newEntry = Console.ReadLine();
                Entry anEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                anEntry._date = date;
                //Adding time for an entry
                string hour = theCurrentTime.ToShortTimeString();
                anEntry._hour = hour;
                anEntry._promptText = option;
                anEntry._entryText = newEntry;
                journal.AddEntry(anEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }
    }
}
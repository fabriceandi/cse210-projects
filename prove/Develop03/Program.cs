// Exceed requirements: Load the scriptures from a file scriptures.csv

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Exceed requirements: Load the scriptures from a file.
        string filename ="scriptures.csv";
        string[] lines = File.ReadAllLines(filename);
        Random randomGenerator = new Random();
        int option = randomGenerator.Next(lines.Count());
        string line = lines[option];
        string[] parts = line.Split("|");
        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        string text = parts[4];
        Reference reference;
        if (parts[3] != "")
        {
            int endVerse = int.Parse(parts[3]);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse); 
        }
        
        // Core requirements

        //Reference reference = new Reference("Proverbs", 3, 5, 6);
        //string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());
        bool textHidden = scripture.IsCompletelyHidden();
        Console.WriteLine();
        Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
        string choice = Console.ReadLine();
        while(choice != "quit" && textHidden == false)
        {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            textHidden = scripture.IsCompletelyHidden();
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            choice = Console.ReadLine();
            Console.WriteLine();
        }   
    }
}
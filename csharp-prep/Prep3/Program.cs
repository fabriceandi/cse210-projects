using System;

class Program
{
    static void Main(string[] args)
    {
        // Core 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine(magicNumber);

        // Core 1 and 2
        //Console.Write("What is the magic number? ");
        //string answer = Console.ReadLine();
        //int magicNumber = int.Parse(answer);
        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}
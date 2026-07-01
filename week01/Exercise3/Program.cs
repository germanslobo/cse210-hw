using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        
        int guess = 0; // Initialize to a value that won't match
        
        // Keep looping until the guess matches the magic number
        while (guess != magicNumber)
        {
            // Ask user for their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            // Determine if they need to guess higher, lower, or got it
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
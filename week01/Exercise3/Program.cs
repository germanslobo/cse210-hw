using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        
        while (playAgain == "yes" || playAgain == "y")
        {
            // Generate a random magic number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guess = 0;
            int guessCount = 0;
            
            Console.WriteLine("I'm thinking of a number between 1 and 100...");
            
            // Keep looping until the guess matches the magic number
            while (guess != magicNumber)
            {
                // Ask user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                
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
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }
            
            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }
        
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
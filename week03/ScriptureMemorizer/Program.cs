/*
  EXCEEDING REQUIREMENTS / CREATIVITY REPORT:
  I implemented the stretch challenge for the word-hiding logic. Instead of selecting completely 
  random indexes that might point to already hidden words, my HideRandomWords method (Scripture.cs) explicitly 
  filters out words that are already hidden. It only selects from the remaining visible words 
  and stops precisely when all words are hidden, creating a much smoother experience for the user.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create the reference (using our multi-verse constructor)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // 2. Create the scripture object with the reference and the full text
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // 3. Main program loop
        while (true)
        {
            // Clear the console screen for a clean layout every turn
            Console.Clear();

            // Display the current state of the scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Blank line for spacing
            
            // Check if the scripture is fully hidden to end the program
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Prompt the user for action
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            // Handle the quit condition
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words if the user pressed enter
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nGood job memorizing!");
    }
}
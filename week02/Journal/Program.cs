using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Journal manager
        Journal myJournal = new Journal();

        // Initialize our pool of random prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random randomGenerator = new Random();
        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        // Main user interface loop - changed condition to '6' for the new quit option
        while (userChoice != "6")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear/Reset Journal");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // Select a random prompt from the list
                int randomIndex = randomGenerator.Next(prompts.Count);
                string selectedPrompt = prompts[randomIndex];

                Console.WriteLine($"\n{selectedPrompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                // Get the current system date as a simple string short-date
                string dateText = DateTime.Now.ToShortDateString();

                // Create a new entry and add it to the journal
                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = selectedPrompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                myJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                // Call the clear logic from the Journal instance
                myJournal.ClearAll();
            }
            else if (userChoice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
            }
        }
    }
}
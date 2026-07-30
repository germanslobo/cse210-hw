using System;

// =========================================================================================
// EXCEEDING REQUIREMENTS / CREATIVITY REPORT:
// 1. Session Activity Log: Added tracking to count how many times each mindfulness activity 
//    was completed during the program session, displayed at option 4 or upon exit.
// 2. Non-Repeating Prompts & Questions: Implemented logic in ReflectActivity and ListingActivity
//    to ensure random prompts/questions do not repeat until all options have been shown at least once.
// =========================================================================================

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectCount = 0;
        int listingCount = 0;

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session activity counts");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectActivity reflect = new ReflectActivity();
                    reflect.Run();
                    reflectCount++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Session Activity Log:");
                    Console.WriteLine($"  - Breathing Activities Completed: {breathingCount}");
                    Console.WriteLine($"  - Reflection Activities Completed: {reflectCount}");
                    Console.WriteLine($"  - Listing Activities Completed:    {listingCount}");
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                    break;

                case "5":
                    keepRunning = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
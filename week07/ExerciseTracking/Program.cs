using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an activity list containing instances of each derived class
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30.0, 4.8),
            new Cycling("03 Nov 2022", 45.0, 20.0),
            new Swimming("03 Nov 2022", 30.0, 40)
        };

        Console.WriteLine("--- Exercise Tracking Summary ---\n");

        // Iterate through polymorphic collection and call GetSummary()
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
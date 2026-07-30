using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            if (breatheIn)
            {
                Console.Write("Breathe in...");
                ShowCountDown(4);
            }
            else
            {
                Console.Write("Breathe out...");
                ShowCountDown(6);
            }

            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}
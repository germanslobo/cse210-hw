using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number for duration: ");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string frame = spinnerFrames[i];
            Console.Write(frame);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinnerFrames.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
            // Adjust backspaces for multi-digit numbers if countdown > 9
            int digits = i.ToString().Length;
            for (int j = 0; j < digits; j++)
            {
                Console.Write("\b \b");
            }
        }
    }
}
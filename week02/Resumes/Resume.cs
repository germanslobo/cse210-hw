using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    
    // We initialize the list immediately to avoid null reference errors
    public List<Job> _jobs = new List<Job>();

    // Method to display the entire resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job in the list and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
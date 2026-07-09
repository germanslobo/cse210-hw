using System;

public class Entry
{
    // Member variables using the underscore convention
    public string _date;
    public string _promptText;
    public string _entryText;

    // Displays this specific entry in a clear format
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine(); // Blank line for spacing
    }
}
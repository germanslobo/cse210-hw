using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Holds the list of journal entries
    public List<Entry> _entries = new List<Entry>();

    // Adds a newly created entry to our list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Iterates through all entries and displays them to the screen
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the complete list of entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Loads entries from a file, replacing any current entries
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];
                
                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }

    // === ADD THIS NEW METHOD HERE ===
    public void ClearAll()
    {
        _entries.Clear();
        Console.WriteLine("The current journal has been cleared/reset!");
    }
}
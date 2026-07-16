/*
************************************************************************
Multiple Constructors: The code looks at the arguments.
If you pass 3 numbers, it uses the first constructor; 
if you pass 4 numbers, it uses the second one, 
Based in the requirements of the project.
*************************************************************************
*/

using System;

public class Reference
{
    // Private member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor 1: For a single verse (e.g., John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // If it's a single verse, the end verse is the same as the start verse
    }

    // Constructor 2: For a verse range (e.g., Proverbs 3:5-6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method to return the formatted reference string
    public string GetDisplayText()
    {
        // If the start verse matches the end verse, it's a single verse
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Otherwise, it's a range
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
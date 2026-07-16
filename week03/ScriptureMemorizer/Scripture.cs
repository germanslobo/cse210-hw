/*
*******************************************************************************************
The job of this class is to hold the Reference object and
a list of all the Word objects that make up the text.
It handles converting the raw text into individual words,
picking random words to hide, and assembling everything together for display.
*******************************************************************************************
*/


using System;
using System.Collections.Generic;

public class Scripture
{
    // Private member variables
    private Reference _reference;
    private List<Word> _words;

    // Constructor: Takes a Reference object and the raw text string
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text by spaces to get individual words
        string[] splitWords = text.Split(' ');

        // Create a new Word object for each string and add it to our list
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Method to hide a given number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHiddenThisTurn = 0;

        // Count how many words are actually available to hide
        int visibleCount = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleCount++;
            }
        }

        // If no words are left to hide, we stop immediately
        if (visibleCount == 0)
        {
            return;
        }

        // Keep trying to hide words until we hit our target or run out of visible words
        while (wordsHiddenThisTurn < numberToHide && wordsHiddenThisTurn < visibleCount)
        {
            int randomIndex = random.Next(_words.Count);

            // STRETCH CHALLENGE: Only hide the word if it isn't already hidden
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHiddenThisTurn++;
            }
        }
    }

    // Method to build the full text display (Reference + Words)
    public string GetDisplayText()
    {
        string scriptureText = "";

        // Loop through and append each word's display text (word or underscores)
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        // Combine the reference and the processed text
        return $"{_reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }

    // Method to check if the entire scripture is hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found a word still visible!
            }
        }
        return true; // All words are hidden
    }
}
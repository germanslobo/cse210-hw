/*
*******************************************************************************************
_text and _isHidden: These are private fields. No other class can change them directly, 
which satisfies your Encapsulation design requirement.
*******************************************************************************************
*/

using System;

public class Word
{
    // Private member variables (Encapsulation)
    private string _text;
    private bool _isHidden;

    // Constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, all words start out visible
    }

    // Method to change the state to hidden
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is already hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get what should be shown on the screen
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create a string of underscores matching the exact length of the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
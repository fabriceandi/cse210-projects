using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
 
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] parts = text.Split(' ');
        foreach(string t in parts)
        {
            Word word = new Word(t);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int i = 0;
        int number = 0;
        foreach(Word w in _words)
        {
            bool hidden = w.IsHidden();
            if (hidden == false)
            {
                number += 1;
            }
        }
        if (number < numberToHide)
        {
            numberToHide = number;
        }

        while(i < numberToHide)
        {
            Random randomGenerator = new Random();
            int option = randomGenerator.Next(_words.Count);
            Word word = _words[option];
            if (word.IsHidden() == false)
            {
                word.Hide();
                _words[option] = word;
                i += 1;
            }
        }
    }
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string passage = "";
        foreach(Word w in _words)
        {
            passage += w.GetDisplayText();
        }
        return reference + passage;
    }
    public bool IsCompletelyHidden()
    {
        int nb = 0;
        foreach(Word w in _words)
        {
            bool hidden = w.IsHidden();
            if (hidden == false)
            {
                nb += 1;
            }
        }
        if (nb > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
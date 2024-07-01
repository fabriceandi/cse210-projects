using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string text = "";
            for(int i=0; i < _text.Count(); i++)
            {
                text += "_";
            }
            return " " + text;
        }
        else
        {
            return " " + _text;
        }
    }
}
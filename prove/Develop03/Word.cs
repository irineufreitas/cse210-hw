using System;

public class Word 
{
    private string _text;
    private bool _isHidden;
    private string _originalText;

    public Word(string text)
    {
        _text = text;
        _originalText = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _text = "___";
        _isHidden = true;
    }

    public void Show()
    {
        _text = _originalText;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
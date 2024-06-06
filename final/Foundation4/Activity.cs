using System;
using System.Diagnostics;

public class Activity
{
    private string _date;
    private int _length;


    public Activity (string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_length} min)";
    }

}
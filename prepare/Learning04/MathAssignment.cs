using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment (string student, string topic, string textbook, string problems) : base(student, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }

   
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}
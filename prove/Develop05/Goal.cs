using System;

public class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;


    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

      

    public virtual void RecordEvent()
    {
        Console.Write("What is the name of your goal?");
        _shortName = Console.ReadLine();
        Console.Write("What is a short description of it?");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points?");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual bool IsComplete ()
    {
        
        return true;
        
    }

    public virtual bool IsFalse()
    {
        
        return false;
        
    }

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
        
       
        
    }

    

    public virtual string GetGoalRepresentation()
    {
    
    return $"Goal:{_shortName},{_description},{_points}";
    }
}
using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }


    
    public override void RecordEvent()
    {
        Console.Write("What is the name of your goal?");
        ShortName = Console.ReadLine();
        Console.Write("What is a short description of it?");
        Description = Console.ReadLine();
        Console.Write("What is the amount of points?");
        Points = int.Parse(Console.ReadLine());
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {ShortName} ({Description})";
        }
        else
        {
            return $"[ ] {ShortName} ({Description})";
        }
        
       
        
    }

    public override string GetGoalRepresentation()
    {
        return $"SimpleGoal:{ShortName},{Description},{Points},{_isComplete}";
    }
}
using System;
using System.ComponentModel;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        
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

    public override bool IsComplete()
    {
        return IsFalse();
    }

    public override string GetDetailsString()
    {
        return $"[ ] {ShortName} ({Description})";
       
        
    }

    public override string GetGoalRepresentation()
    {
        return $"EternalGoal:{ShortName},{Description},{Points}";
    }
}

    

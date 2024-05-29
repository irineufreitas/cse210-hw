using System;
using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public int Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }

    public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
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
        return AmountCompleted >= Target;
    }

    public override string GetDetailsString()
    {
        
        if (AmountCompleted == Target)
        {
        return $"[X] {ShortName} ({Description}) -- Currently completed: {AmountCompleted}/{Target}";
        }
        else
        {
        return $"[ ] {ShortName} ({Description}) -- Currently completed: {AmountCompleted}/{Target}";
        }
       
        
        
    }

    public override string GetGoalRepresentation()
    {
        return $"ChecklistGoal:{ShortName},{Description},{Points},{Bonus},{Target},{AmountCompleted}";
    }
}
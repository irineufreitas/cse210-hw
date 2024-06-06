using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public double GetDistance()
    {
        return _speed * GetLength() / 60;
    }

    public double CalculatePace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetSummary()

    {
        double pace = CalculatePace();
        double distance = GetDistance();
        
        return $"Cycling: {base.GetSummary()}: Distance {distance:F2} kilometers, Speed {_speed:F2} KPH, Pace {pace:F2} min per KM";
    }

    
}
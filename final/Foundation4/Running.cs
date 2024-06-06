using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public double CalculatePace()
    {
        return GetLength() /_distance;
    }

    public double CalculateSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    
    public override string GetSummary()

    {
        double pace = CalculatePace();
        double speed = CalculateSpeed();
        return $"Running: {base.GetSummary()}: Distance {_distance} kilometers, Speed {speed:F2} KPH, Pace {pace:F2} min per KM";
    }
}

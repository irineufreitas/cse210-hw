using System;

public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int length, int numlaps) : base(date, length)
    {
        _numLaps = numlaps;
    }

    public int GetNumOfLaps()
    {
        return _numLaps;
    }

    public double CalculateDistanceKm()
    {
        return _numLaps * 50 /1000.0;
    }

    public double CalculateSpeed()
    {
        return CalculateDistanceKm()/ GetLength() * 60.0;
    }

    public double CalculatePace()
    {
        return GetLength()/CalculateDistanceKm();
    }

    public override string GetSummary()

    {
        double pace = CalculatePace();
        double distance = CalculateDistanceKm();
        double speed = CalculateSpeed();
        
        return $"Swimming: {base.GetSummary()}: Distance {distance} kilometers, Speed {speed} KPH, Pace {pace:F2} min per KM";
    }
}
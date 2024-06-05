using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string DisplayLecture()
    {
        string eventMessage = DisplayMessage();
        return $"{eventMessage}Speaker: {_speaker}\nEvent Capacity: {_capacity}\n";
    }
}
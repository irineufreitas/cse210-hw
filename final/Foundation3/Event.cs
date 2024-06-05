using System;

public class Event 
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayMessage()
    {
        return $"We Invite you to the {_eventTitle} event!\n{_description}\non {_date} at {_time}\nPlease come to the following address: {_address.DisplayAddress()}\n";
    }

}
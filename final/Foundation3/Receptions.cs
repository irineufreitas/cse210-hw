using System;

public class Reception : Event 
{
    public Reception(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {

    }

    public string DisplayReception()
    {
        string eventMessage = DisplayMessage();
        return $"{eventMessage}\nRSVP at Receptions.com\n&\nRegister Your Presence!";
    }
}
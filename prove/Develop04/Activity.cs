using System;
using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Write($"\nWelcome to the {_name} Activity.\n\n{_description}\nHow long, in seconds, would you like for your session?");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!\n");
    }

    
    public void ShowSpinner(int seconds)
    {
        _duration = seconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

       
        
    

    }

    
    

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        _duration = seconds;
    }

    
}


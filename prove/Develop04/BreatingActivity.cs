using System;

public class BreathingActivity : Activity
{
    public BreathingActivity (string name, string description) : base(name, description)
    {

    }
    
    
    public void Run(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        Console.Write("Get ready");
        ShowSpinner(5);

        Console.WriteLine("\n");
        

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write($"Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("\n");
            Console.Write($"Breathe out...");
            ShowCountDown(5);
            Console.WriteLine("\n");
            
        }

        DisplayEndingMessage();
    }
}
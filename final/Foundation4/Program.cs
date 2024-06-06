using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracker App");

        Running running = new Running("06 June 2024",25,3);
        Cycling cycling = new Cycling("05 June 2024", 45, 14.2);
        Swimming swimming = new Swimming("07 June 2024",20,30);
        

        List<Activity> activities = new List<Activity>();

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
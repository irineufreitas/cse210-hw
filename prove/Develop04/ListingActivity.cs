using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _userInputs;

    public ListingActivity(string name, string description, int count) : base(name, description)
    {
       _count = count; 
       _prompts = new List<string>();
       _userInputs = new List<string>();
    }

    public void Run(int seconds)
    {
        _duration = seconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        

        Console.Write("Get ready");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("\n");
        

        while (DateTime.Now < endTime)
        {
            Console.Write("List as many responses you can to the following prompt:\n");
            Console.WriteLine($"{GetRandomPrompt()}\n");
            
            
            Console.WriteLine("When you have something in mind, press any key to continue.");
            Console.ReadKey();
            
            
            Console.Write("You may begin in:");
            ShowCountDown(3);

            Console.WriteLine("\n");

            GetListFromUser();

            while (_duration > 0)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();
                _userInputs.Add(userInput);
                _duration--;
            }
           
            
            
        }
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        
        
        Random random = new Random();

        int randomIndex = random.Next(0, 4);

        string randomPrompt = _prompts[randomIndex];

        return $"-- {randomPrompt} --";
    }

    public void GetListFromUser()
    {
        while (_duration > 0)
        {
        Console.Write(">");
        string userInput = Console.ReadLine();
        _userInputs.Add(userInput);
        _duration--;
        }

    

        
    }

    public string GetNumberItems()
    {
        int count = _userInputs.Count;
        string counString = count.ToString();
       
        return $"{counString}";
    }
}
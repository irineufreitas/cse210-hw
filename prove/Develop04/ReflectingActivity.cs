using System;
using System.ComponentModel.Design.Serialization;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base (name, description)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
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
            
            Console.Write("Conside the following prompt:\n");
            
            DisplayPrompt();
            Console.Write("When you have something in mind, press any key to continue.");
            Console.ReadKey();
            
            
            Console.Write("loading");
            ShowSpinner(4);
           
            DisplayQuestions();
            Console.Write("Time to reflect now");
            ShowSpinner(seconds);
            
        }
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        
        
        Random random = new Random();

        int randomIndex = random.Next(0, 3);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int randomIndex = random.Next(0, 8);

        string randomQuestion = _questions[randomIndex];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"<<<{GetRandomPrompt()}>>>");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine($"<<<{GetRandomQuestion()}>>>");
        Console.WriteLine();
    }
}
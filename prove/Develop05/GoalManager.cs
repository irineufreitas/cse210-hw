using System;
using System.ComponentModel;
using System.IO;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;
 

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public int Score
    {
        get
        {
            return _score;
        }
    }

    public void Start()
    {
        while(true)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"You have {_score} points!\n");
            
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select an option from the menu: ");

            string option = Console.ReadLine();
            // Console.Clear();

            if (option == "1")

            {
                CreateGoal();
            }
            else if (option == "2")
            {
                ListGoalDetails();
            }
            else if (option == "3")
            {
                SaveGoals();
            }
            else if (option == "4")
            {
                LoadGoals();
            }
            else if (option == "5")
            {
                RecordEvent();
            }
            else if (option == "6")
            {
                Console.WriteLine("GoodBye!");
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        //not sure
    }

    public void CreateGoal()
    {
        while(true)
        {
            
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            

            Console.Write("What type of goal would you like to create?");

            string option = Console.ReadLine();
            // Console.Clear();

            if (option == "1")

            {
                Console.Write("What is the name of your goal? ");
                string shortname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points? ");
                int points = int.Parse(Console.ReadLine());
                
                SimpleGoal simplegoal = new SimpleGoal(shortname, description, points);
                _goals.Add(simplegoal);

                Console.WriteLine($"Your {shortname} goal was created successfully!\n");
                break;
            }
            else if (option == "2")
            {
                Console.Write("What is the name of your eternal goal? ");
                string shortname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points? ");
                int points = int.Parse(Console.ReadLine());
                
                EternalGoal eternalgoal = new EternalGoal(shortname, description, points);
                _goals.Add(eternalgoal);
                Console.WriteLine($"Your {shortname} goal was created successfully!\n");
                break;
            }
            else if (option == "3")
            {
                Console.Write("What is the name of your checklist goal? ");
                string shortname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                
                ChecklistGoal checklistgoal = new ChecklistGoal(shortname, description, points, target, bonus);
                _goals.Add(checklistgoal);
                Console.WriteLine($"Your {shortname} goal was created successfully!\n");
                
                break;
        }    }
    }

    public void ListGoalNames ()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {   
            
            Console.WriteLine($"{count}. {goal.ShortName}");
            count++;
        }
            

        
    }

    public void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        
        {   
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count ++;
        }
    }

    public void RecordEvent()
    {
    ListGoalNames();
    Console.WriteLine("What goal did you accomplish?");
    int count = int.Parse(Console.ReadLine());

    if (count >= 1 && count <= _goals.Count)
    {
        Goal selectedGoal = _goals[count - 1];

        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            checklistGoal.AmountCompleted++;
            _score += checklistGoal.Points;

            Console.WriteLine($"Congratulations, you have accomplished the goal: {selectedGoal.ShortName}");

            if (checklistGoal.AmountCompleted == checklistGoal.Target)
            {
                _score += checklistGoal.Bonus;
                Console.WriteLine($"You have earned a bonus of {checklistGoal.Bonus} points!");
            }
        }
            
        else if (selectedGoal is SimpleGoal simpleGoal)
        {
            simpleGoal.MarkComplete();
            _score += simpleGoal.Points;
            Console.WriteLine($"Congratulations, you have accomplished the goal: {selectedGoal.ShortName}");
        }
            
        
        else

        {

        _score += selectedGoal.Points;
        Console.WriteLine($"Congratulations, you have accomplished the goal: {selectedGoal.ShortName}");
        selectedGoal.IsComplete();

        }

        Console.WriteLine($"Your score is now: {_score}");
        }
        else
        {
        Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals ()
    {
        Console.WriteLine("What is the filename?");
        string fileStore = Console.ReadLine();
        

        bool fileExists = File.Exists(fileStore);
        using (StreamWriter outputFile = new StreamWriter(fileStore, append: fileExists))
        {
        
        if (!fileExists)
        {
            outputFile.WriteLine($"Score:{_score}");
        }
        foreach (Goal goal in _goals)
            
        {
            outputFile.WriteLine(goal.GetGoalRepresentation());    
        }
        
        }

        Console.WriteLine($"File saved successfully!\n");

        
    }

    public void LoadGoals()
{
    Console.WriteLine("What is the filename?");
    string loadFile = Console.ReadLine();

    if (File.Exists(loadFile))
    {
        string[] lines = File.ReadAllLines(loadFile);

        // Check if the file contains score information
        if (lines.Length > 0 && lines[0].StartsWith("Score:"))
        {
            _score = int.Parse(lines[0].Substring(6)); // Extract the score from the line
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] goalData = parts[1].Split(',');

            // Handle different goal types
            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[3]), int.Parse(goalData[4]));
                goal.AmountCompleted = int.Parse(goalData[5]);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!\n");
    }
    else
    {
        Console.WriteLine("File does not exist\n");
    }


}

    
    
}
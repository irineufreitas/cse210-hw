using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int userInt = -1;

        Journal journal = new Journal();
        

        //while for the menu
        while (userInt != 5)
        {
            //program basic display
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("Select one of the options below:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");

            //convert what the user types into an integer.
            string userInput = Console.ReadLine();
            userInt = int.Parse(userInput);
            
            
            //if function to execute according to what the user will type
            if (userInt == 1)
            {
                //did the whole formatting so the info is well stored.
                PromptGenerator _prompts = new PromptGenerator();
                string randomPrompt = _prompts.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write(">");
                string written1 = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string dateString = currentTime.ToShortDateString();
                //create new entry
                Entry writtenLine = new Entry();
                writtenLine._date = dateString;
                writtenLine._entryText = written1;
                writtenLine._promptText = randomPrompt;
                
                
                journal.AddEntry(writtenLine);

                
            }
                
            else if (userInt == 2)
            {   
                //adding a text to make it easier to present the info!
                Console.WriteLine("Here are the entries so far! \n");
                journal.DisplayAll();
            
            }
            else if (userInt == 3)
            {
                
                journal.SaveToFile();
                
            }
            else if (userInt == 4)
            {
                Console.Write("Type the Journal Entry Filename:");
                string fileLo = Console.ReadLine();
                journal.LoadFromFile(fileLo);
            }
            else if (userInt == 5)
            {
                //quit one
            }
                

        }
        
    }
}

//remember that the object state is the variables
//the behaviors are functions as methods
using System;

class Program
{
    static void Main(string[] args)
    {   
        while(true)
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select an option: ");

            string option = Console.ReadLine();
            Console.Clear();

            if (option == "1")

            {
                StartBreathingActivity();
            }
            else if (option == "2")
            {
                StartReflectingActivity();
            }
            else if (option == "3")
            {
                StartListingActivity();
            }
            else if (option == "4")
            {
                Console.WriteLine("GoodBye!");
                break;
            }
        }

        static void StartBreathingActivity()
        {
            string breathingActive = "Breathing";
            string descriptionActive = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";
        
            BreathingActivity breathingActivity = new BreathingActivity(breathingActive, descriptionActive);
            breathingActivity.DisplayStartingMessage();
            
            
            int seconds;
            bool validInput = false;
            
            
            while (!validInput)
            {
                string input = Console.ReadLine();
                

                if (int.TryParse(input, out seconds))
                {
                    breathingActivity.Run(seconds);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
                    Console.Write("How long, in seconds, would you like for your session?");
                }
            }
            
        
        }

        static void StartReflectingActivity()
        {
            
            string reflectingActive = "Reflecting";
            string descriptionReflec = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

            ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingActive, descriptionReflec);
            reflectingActivity.DisplayStartingMessage();

            int seconds;
            bool validInput = false;
            
            while (!validInput)
            {
                string input = Console.ReadLine();
                

                if (int.TryParse(input, out seconds))
                {
                    reflectingActivity.Run(seconds);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
                    Console.Write("How long, in seconds, would you like for your session?");
                }
            }
        }
        
        static void StartListingActivity()
        {
            int count = 0;
            int seconds;
            bool validInput = false;
            string listingActive = "Listing";
            string descriptionList = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

            ListingActivity listingActivity = new ListingActivity (listingActive, descriptionList, count);
            listingActivity.DisplayStartingMessage();
            // Console.Clear();

            while (!validInput)
            {
                string input = Console.ReadLine();
                

                if (int.TryParse(input, out seconds))
                {
                    listingActivity.Run(seconds);
                    
                    Console.WriteLine($"You listed {listingActivity.GetNumberItems()} items.\n");
                    Console.WriteLine($"Here are the items you listed:\n");
                    listingActivity.GetItemsList();
                    Console.WriteLine("\n");
                    listingActivity.DisplayEndingMessage();
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
                    Console.Write("How long, in seconds, would you like for your session?");
                }
            }

            

            
        }

    }
}

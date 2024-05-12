using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture1 = new Scripture(reference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        string displayText = scripture1.GetDisplayText();
        Console.WriteLine(displayText);
        Console.WriteLine();
        

        
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        

        string quit = "";

        

        
        while(quit != "quit")
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();

                Random randomNum = new Random();
                int ram = randomNum.Next(1, 8);
                scripture1.HideRandomWords(ram);

                
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                Console.Write(scripture1.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                
                if (scripture1.IsCompletelyHidden())
                {
                    break;
                }

                
            }

            quit = Console.ReadLine();

            if(quit == "quit")
            {
                break;
            }
        
                
            
        }

    }
}
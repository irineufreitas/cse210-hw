using System;

class Program
{
    static void Main(string[] args)
    {
        // int storeNumber = 0;
        // int magicOne = 1;
        // while (storeNumber != magicOne)
        // {
        // Console.Write("What is the magic number?");
        // string magicNumber = Console.ReadLine();
        // storeNumber = int.Parse(magicNumber);
        // Console.Write("What is your guess?");
        // string readNum = Console.ReadLine();
        // magicOne = int.Parse(readNum);

        
        
        // if (storeNumber == magicOne)
        // {
        //     Console.Write("You guessed it right G!");
        // }
        // if (storeNumber < magicOne)
        // {
        //     Console.Write("Lower");
        // }
        // if (storeNumber > magicOne)
        // {
        //     Console.Write("Higherr");
        // }
        // }   

        Random randomGenerator = new Random();
        int storeNumber = randomGenerator.Next(1, 100);
        
        int storeGuess = 0;
        

        while(storeGuess != storeNumber)
        {   
            Console.Write("What is your guess?");
            string guessNumber = Console.ReadLine();
            storeGuess = int.Parse(guessNumber);
    
            if (storeGuess > storeNumber)
            {
                Console.WriteLine("Lower");
            }
            
            if (storeGuess < storeNumber)
            {
                Console.WriteLine("Higher");
            }
            if (storeGuess == storeNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
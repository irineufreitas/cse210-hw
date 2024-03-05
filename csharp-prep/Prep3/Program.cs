using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?");
        // string magicNumber = Console.ReadLine();
        // int storeNumber = int.Parse(magicNumber);

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
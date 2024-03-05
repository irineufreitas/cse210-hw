using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is the username?");
        string usR = Console.ReadLine();
        return usR;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string favNumber = Console.ReadLine();
        int numBer = int.Parse(favNumber);
        
        return numBer;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string usR, int square)
    {
        Console.WriteLine($"{usR}, the square of your number is {square}");
    }
}

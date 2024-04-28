using System;

class Program
{
    static void Main(string[] args)
    {   
        // percetage question
        Console.WriteLine("What is your grade percentage?");
        string gradeMan = Console.ReadLine();
        int gradeRock = int.Parse(gradeMan);

        string letter = "";

        if (gradeRock >= 90)
        {
            letter = "A";
            
        }

        else if (gradeRock >= 80)
        {
            letter = "B";
            
        }

        else if (gradeRock >= 70)
        {
            letter = "C";
            
        }

        else if (gradeRock >=60)
        {
            letter = "D";
            
        }

        else if (gradeRock < 60)
        {
            letter = "F";
            
        }

        if (gradeRock >= 70)
        {
            Console.Write($"Congratulations, Your grade is {letter} and you have passed the course!");
            
        }
        else
        {
            Console.WriteLine("You have not passed this time, keep working to pass next time!");
        }

    }
}
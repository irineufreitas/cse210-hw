using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int testNum = -1;

        while (testNum != 0)
        {
            Console.Write("Enter a number:");
            string writtenNum = Console.ReadLine();
            testNum = int.Parse(writtenNum);
            numbers.Add(testNum);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        
        
        float average = sum / numbers.Count;

        
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine ($"The max is {max}!");
    }
}
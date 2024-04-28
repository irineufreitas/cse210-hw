using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string storeNum = Console.ReadLine();
            number = int.Parse(storeNum);

            numbers.Add(number);

        }

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;   
        }
        Console.WriteLine($"The sum is {sum}");

        int countWords = numbers.Count;
        float average = sum / countWords;

        Console.WriteLine($"The average is: {average}");

        int max = 0;

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine ($"The largest number is {max}!");

        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // List<int> numbers = new List<int>();
        // int testNum = -1;

        // while (testNum != 0)
        // {
        //     Console.Write("Enter a number:");
        //     string writtenNum = Console.ReadLine();
        //     testNum = int.Parse(writtenNum);
        //     numbers.Add(testNum);
        // }

        // int sum = 0;
        // foreach (int number in numbers)
        // {
        //     sum += number;
        // }
        // Console.WriteLine($"The sum is: {sum}");
        
        
        
        // float average = sum / numbers.Count;

        
        // Console.WriteLine($"The average is: {average}");

        // int max = numbers[0];

        // foreach (int number in numbers)
        // {
        //     if (number > max)
        //     {
        //         max = number;
        //     }
        // }
        // Console.WriteLine ($"The max is {max}!");
    }
}
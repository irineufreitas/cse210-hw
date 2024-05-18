using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new Assignment("Irineu", "Programming");
        Console.WriteLine(student.GetSummary());
        Console.WriteLine();
        

        MathAssignment student2 = new MathAssignment("Irineu Freitas", "Programming", "Section 7.3", "Problems 8-19");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment student3 = new WritingAssignment("Irineu Junior", "Brazilian History", "The Dangers of Brazil");
        Console.WriteLine(student3.GetWritingInformation());
        Console.WriteLine();
    }
}
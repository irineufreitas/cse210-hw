using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

public class Journal //main
{
    public List<Entry> _entries = new List<Entry>(); //list

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Thank you for writing in your journal");
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} ");
            Console.WriteLine($"Entry: {entry._entryText} ");
            Console.WriteLine($"Scripture Read: {entry._scripture} ");
            Console.WriteLine("\n");
        }
        
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileStore = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileStore))

        foreach (Entry entry in _entries)
            
        {
            outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            outputFile.WriteLine($"Entry: {entry._entryText}");
            outputFile.WriteLine($"Scripture of the day: {entry._scripture}");
            outputFile.WriteLine();
        }

        Console.WriteLine($"File saved successfully!\n");

    }
    
    public void LoadFromFile(string file)
    {
        
        string loadFile = file;
        
        if (File.Exists(loadFile))
        {

            string[] lines = File.ReadAllLines(loadFile);

            foreach (string line in lines)
            {
                Console.WriteLine();
                Console.WriteLine($"{line}");
                Console.WriteLine();
            }

        }   

        else
        {
            Console.WriteLine("File does not exist\n");
        }
        
        
    }
}
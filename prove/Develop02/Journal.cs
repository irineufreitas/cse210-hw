using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

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
            outputFile.WriteLine();
        }

        Console.WriteLine("File saved successfully!");

    }
    
    public void LoadFromFile(string file)
    {
        
        string loadFile = file;
        
        if (File.Exists(loadFile))
        {

            string[] lines = File.ReadAllLines(loadFile);

            foreach (string line in lines)
            {

            }

        }   

        else
        {
            Console.WriteLine("File does not exist");
        }
        
        
    }
}
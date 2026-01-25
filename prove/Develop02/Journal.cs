using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private static string _fileName = "journal.txt";

    public static List<Entry> entries = new List<Entry>();
    public static void SaveEntry(Entry entry)
    {
        entries.Add(entry);
        using (StreamWriter writer = new StreamWriter(_fileName, true))
        {
            writer.WriteLine(entry.ToFileString());
        }
    }
    public static void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

public static void LoadFromFile(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    entries.Clear();

    foreach (string line in File.ReadAllLines(filename))
    {
        var parts = line.Split('|');
        entries.Add(new Entry(parts[1], parts[2], parts[0]));
    }

    Console.WriteLine("Journal loaded successfully!");
}



    public static void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
        }
        Console.WriteLine("Journal saved successfully!");
}
}

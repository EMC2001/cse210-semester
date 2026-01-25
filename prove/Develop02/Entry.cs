using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Mime;

public class Entry
{
    public string Prompt { get; set;}
    public string Response { get; set;}
    public string Date { get; set;}

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToShortDateString();
    }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public string ToFileString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }
}

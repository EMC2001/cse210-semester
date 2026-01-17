using System;
using System.Collections.Generic;
public class Person
{
    public string _person;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_person}");

        Console.WriteLine($"Jobs:");
        
        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}
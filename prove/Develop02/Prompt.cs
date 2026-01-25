using System.IO.Compression;
using System.Collections.Generic;

public class Prompt
{
    public static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What was the worst part of the day?",
        "What can I do to be better tomorrow?"
    };

    public static Random random = new Random();
    public static string DisplayPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}


using System;

class Breathing : Activity
{
    public override void Start()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly.\nClear your mind and focus on your breathing.");

        base.Start(); 

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();
        while (DateTime.Now < endTime)
        {
            Countdown("Breathe in...", 4);
            Countdown("Breathe out...", 5);
            Console.WriteLine();
        }

        DisplayEndingMessage("Breathing");
    }
}
public class Activity
{
    protected int _duration;

    public virtual void Start()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    protected void DisplayEndingMessage(string activityName)
    {
        Console.WriteLine("\nWell done! You have completed the activity.");
        Thread.Sleep(3000);
    }

    protected void Spinner(int seconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int frameIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerFrames[frameIndex]);
            Thread.Sleep(300); 
            Console.Write("\b"); 
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
        }

        Console.WriteLine(); 
    }

    protected void Countdown(string message, int seconds)
    {
        Console.Write($"{message} ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

}
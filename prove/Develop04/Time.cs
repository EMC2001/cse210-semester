public abstract class Time
{
    protected int GetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int durationInSeconds) && durationInSeconds > 0)
        {
            return durationInSeconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
            return 0;
        }
    }

    public abstract void Start();
}
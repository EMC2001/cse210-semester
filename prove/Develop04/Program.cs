class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflection Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4.- Exit Program");
            Console.Write("Your Choice: ");

            string choice = Console.ReadLine();
            
            if (choice == "4")
            {
                break; 
            }

            switch (choice)
            {
                case "1":
                    new Breathing().Start();
                    break;

                case "2":
                    new Reflection().Start();
                    break;

                case "3":
                    new Listing().Start();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            Menu.DisplayMenu() ;
            string choice = Console.ReadLine() ;

            if (choice == "1")
            {
                string prompt = Prompt.DisplayPrompt();
                Console.WriteLine(prompt);

                Console.WriteLine("Your response: ") ;
                string response = Console.ReadLine() ;

                Entry entry = new Entry(prompt, response);
                Journal.SaveEntry(entry);
            }

            else if (choice == "2")
            {
                Journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to load: ");
                string filename = Console.ReadLine();
                Journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to save: ");
                string filename = Console.ReadLine();
                Journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.") ;
            }

        }
    }    
}

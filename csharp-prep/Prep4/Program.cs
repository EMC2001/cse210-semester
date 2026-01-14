using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();
        
        int number = -1;

        while (number != 0)
        {

            Console.Write("Enter number: ");

            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }

            if (number == 0)
            {
                int total = numbers.Sum();
                Console.WriteLine("The sum is: " +total);
            }
            
            if (number == 0)
            {
                double average = numbers.Average();
                Console.WriteLine($"The average is: {average}");

            }
            
             if (number == 0)
            {
                int max = numbers.Max();
                Console.WriteLine($"The largest numve is: {max}");
            }
        }


    }
}
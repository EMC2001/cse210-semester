using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();

        int number = PromptUserNumber();

        int square = SquareNumber(number);

        int userYear;
        PromptUserBirthYear(out userYear);

        DisplayResult(name, square, userYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    
    return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static void PromptUserBirthYear(out int userYear)
    {
       Console.Write($"Please enter the year you were born: "); 
        userYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int squared = number * number; 
        return squared;
    }

    static void DisplayResult(string name, int square, int userYear)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");

        Console.WriteLine($"{name}, you will turn {2025 - userYear} years old this year.");
    }

}
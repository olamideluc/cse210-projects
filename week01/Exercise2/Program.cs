using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string vaLueFromUser = Console.ReadLine();
        int value = int.Parse(vaLueFromUser);

        string letter = "";

        if (value >= 90)
        {
            letter = "A";
        }
        else if (value >= 80)
        {
            letter = "B";
        }
        else if (value >= 70)
        {
            letter = "C";
        }
        else if (value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (value >= 70)
        {
            Console.WriteLine("Congratulation! you passed.");
        }
        else
        {
            Console.WriteLine("Goodluck, try nextime");
        }
    
    
    }
}
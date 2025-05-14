using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int squaredNumber = squareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string promptUserName()
    {
        Console.Write("Please enter your name ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(A1.GetSummary());

        MathAssignment A2 = new MathAssignment("Robert Rodriguez", "Fraction", "7.3", "8-9");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());

        WritingAssignment A3 = new WritingAssignment("Mary Waters", "European History", "The causes of world war II");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}
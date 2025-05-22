using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValues());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValues());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValues());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValues());
        
    }
}
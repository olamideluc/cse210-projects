using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        int MagicNumber = int.Parse(Console.ReadLine());
        

        // Random randomGenerator = new Random();
        // int MagicNumber = randomGenerator.Next(1, 101);

        int guess= -1;
        while (guess != MagicNumber)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            


            if (MagicNumber > guess)
            {

                Console.WriteLine("Higher");
            }
            else if (MagicNumber < guess)
            {

                Console.WriteLine("Lower");
            }
            else
            {

                Console.WriteLine("You guessed it");
            }

        }
    }
}
        
        
        
        
        
        
        
            
        
        
        
        
        

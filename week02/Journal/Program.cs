using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Entry prompt = new Entry();
        prompt._promptText = "Who was the most interesting person I interacted with today?";
        prompt._promptText = "What was the best part of my day? ";
        prompt._promptText = "How did I see the hand of the Lord in my life today? ";
        prompt._promptText = "What was the strongest emotion I felt today? ";
        prompt._promptText = "If I had one thing I could do over today, what would it be? ";

        
        

        PromptGenerator mypromptGenerator = new PromptGenerator();
        mypromptGenerator._prompts.Add(prompt);
        mypromptGenerator.GetRandomPrompt();

        
        Console.WriteLine("Welcome to the journal program.");
        int userChoice = 0;
        while (userChoice != 5)

        {

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. write");
            Console.WriteLine("2. Display");

            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");

            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string choiceAnswer = Console.ReadLine();
            userChoice = int.Parse(choiceAnswer);
            if (userChoice == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                generator.GetRandomPrompt();


                Console.WriteLine(">");
                string _entryText = Console.ReadLine();
                Console.WriteLine(_entryText);
                Entry entry = new Entry();
                Journal myJournal = new Journal();
                myJournal._entries.Add(entry);
            }


            else if (userChoice == 2)
            {
                Journal written = new Journal();
                written.DisplayAll();
            }
            else if (userChoice == 3)
            {
                 
            }
        }
            
    }
            
}
            
            
            
        
            
                
                

                
                
            
                
            

            

            
            
            


            
                
            
        
        
            
        
        
        
        
        
        



                
                
                
                

            

            















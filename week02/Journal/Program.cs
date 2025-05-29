using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
       
       


        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to the journal program.");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, response));
                Console.WriteLine("Entry saved!\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save journal: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load journal: ");
                string loadFile = Console.ReadLine();
                journal.loadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                return;
            }
                         
            
            
               
            
        }
                
                
            
            
            
            
                 
            
                
        
            

            
        





        



            
           
                 
    }
            
            
}
            
            
            
        
            
                
                

                
                
            
                
            

            

            
            
            


            
                
            
        
        
            
        
        
        
        
        
        



                
                
                
                

            

            















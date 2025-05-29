using System.ComponentModel.DataAnnotations;



public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }


    

    

    






       

        
        

        

    
    
        


    
        
        

        

        















































}
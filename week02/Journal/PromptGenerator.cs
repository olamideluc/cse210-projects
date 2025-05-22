using System.ComponentModel.DataAnnotations;



public class PromptGenerator
{

    public List<Entry> _prompts = new List<Entry>();




    public string GetRandomPrompt()
        
    
    {
        PromptGenerator generator = new PromptGenerator();
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)]._promptText;
            
    }
        
        

        

    
    
        


    
        
        

        

        















































}
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntries)
    
    {
        Console.WriteLine(newEntries);
    }
    

    public void DisplayAll()
    {
        Console.WriteLine(_entries);
    }
    public void saveToFile(string file)
    {
        Console.WriteLine("What is your file name? ");
        string filename = Console.ReadLine();
        Console.WriteLine(filename);
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }
    public void loadFromFile(string file)
    {
        
    }

}

using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)


    {
        _entries.Add(newEntry);
    }


    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.\n");
             return;
         }
        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }
    public void loadFromFile(string file)
    {
        if (File.Exists(file))
        {
            Console.WriteLine("File not found. Please try again.\n");
            return;
        }
        _entries.Clear();
        foreach (var line in File.ReadLines(file))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]);
                entry._date = parts[0];
                 _entries.Add(entry);
             }

        }
        Console.WriteLine("Journal loaded successfully.\n");
    }

           

    

    
        
    
        
}
    
            
        
    

    
        
    

        


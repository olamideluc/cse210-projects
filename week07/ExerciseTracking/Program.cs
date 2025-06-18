using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities =
        {
            new Running("18 Jun 2025", 30, 4.8),
            new Cycling("18 Jun 2025", 45, 20.0),
            new Swimming("18 Jun 2025", 40, 20)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    
    }

}

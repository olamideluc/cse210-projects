public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void PromptForDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        PromptForDuration();
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! You've completed the activity.");
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Total duration: {_duration} seconds");
        ShowSpinner(3);
        Console.WriteLine("\nReturning to main menu...");
        ShowSpinner(2);
    }
    protected void ShowSpinner(int seconds)
    {
        Console.Write("Processing");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\nGo!");
    }
    public int GetDuration() => _duration;
}
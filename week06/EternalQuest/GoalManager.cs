class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        int type = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine() ?? "0");
        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine() ?? "0");
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available. Create a goal first.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine() ?? "0") - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            _score += _goals[choice].RecordEvent();
            Console.WriteLine($"Event recorded! New score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoals()
    {
        Console.WriteLine("\nYour Current Goals:");
        foreach (var goal in _goals)
        {
            string status = goal is EternalGoal ? "[ ] " : (goal.IsComplete() ? "[X] " : "[ ] ");
            Console.WriteLine($"{status}{goal.GetDetailsString()}");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }
        _goals.Clear();

        using StreamReader reader = new StreamReader(filename);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(",");
            _goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2])));
        }
        Console.WriteLine("Goals loaded successfully!");
    }
    public void RunMenu()
    {
        while (true)
        {
            Console.WriteLine($"\nCurrent Score: {_score}");
            Console.WriteLine("\nMENU OPTIONS:");
            Console.WriteLine("1 - Create New Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Save Goals");
            Console.WriteLine("4 - Load Goals");
            Console.WriteLine("5 - Record Event");
            Console.WriteLine("6 - Quit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
    
}


// Manages goals and user interaction
public class GoalManager{
    private int _score = 0; // Encapsulated score variable
    private List<Goal> _goals = new List<Goal>(); // Encapsulated list of goals

    public void AddScore(int points) => _score += points; // Adds to current score
    public int GetScore() => _score; // Gets current score

    public void AddGoal(Goal goal) => _goals.Add(goal); // Adds a new goal to the list

    // Main loop of the app
    public void Start(){
        bool running = true; // Controls loop

        while (running){ // Application loop
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Please! Select a choice from the menu: ");

            string input = Console.ReadLine(); // Get user choice

            switch (input){ // Handle choice
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
            }
        }
    }

    public void ListGoals(){
        for (int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}"); // List each goal
        }
    }

    public void CreateGoal(){
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("\n1. Simple\n2. Eternal\n3. Checklist");
        Console.Write("\nWhich type of Goals would you like to create? ");
        string type = Console.ReadLine(); // Type input

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine(); // Name input
        Console.Write("What is a brief description of it: ");
        string desc = Console.ReadLine(); // Description input
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine()); // Points input

        // Polymorphism in action: goal is added as base class type
        switch (type){
            case "1":
                AddGoal(new SimpleGoal(name, desc, points)); // Add simple goal
                break;
            case "2":
                AddGoal(new EternalGoal(name, desc, points)); // Add eternal goal
                break;
            case "3":
                Console.Write("Target times: ");
                int target = int.Parse(Console.ReadLine()); // Target input
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine()); // Bonus input
                AddGoal(new ChecklistGoal(name, desc, points, target, bonus)); // Add checklist goal
                break;
        }
    }

    public void RecordEvent(){
        ListGoals(); // Show list of goals
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1; // Get goal index

        if (index >= 0 && index < _goals.Count){
            // Calls overridden method on appropriate goal type - Polymorphism
            int earnedPoints = _goals[index].RecordEvent(this); // Record goal event
            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        }
    }

    public void SaveGoals(){
        Console.Write("File name to save: ");
        string filename = Console.ReadLine(); // Get filename

        using (StreamWriter sw = new StreamWriter(filename)){
            sw.WriteLine(_score); // Save score
            foreach (var goal in _goals){
                sw.WriteLine(goal.GetStringRepresentation()); // Save each goal
            }
        }
    }

    public void LoadGoals(){
    Console.Write("File name to load: "); // Prompt user for filename
    string filename = Console.ReadLine(); // Get filename from input

    if (!File.Exists(filename)) return; // Check if file exists, exit if it doesn't

    string[] lines = File.ReadAllLines(filename); // Read all lines from the file into an array
    _score = int.Parse(lines[0]); // Parse and set the score from the first line
    _goals.Clear(); // Clear the current list of goals to prepare for loading new ones

    // Loop through each line after the first to load goals
    for (int i = 1; i < lines.Length; i++){
        string[] parts = lines[i].Split(":"); // Split line into type and data
        string type = parts[0]; // Get goal type
        string[] data = parts[1].Split(","); // Split data fields

        switch (type){ // Check which goal type it is
        
            case "SimpleGoal": // If goal is SimpleGoal
                var sg = new SimpleGoal(data[0], data[1], int.Parse(data[2])); // Create new SimpleGoal
                sg.SetComplete(bool.Parse(data[3])); // Set its completion status
                AddGoal(sg); // Add to goal list
                break;

            case "EternalGoal": // If goal is EternalGoal
                AddGoal(new EternalGoal(data[0], data[1], int.Parse(data[2]))); // Directly add to goal list
                break;

            case "ChecklistGoal": // If goal is ChecklistGoal
                var cg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[4]), int.Parse(data[5])); // Create new ChecklistGoal
                cg.SetAmountCompleted(int.Parse(data[3])); // Set its amount completed
                AddGoal(cg); // Add to goal list
                break;
            }
        }
    }
}
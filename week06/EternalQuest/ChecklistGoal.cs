// Inherits from Goal (Inheritance)
public class ChecklistGoal : Goal{
    private int _amountCompleted; // Tracks number of completions
    private int _target; // Number of times goal must be completed
    private int _bonus; // Bonus points after completing target times

    // Constructor initializes checklist goal properties
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; // Start with 0 completions
    }

    // Polymorphic implementation of RecordEvent
    public override int RecordEvent(GoalManager manager){
        _amountCompleted++; // Increment completed count
        manager.AddScore(_points); // Add regular points
        int total = _points;
        if (_amountCompleted == _target){ // If completed enough times
            manager.AddScore(_bonus); // Add bonus points
            total +=_bonus;
        }
        return total; // Return total points earned
    }

    public override bool IsComplete() => _amountCompleted >= _target; // Complete if enough completions

    public override string GetDetailsString(){
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}"; // Display progress
    }

    public override string GetStringRepresentation(){
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}"; // Save format
    }

    public void SetAmountCompleted(int amount){
        _amountCompleted = amount; // Allows restoring state from file
    }
}
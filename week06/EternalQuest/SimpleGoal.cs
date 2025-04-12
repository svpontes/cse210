// Inherits from Goal (Inheritance)
public class SimpleGoal : Goal{

    private bool _isComplete = false; // Encapsulation of goal state

    // Constructor calls base class constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) {}

    public void SetComplete(bool complete){
        _isComplete = complete; // Allows setting complete status when loading from file
    }    

    // Overrides base method - Polymorphism
    public override int RecordEvent(GoalManager manager){
        if (!_isComplete){ // Only award points if not already complete
            _isComplete = true; // Mark goal as complete
            manager.AddScore(_points); // Add points to score
            return _points; // Return points earned
        }
        return 0; // No points if already complete
    }

    public override bool IsComplete(){
        return _isComplete; // Returns goal state
    }

    public override string GetDetailsString(){
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})"; // Display with check mark if complete
    }

    public override string GetStringRepresentation(){
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}"; // Save format
    }
}
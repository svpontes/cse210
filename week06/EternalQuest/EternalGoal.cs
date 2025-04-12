// Inherits from the base Goal class (Inheritance)
public class EternalGoal : Goal{
    // Constructor uses base class constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    // Overrides abstract method - Polymorphism
    public override int RecordEvent(GoalManager manager){
        manager.AddScore(_points); // Adds points to total score
        return _points; // Returns points earned
    }

    // Eternal goals never complete
    public override bool IsComplete() => false; // Always returns false

    public override string GetDetailsString(){
        return $"[ ] {_shortName} ({_description})"; // Details format for eternal goal
    }

    public override string GetStringRepresentation(){
        return $"EternalGoal:{_shortName},{_description},{_points}"; // Save format
    }
}
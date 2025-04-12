// Abstract base class representing a generic Goal.
// Uses encapsulation by keeping fields protected and exposing functionality through methods.
public abstract class Goal{
    protected string _shortName; // Goal name
    protected string _description; // Goal description
    protected int _points; // Points awarded for completing the goal

    // Constructor initializes common properties for all goals.
    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods enforce that derived classes must provide their own implementations.
    // This is an example of polymorphism.
    public abstract int RecordEvent(GoalManager manager); // Called when a goal event is recorded
    public abstract bool IsComplete(); // Returns whether the goal is complete
    public abstract string GetDetailsString(); // Provides a readable string for displaying the goal
    public abstract string GetStringRepresentation(); // Provides a string format suitable for saving/loading
}

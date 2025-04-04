public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing in and out slowly.\nClear your mind and focus on your breathing!\n"){
    }

    // Methods
    public void Run() {

        DisplayStartingMessage(); // Display the starting message for the activity

        DateTime startTime = DateTime.Now; // Start time of the activity
        DateTime endTime = startTime.AddSeconds(_duration); // End time based on user input

        // Continue the activity until the specified duration is reached
        while (DateTime.Now < endTime){
            // Display the "Breathe in..." message
            Console.WriteLine("Breathe in...");
            ShowCountDown(5); // Wait and show countdown for 5 seconds
            ShowSpinner(1); // Show spinner animation for a second
            
            // Display the "Breathe out..." message
            Console.WriteLine("Now breathe out...");
            ShowCountDown(5); // Wait and show countdown for 5 seconds
            ShowSpinner(1); // Show spinner animation for a second
        }

        DisplayEndingMessage(); // Display the finishing message after the activity ends
    }
} 
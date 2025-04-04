public class Activity{

    //atributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //constructor
    public Activity(string name, string description){

        _name = name;
        _description = description;
    }

    //methods

    public void DisplayStartingMessage(){

        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description);
    
        // Garante que o usuário insira um número válido (positivo)
        int duration;
        Console.Write("How long, in seconds, would you like for your session? ");
        
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid number of seconds: ");
        }

        _duration = duration; // Define a duração apenas após a validação
        Console.WriteLine("Get ready...");
        
        showSpinnerDots(10);
    }

    public void DisplayEndingMessage(){

        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        showSpinnerDots(10);
    }

    public void showSpinnerDots(int seconds){

        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds){

        // List of characters to create the spinner animation
        List<string> animationString = new List<string> { "|", "/", "-", "\\" };

        // Start and end times based on the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        while (DateTime.Now < endTime)
        {
            // Display the current spinner character
            Console.Write(animationString[i]);
            
            // Wait for 1 second before moving to the next spinner character
            Thread.Sleep(250);
            
            // Clear the previous character by overwriting it
            Console.Write("\b \b");

            // Move to the next spinner character
            i++;
            
            // If we've reached the end of the animation string, start from the beginning
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds) {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
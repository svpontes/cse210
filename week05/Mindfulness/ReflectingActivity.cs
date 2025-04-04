using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : Activity{

    // Attributes
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity() : base("Reflecting Activity", 
        "This activity will help you reflect on past experiences and gain insights from them. A set of four questions will interact with you to prompt reflections on your experiences. \nIf you want a complete set of questions, please type 'Y'. Otherwise press ENTER\n")  {

        // Initializing prompts and questions
        _prompts = new List<string>{

            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>{

            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Run method for Reflecting Activity
    public void Run(){

        DisplayStartingMessage(); // Display the starting message

        // Display a random prompt
        DisplayPrompt();
        //ShowSpinner(3); // Pause for 3 seconds

        // Ask for a full set of questions or keep the default 4
        Console.WriteLine("\nWould you like a complete set of questions to ponder? Type 'Y'. Otherwise press ENTER:\n");
        string userPick = Console.ReadLine()?.ToLower();

        int questionCount = userPick == "y" ? _questions.Count : 4;
        List<string> selectedQuestions = GetRandomQuestions(questionCount);

        Console.WriteLine("\nReflect on the following questions:\n");

        foreach (string question in selectedQuestions)
        {
            Console.WriteLine(question); // Display the question
            ShowSpinner(1); // Pause for reflection

            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine(); // Wait for user input
        }

        DisplayEndingMessage(); // Display the ending message
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt(){

        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    // Method to get a list of unique random questions (without repetition)
    public List<string> GetRandomQuestions(int count){

        if (count > _questions.Count)
        {
            count = _questions.Count; // Prevent exceeding available questions
        }

        return _questions.OrderBy(q => Guid.NewGuid()).Take(count).ToList(); // Shuffle & select
    }

    // Method to display a random prompt
    public void DisplayPrompt(){
        
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(GetRandomPrompt()); // Display a random prompt
    }
}
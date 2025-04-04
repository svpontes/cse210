using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Attributes
    private List<string> _prompts;
    private List<string> _availablePrompts;
    private List<Entry> _entries; // Stores entries with questions and answers
    private Random _random;
    
    // Constructor
    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list\nas many things as you can in a certain area.\n")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some moments this week that made you smile?",
            "What challenges have you overcome recently?",
            "Who has shown you kindness in your life?",
            "What are talents or hobbies that bring you joy?",
            "When was a time you felt truly at peace?",
            "What are some blessings you often take for granted?",
            "What meaningful conversations have you had lately?",
            "When have you felt guided or inspired recently?",
            "What acts of service have others done for you?",
            "What goals are you proud of having achieved?"

        };

        _entries = new List<Entry>(); // Initialize the list of entries
        _random = new Random(); // Initialize Random once
    }

    // Run Method
    public void Run()
    {
        DisplayStartingMessage();

        _availablePrompts = new List<string>(_prompts);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"\nConsider this prompt: {prompt}");
            ShowSpinner(2); // 

            Console.Write("Please type your answer: ");
            string userAnswer = Console.ReadLine();

            _entries.Add(new Entry(prompt, userAnswer));
        }

        DisplayEndingMessage();
        Console.WriteLine($"You have entered {_entries.Count} responses in total.\n");
    }
    
    // Method to get a random prompt from the list, avoiding repetition
    private string GetRandomPrompt(){

        if(_availablePrompts.Count == 0){

            _availablePrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_availablePrompts.Count);
        string selectedPrompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index); 
        return selectedPrompt;
    }

    // Return stored entries
    public List<Entry> GetEntries(){

        return _entries ?? new List<Entry>();
    }
}
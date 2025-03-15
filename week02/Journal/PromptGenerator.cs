using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What made you smile today?", //interval 0
        "Describe your favorite memory.",//1
        "What are you most grateful for?",//2
        "What’s a goal you achieved recently?"//3 totl 4
    };

    public string GetRandomPromptQuestion()
    {
        Random random = new Random();// Random - class of .NET it generates random numbers
        int index = random.Next(prompts.Count); //local variable index type int stores the index position of each item of the list. ramdon call method Next to generate random int number
                                                //.Count return the number of items in the list where prompts.Count is the superior limit. 4 questions: index 0, 1, 2, 3  total 4
        return prompts[index]; //[index] stores the randon index from the interval. 
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello World!");
       
       //C# Programming Exercise 1: Input and Output
       
        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}
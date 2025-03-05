using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // ask user for a grade
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);

        string letter = "";
        string sign = "";

        // Determine the grade letter
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // set signal "+" or "-"
        int lastDigit = number % 10;

        if (letter != "F") // Avoid F+ and F-
        {
            if (lastDigit >= 7 && letter != "A") // avoid A +
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // show results
        Console.WriteLine($"Your grade is {letter}{sign}");

        // verify student status
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass! Do not give up! Keep pursuing your goals!");
        }
    }
}

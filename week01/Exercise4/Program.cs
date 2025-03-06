using System;
using System.Collections.Generic;  // Import the Generic Collections namespace for using List<T>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // Declare a list to store the numbers entered by the user
        List<int> numbers = new List<int>();
        int inputNumbers; // Variable to store user input

        Console.WriteLine("Please enter the numbers! To see The Results: Type 0");
       
        // Loop to collect numbers from the user
        do{
            inputNumbers = int.Parse(Console.ReadLine()); // Convert user input from string to integer
         
            if(inputNumbers != 0){ // Avoid adding 0 to the list
                numbers.Add(inputNumbers);
            }
        }
        while(inputNumbers != 0); // Loop continues until user enters 0
        
        // Initialize variables for calculations
        int total = 0; // To store the sum of numbers
        int maxNumber = numbers[numbers.Count -1]; // Set the last entered number as max
        int minPositiveNumber = int.MaxValue; // Start with the maximum possible value
        
        // Iterate through the list to perform calculations
        foreach (int number in numbers)
        {
            total += number; // Add each number to the total sum
        
            // Find the maximum number
            if (number > maxNumber)
            {
                maxNumber = number;
            }

            // Find the smallest positive number
            if (number > 0 && number < minPositiveNumber)
            {
               minPositiveNumber = number;                
            }
        }  

        // Display results based on the total sum
        if (total == 0)
        {
            Console.WriteLine("End of The Program! ");
        }
        else
        {
            Console.WriteLine($"\nThe total returned is: {total}");
            
            // Calculate and display the average
            double average = (double)total / numbers.Count;
            Console.WriteLine($"The average is {average:F2}");

            // Display the maximum number
            Console.WriteLine($"The max number is {maxNumber}");

            // Display the smallest positive number
            Console.WriteLine($"The smallest positive number is {minPositiveNumber}");
        }

        // Display the sorted list of numbers entered by the user
        Console.Write("Numbers Added: ");
        Console.WriteLine(string.Join(", ", numbers));
    }
}  

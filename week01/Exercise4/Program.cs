using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //Ask the user for a series of numbers, and append each one to a list
        List<int> numbers = new List<int>();
        int inputNumbers;
        
        Console.WriteLine("Please enter the numbers! To see The Results: Type 0");
       
        do{
            inputNumbers = int.Parse(Console.ReadLine());
         
            if(inputNumbers != 0){ //avoid 0 to be added to the list
                numbers.Add(inputNumbers);
            }
        }
        while(inputNumbers != 0);

        //sum
        int total = 0;
        int maxNumber = numbers[0];
        int minPositiveNumber = int.MaxValue;
        foreach( int number in numbers){

            total += number;

            //max number
            if(number > maxNumber){
                maxNumber = number;
            }

            //minimam positive number
            if(number > 0 && number < minPositiveNumber){

               minPositiveNumber = number;                
            }
          
            if(total == 0){
                Console.WriteLine("End of The Program! ");
            }
            else{
                Console.WriteLine($"\nThe total returned is: {total}");
                //average
                double average = (double)total / numbers.Count;
                Console.WriteLine($"The average is {average}");
                //max number
                Console.WriteLine($"The max number is {maxNumber}");
                //min number
                Console.WriteLine($"The smallest positive number is {minPositiveNumber}");

            }
        }
    }
}  
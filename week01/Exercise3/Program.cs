using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //while loops, do-while, for, foreach
        //Program guess a number

        int gNumber; //guess number
        //int mNumber; //magic number
       
        //mNumber = int.Parse(Console.ReadLine());
        int count = 0; //counting guesses
        bool playAgain = true;
        
        while(playAgain){ //nested loop

            Random randomGenerator = new Random();//create a instance 
            int rNumber = randomGenerator.Next(1, 100);//generate a range of numbers
            Console.Write("Guess Number has been Generated!"); 

                do{
                Console.Write(" What is your guess? ");
                gNumber = int.Parse(Console.ReadLine());
                
                if(gNumber > rNumber){
                    Console.WriteLine("Lower");
                    }
                    else if (gNumber < rNumber){
                        Console.WriteLine("Higher");
                    }
                else{
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations! You guess it!");
                    
                }
                count ++;
                        
                
                } while(rNumber != gNumber);

            Console.WriteLine($"You guess {count} times!");
            Console.WriteLine("Do you want to play again? Y (Yes) N (no)");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "y");

            
        }
        
           
    }
}
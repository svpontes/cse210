using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello World! This is the Exercise5 Project.");
       
        //call function displayMessage
        string message = "Welcome to the Program!";
        DisplayMessage(message);
        
        //Call PromptUserName
        string userName;
        userName = PromptUserName();

        //call PromptUserNumber function
        int userFavNumber;
        userFavNumber = PromptUserNumber(); 

        //call SquareNumber function
        int squaredNumber;
        squaredNumber = SquareNumber(userFavNumber);

        //call DisplayResults functions
        DisplayResults(userName, squaredNumber);

        //**********functions. Assignment instructions. Write functions to:*******//

        //Displays the message, "Welcome to the Program!"
        static void DisplayMessage(string txt){

            Console.WriteLine(txt);
        } 
        
        //Asks for and returns the user's name (as a string)
        static string PromptUserName(){
            
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine(); //?? "";//avoid returning null if user just press enter. ?? means if null leave "" empty string

        }
         //Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber(){
            
            Console.WriteLine("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        //Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number){
             
            return number*number;
        }

        //Accepts the user's name and the squared number and displays them
        static void DisplayResults(string userName, int squaredName){

           Console.WriteLine($"Brother {userName}, the square of your favorite number is {squaredName}");
        }
    }
}
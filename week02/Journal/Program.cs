using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project!\n");
        //Instance of classes. Menu() responsable to interact with journal user 
        Menu menu = new Menu(); // create a instance of the class Menu()
        Journal journal = new Journal(); // create a instance of the class Journal() to Manage the user entries
        PromptGenerator promptGenerator = new PromptGenerator(); // create a instance of the class PromptGenerator() to generate random questions
        string userChoice; //variable used to receive the user choice 

        do
        {
            menu.DisplayMenu(); // show menu options
            userChoice = menu._userPick; // capture the user pick and store in userChoise

            switch (userChoice) //keep tracking user choice 
            {
                case "1": //"1 - Write" Generate randomly and wait for the user answer
                    string randomQuestion = promptGenerator.GetRandomPromptQuestion(); //local variable randomQuestion receives the return of the method GetRandomPromptQuestion. promptGenerator has the method GetRandomPromptQuestion()
                    Console.WriteLine($"\nRandom Question: {randomQuestion}");//show the random question stored in local variable randomQuestion
                    Console.WriteLine("Your Answer: ");
                    string userAnswer = Console.ReadLine();

                    journal.AddJournalEntries(randomQuestion, userAnswer); // add entries to the journal. variable that represents a instance of Journal() call method AddJournalEntries with two paramters
                    break;

                case "2": //display
                    journal.DisplayJournalEntries(); //journal call method DisplayJournalEntries()
                    break;

                case "3": // save
                    Console.WriteLine("\nEnter the filename to save (e.g., 'myJournal.txt'): ");
                    string saveFilename = Console.ReadLine(); //local variable saveFileName receives and store user input
                    journal.SaveFile(saveFilename);
                    break;

                case "4": // load user entries
                    Console.WriteLine("\nEnter the filename to load (e.g., 'myJournal.txt'): ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFile(loadFilename);
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the Journal Project. Goodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Please choose a valid number (1-5)."); //exception in case user entrie is diferent from (1-5)
                    break;
            }

        } while (userChoice != "5"); // condition to close the program
    }
}

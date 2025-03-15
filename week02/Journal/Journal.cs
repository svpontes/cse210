using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> journalEntries = new List<Entry>(); //journalEntries - list variable
    private string journalFolderPath; //local variable used to store folder path already set as "journal" folder in "MyDocuments"

    public Journal()
    {

        journalFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "journal"); //Path is a function from System.IO allow call Combine two string  

        if (!Directory.Exists(journalFolderPath))
        {
            Directory.CreateDirectory(journalFolderPath); // 
            Console.WriteLine($"Folder created: {journalFolderPath}");
        }
    }

    public void AddJournalEntries(string promptQuestion, string promptAnswer)
    {
        journalEntries.Add(new Entry(promptQuestion, promptAnswer));
        Console.WriteLine("Journal entry added successfully.\n");
    }

    public void DisplayJournalEntries()
    {
        if (journalEntries.Count == 0) //verify if the the entries stored in journalEntries == 0, which means empty
        {
            Console.WriteLine("Journal is empty!\n");
            return;
        }

        Console.WriteLine("\n---------- Journal ----------");
        foreach (var entry in journalEntries) //iterate trhough the elemets type "Entry" from journalEntries list. var entry indicates the compiler that every entry is type Entry
        {
            Console.WriteLine(entry.ToString());//ToString return
        }
    }

    public void SaveFile(string filename)
    {
        string fullPath = Path.Combine(journalFolderPath, filename); // full path to save the file. Ex: "C:\\Users\\User\\Documents\\journal" + filename "journal.txt"

        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            foreach (var entry in journalEntries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine($"Journal entries saved to '{fullPath}' successfully!\n");
    }

    public void LoadFile(string filename)//filename (parameter used to locate the stored file)
    {
        string fullPath = Path.Combine(journalFolderPath, filename); // full path to load the file. 

        if (File.Exists(fullPath))// File.Exist() return true or false(bool) if (fullPath) exist (true) or not(false)
        {
            journalEntries.Clear(); // clean the journal before open it
            string[] lines = File.ReadAllLines(fullPath); //the method File.ReadAllLines(fullPath) read all lines and store in the array lines
            string promptQuestion = ""; ////promptQuestion = "", promptAnswer = "" represents lines[0] first position - question and line[1] second position - answer 

            foreach (var line in lines) //iterate trough each line in the array lines
            {
                if (line.StartsWith("Question: ")) //.StartWith() - bool. Return a value that match the criteria ("Question:")
                {
                    promptQuestion = line.Substring(10);//Substring return the extracted string after the number of caracters in the parameter field. Ex: "question: " = 10 caracters including space. Display the string right after space
                }
                else if (line.StartsWith("Answer: "))
                {
                    string promptAnswer = line.Substring(8);
                    journalEntries.Add(new Entry(promptQuestion, promptAnswer));//create a new entry
                }
            }
            Console.WriteLine("Journal entries loaded successfully from '{fullPath}'.\n");
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found in the folder '{journalFolderPath}'.\n");
        }
    }
}

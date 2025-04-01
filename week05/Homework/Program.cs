using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        //call Trainning code

        Employee employee1 = new Employee("Jhon", 15000);
        employee1.DisplayData();

        //MAthAssignment
        MathAssignment mA1 = new MathAssignment("Samuel Bennet", "7.3", "Fractions", "3-10, 20-21");

        //WritingAssignment

        WritingAssignment wA1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

       Console.WriteLine($"{mA1.GetStudentName()} {mA1.GetTextSection()} {mA1.GetTopic()} {mA1.GetProblems()}");
       
       Console.WriteLine($"{wA1.GetSummary()} {wA1.GetWritingInformation()}");

    }
}
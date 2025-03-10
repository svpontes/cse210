using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

       Resume myResume = new Resume();
       myResume._name = "Allison Rose";

       myResume.displayResume();
       
       
       Job job1 = new Job(); //create an instance of the class Job

       job1._company = "Microsoft";
       job1._jobTitle = "Software Engineer";
       job1._startYear = 2019;
       job1._endYear = 2022;

       job1.DisplayJobDetails();

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job2.DisplayJobDetails();

        
    }
}
using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        // Add activities
        activities.Add(new Running("03 Nov 2022", 30, 4.8));        // 4.8 km
        activities.Add(new Cycling("04 Nov 2022", 45, 20));         // 20 kph
        activities.Add(new Swimming("05 Nov 2022", 30, 40));        // 40 laps

        // Display summaries
        foreach (Activity activity in activities){
            
            Console.WriteLine(activity.GetSummary());
        }
    }
}
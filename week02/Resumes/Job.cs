//design class Job
public class Job{
    //responsabilities
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    //constructor method. Allow creatig instances of the class Job. Invoked using the key word new
    public Job(){}

    //behaviors - method to display job details
    public void DisplayJobDetails(){

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

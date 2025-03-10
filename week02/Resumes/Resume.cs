public class Resume{

    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume(){}

    public void displayResume(){

        Console.WriteLine($"Name: {_name}");

        foreach(var job in _jobs){

            Console.WriteLine($"Jobs: \n{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }

}
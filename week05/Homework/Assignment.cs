public class Assignment{

    protected string _studentName = "";
    protected string _topic = "";

    public Assignment(string studentName, string topic){

        _studentName = studentName;
        _topic = topic;
    }

    //methods to get informations
    public string GetStudentName(){

        return _studentName;
    } 
    public string GetTopic(){

        return _topic;
    }
     //methods GetSummary() and GetWritingInformation()
   public string GetSummary(){

        return $"Student Name: {_studentName} Topic: {_topic}";
   }
}
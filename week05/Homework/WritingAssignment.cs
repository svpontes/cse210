using System.Runtime.InteropServices;

public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){

        _title = title;
    }
    
    public string GetWritingInformation(){

        return $"Student Name: {GetStudentName()} Title: {_title}";
    }

  }
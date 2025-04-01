public class MathAssignment : Assignment{

   
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment (string studentName, string topic, string textBookSection, string problems): base(studentName, topic){

        _textBookSection = textBookSection;
        _problems = problems;
    }
    //methods

    public string GetTextSection(){

        return _textBookSection;
    }
    public string GetProblems(){

        return _problems;
    }
    //method GetHomeworkList()
    public string GetHomeworkList(){

        return $"Section: {_textBookSection} Problem:{_problems}";
    }

}
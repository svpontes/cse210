using System;

public class Entry
{
    private string _date;
    private string _promptQuestion;
    private string _promptAnswer;

    public Entry(string promptQuestion, string promptAnswer)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptQuestion = promptQuestion;
        _promptAnswer = promptAnswer;
    }

    public string GetDate() => _date;//use of lambda expression to return directly the value of _date
    public string GetPromptQuestion() => _promptQuestion;
    public string GetPromptAnswer() => _promptAnswer;
   

    public override string ToString() //ToString() - method from class object (where all class derives from). Used to display a textual representation. Override allows personalized text representation, otherwise return text : name of the type object
    {
        return $"[{_date}]\nQuestion: {_promptQuestion}\nAnswer: {_promptAnswer}\n";//text pesonalized 
    }
}

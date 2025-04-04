public class Entry{
    
    private string _promptQuestion;
    private string _promptAnswer;
    private DateTime _date;

    // Constructor to initialize an Entry
    public Entry(string promptQuestion, string promptAnswer){
        _promptQuestion = promptQuestion;
        _promptAnswer = promptAnswer;
        _date = DateTime.Now; // Store the current date and time
    }

    // Getter for the prompt answer
    public string GetPromptAnswer() => _promptAnswer;

    // Override ToString() to return a formatted string
    public override string ToString(){

        return $"[{_date}]\nQuestion: {_promptQuestion}\nAnswer: {_promptAnswer}\n";
    }
}

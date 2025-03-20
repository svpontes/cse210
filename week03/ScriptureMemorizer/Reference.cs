public class Reference{

    string _book;
    int _chapter;
    int _verse;
    int? _endVerse;//int? allow null if the scripture reference has one verse. 

    //method constructor 
    public Reference(string book, int chapter, int verse, int? endVerse){

        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    } 
    //method to display book, chapter, verses
    public string DisplayReference(){

        if (_endVerse.HasValue){

            return $"[{_book}] [{_chapter}: {_verse} - {_endVerse}]";//output display format for an interval of verses "-"
        }
        else{
            return $"[{_book}] [{_chapter}: {_verse}]";//output display format for one verse
        }
    }
}
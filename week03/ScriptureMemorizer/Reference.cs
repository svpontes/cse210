public class Reference{

    private string _book;//Bible, Book of Mormon, Doctrines and Convenants, Pearl of Gret Price 
    private string _bookName;//ex: First Nefi
    private int _chapter;
    private int _verse;
    private int _endVerse;//allow checking for one verse or more verses

    //method constructor 
    public Reference(string book, string bookName, int chapter, int verse, int endVerse = -1){//set -1 to endVerse in case of there is no endVerse. 

        _book = book;
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    } 
    //method to display book, chapter, verses
    public string DisplayReference(){

        if (_endVerse != -1){

            return $"[{_book}] {_bookName} {_chapter}: {_verse}-{_endVerse}";//output display format for an interval of verses "-"
        }
        else{
            return $"[{_book}] {_bookName} {_chapter}: {_verse}";//output display format for one verse
        }
    }
}
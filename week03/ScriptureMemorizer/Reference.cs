// Class to represent a reference to a specific scripture, including the book, chapter, and verses
public class Reference {

    private string _book;        // Stores the name of the book (e.g., Bible, Book of Mormon, etc.)
    private string _bookName;    // Stores the specific name of the book (e.g., "First Nephi")
    private int _chapter;       // Stores the chapter number
    private int _verse;         // Stores the verse number
    private int _endVerse;      // Stores the end verse number (used if referencing a range of verses)

    // Constructor method to initialize a reference with the book, chapter, verse, and optionally the end verse
    // The endVerse parameter defaults to -1 if there is no end verse (used for a single verse)
    public Reference(string book, string bookName, int chapter, int verse, int endVerse = -1) {
        _book = book;            // Set the name of the book (e.g., "Bible")
        _bookName = bookName;    // Set the specific book name (e.g., "First Nephi")
        _chapter = chapter;      // Set the chapter number
        _verse = verse;          // Set the verse number
        _endVerse = endVerse;    // Set the end verse number, or -1 if no range is provided
    }

    // Method to display the reference in a human-readable format
    public string DisplayReference() {

        // If the endVerse is not -1, return a range of verses
        if (_endVerse != -1) {
            return $"[{_book}] {_bookName} {_chapter}: {_verse}-{_endVerse} "; // Format for displaying a range of verses
        }
        else {
            return $"[{_book}] {_bookName} {_chapter}: {_verse} ";  // Format for displaying a single verse
        }
    }
}

// Class to control the actions of displaying text (scripture), hiding words, and checking if all words are hidden
public class Scripture {

    // Store an object of the class Reference that holds information about the book, chapter, verse, and endVerse
    // The variable _reference is of type Reference and will hold the scripture reference details
    private Reference _reference;
    
    // Variable _words stores a list of objects of type Word, where each word represents an individual word in the scripture text
    private List<Word> _words;

    // Constructor method
    // This method initializes a Scripture object with a reference (book, chapter, verse, etc.) and the text of the scripture
    public Scripture(Reference reference, string text){

        // Store the reference object (contains details like book, chapter, verse, etc.)
        _reference = reference;

        // Split the given text into words using space (' ') as a delimiter
        // The Split method breaks the input string into words wherever there is a space
        // For each word, create a new Word object and add it to the _words list
        // The .Select method applies the Word constructor to each individual word, and .ToList() converts the result into a list
        _words = text.Split(' ')            // Split the text by spaces
                     .Select(word => new Word(word))   // For each word, create a new Word object
                     .ToList();                  // Convert the sequence to a List and store it in _words

    } 

    // Method to hide a random number of words in the scripture
    // This method randomly selects words and hides them (replaces them with underscores)
    public void hideRandomWords(int numberToHide){

        // Create a new Random object to generate random numbers
        Random random = new Random();

        // Filter out the words that are already hidden and store the remaining visible words
        //_words list of words
        //variable "w" each object word of the list
        //! used to invert positive to negative. !w.isHidden() keep in the list only visible words
        //ToList() convert the result of filtering in a used manipulated list
        //var (class System.Collections.Generic.List<T>) allow itens to be accessed by index
        var visibleWords = _words.Where(w => !w.isHidden()).ToList(); //visibleWords store only visible words

        //numberToHide receive the number of words to be hidden
        // Calculate how many words should be hidden (the minimum of the requested number and the number of visible words)
        //Math.Min return the minimun value beteween two number ( first number: numberToHide, second number: visibleWords.Count)
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);//avoid hide more than setted number of words to be hidden

        // for Loop to hide the calculated number of words
        for(int i = 0; i < wordsToHide; i++){
            // Select a random index from the list of visible words
            int index = random.Next(visibleWords.Count);

            // Hide the selected word by calling its Hide method
            visibleWords[index].Hide();

            // Remove the hidden word from the list of visible words
            visibleWords.RemoveAt(index);
        }
    }

    // Method to get the formatted display text (the reference and the scripture text)
    // This method will return the full scripture, including the reference (book, chapter, verse) and the formatted text
    public string GetDisplayText(){

        // Create a string with all the words' display text (each word's visibility status is checked)
        string textFormatted = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        // Combine the reference and the formatted text into one string and return it
        return $"{_reference.DisplayReference()}{textFormatted}";
    }

    // Method to check if all words in the scripture are hidden
    // This method returns true if all the words have been hidden, otherwise false
    public bool TextIsTotallyHidden(){

        // Check if all words in the _words list are hidden using the .All LINQ method
        // If any word is visible (i.e., not hidden), the method will return false
        return _words.All(w => w.isHidden());
    }
}
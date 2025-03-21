// Class to represent each word of the chapter and control if it is visible or hidden
public class Word {

    private string _text;     // Stores the actual word as a string
    private bool _isHidden;   // Stores whether the word is hidden (true) or visible (false)

    // Constructor method that initializes the word and its visibility state
    public Word(string text) {
        _text = text;            // Set the word's text
        _isHidden = false;       // Initially, the word is visible (not hidden)
    }

    // Method to hide the word (makes the word hidden)
    public void Hide() {
        _isHidden = true;        // Change the state to hidden (true)
    }

    // Method to show the word again (makes the word visible)
    public void Show() {
        _isHidden = false;       // Change the state to visible (false)
    }

    // Method to check if the word is hidden
    public bool isHidden() {
        return _isHidden;        // Returns true if the word is hidden, false otherwise
    }

    // Method to get the display text of the word
    // If the word is hidden, it returns underscores instead of the word
    // If the word is visible, it returns the word as it is
    public string GetDisplayText() {
        return _isHidden ? new string('_', _text.Length) : _text;  // If hidden, return underscores, else return the word
    }
}
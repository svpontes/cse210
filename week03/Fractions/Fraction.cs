public class Fraction{

    private int _top;
    private int _bottom;

   // Constructor with no parameters - initializes fraction to 1/1
   
    public Fraction(){
        _top = 1;
        _bottom = 1;
        
    }
    // Constructor with one parameter - initializes fraction to top/1
    public Fraction(int top){

        _top = top;
        _bottom = 1;
    }
    // Constructor with two parameters - initializes fraction to top/bottom
    public Fraction(int top, int bottom){

        _top = top;
        _bottom = bottom;
    }
//getter and setter for variable member _top
    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){

        _top = top;
    }
//getter and setter for variable member _bottom
    public int GetBottom(){
        return _bottom;
    }

    public void Set_Bottom(int bottom){

        _bottom = bottom;
    }
    //display fractions them to the console
    public void DisplayFraction(){
        Console.WriteLine($"{_top}/{_bottom}");
    }
    // Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString(int _top, int _bottom){
        
        return $"{_top}/{_bottom}";
       
    }
//Create a method called GetDecimalValue that returns a double that 
// is the result of dividing the top number by the bottom number, such as 0.75.

    public double GetDecimalValue(){

        return (double)_top/_bottom;
    }

}
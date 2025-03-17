using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Using the first constructor (1/1)
        Fraction fraction = new Fraction();

        // Using the second constructor (6/1)
        Fraction fraction1 = new Fraction(6);

        // Using the third constructor (6/7)
        Fraction fraction2 = new Fraction(6, 7);
        // Using the third constructor (3/4)
         Fraction fraction3 = new Fraction(1, 3);

    //call all of these methods and get the values
        fraction.DisplayFraction();
        fraction1.DisplayFraction();
        fraction2.DisplayFraction();
        fraction3.DisplayFraction();

    //call method to return fraction as a string
        Console.WriteLine(fraction.GetFractionString(3, 4));

    //call method GetDecimalValue with result 0.75 from fraction3 values
        
        Console.WriteLine(fraction3.GetDecimalValue());
    }
       
}
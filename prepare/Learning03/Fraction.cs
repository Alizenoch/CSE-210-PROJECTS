using System;
    // Step3. the fraction class.
    //1. Created a class to hold a fraction
    //2. This class has its own file named "Fraction.cs". 
public class Fraction
    //3. The class two attributes 
    //4. There are private.
{
    private int _top;
    private int _bottom;


    //Step 4: Created Constructors

    //Constructor that has no parameters that initializes the number to 1/1
    public  Fraction()
    { 
        // Default value set to 1/1
        _top = 1;
        _bottom = 1;

    }
    // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1
    public Fraction(int wholeNumber) 
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom )
    {
        _top = top;
        _bottom = bottom; 
    }
     // Step 5:Create the Getters and Setters
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        //Create methods to return the representations
        return text;
    }
    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        //Create methods to return the representations
        return (double)_top / (double)_bottom;
    }

}    


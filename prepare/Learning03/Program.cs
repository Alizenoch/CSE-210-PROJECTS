using System;

class Program
{
    static void Main(string[] args)
    //In your Program.cs file, verify that you can create fractions using all three of these constructors.  
     
    {
        //For example, create an instance for 1/1 (using the first constructor)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue()); 

        //for 6/1 (using the second constructor)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //using the third constructor
        Fraction f3 =  new Fraction (3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    }
}
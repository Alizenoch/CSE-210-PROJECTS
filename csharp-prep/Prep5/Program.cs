using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName(); 
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    
    }

    private static int SquareNumber(int userNumber)
    {
        throw new NotImplementedException();
    }

    private static string PromptUserName()
    {
        throw new NotImplementedException();
    }

    private static int PromptUserNumber()
    {
        throw new NotImplementedException();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }  
        
    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();

        return name;
     }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
        
}
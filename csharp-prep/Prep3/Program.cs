using System;

class Program
{
    static void Main(string[] args)
    {
        // For parts 1 and 2, where the user specified the number...
        // Console.write("What is the magic nnumber? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // For part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101); 

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it");
            }

        }


          }
}     
    
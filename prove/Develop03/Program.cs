using System;
using System.Collections.Generic;

namespace  Scripturememorizer
{

}
    public class ScriptureMemorizer
{
    private Scripture scripture;

    public ScriptureMemorizer(string reference, string text)
    {
        scripture = new Scripture(reference, text);
    }

    public void Run()
    {
        // Your code to interact with the user and display/hide scripture
    }
}



    class Scripture
    {
        public string Reference {get;}  
        public string Text {get;}

        public Scripture(string Reference, string Text)
        {
        Reference = reference;
        Text = text;
        }
        public string HideWords(int numWords)
        {
        var words = Text.Split();
        var randon = new Random();

        for (int i=0,i<numWords;i++)
        
        
    }
  






    class Program
    {
        static void Main(string[] args)
        {
            // Created a sample scripture
            var sampleScripture = new Scripture("Philippians 4:13","I can do all things through Christ who strenghtens me!")  
        
            Console.WriteLine("Welcome  to Scripture Memorizer!");
            Console.WriteLine($"Reference:{sampleScripture.Reference}");
            Console.WriteLine($"Text: {sampleScripture.Text}");
            Console.WriteLine($"Press Enter to hide words (type 'quit' to exit)."); 
            

            var words = sampleScripture.Text.Split( '' );
            var random = new Random();

            while (true)
            {
                var input = 
                Console.ReadLine().Trim().ToLower();
                if (input =="quit")
                    break;

                    // Hide a few random words
                    var hiddenWords = words.OrderBy(_ =>
                random.Next()).Take(words.Length / 4);
                

                    Console.Clear();
                    Console.WriteLine($"Reference:{sampleScripture.Reference}");
                    foreach (var word in words)
                    {
                        if (hiddenWords.Contains(word))
                            
                            Console.Write("*****");
                        else
                            Console.WriteLine("\nPress Enter to continue(type 'quit' to exit).");    
                    }

                    Console.WriteLine("Thank you for using Scripture Memorizer!");
        }    } 
    }
}



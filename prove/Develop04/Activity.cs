using System;

      // This is the base class file that I created for the Activity class. 
      // And the base class 
   public class Activity
   {
      // All member variables are private.
      protected string _activityName;
      protected int _duration;



      //  Methods
      // This is the method to display the starting message.  
      public virtual void DisplayStartingMessage()
         {
            Console.Clear();
            ShowSpinner();
            Console.Clear();
            Console.WriteLine($"Welcome to {_activityName} activity!");
            Console.WriteLine($"\nThis activity will help you to focus and relax.");
            Console.WriteLine("\n Enter the duration in seconds:");
            _duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n Prepare to begin...");
            Thread.Sleep(3000);

         }     
      // Then the method to display the ending message
      public virtual void DisplayEndingMessage()
         {
            Console.WriteLine($"\nWell Done, you have completed the {_activityName} activity.");
            Console.WriteLine($"\nDuration: {_duration} seconds");
            Thread.Sleep(3000); 
         } 
      // This method is for a spinner, it stimulates work.
      // where it waits for a specified duration.     
      static void ShowSpinner( int seconds)
         {
           string[] spinnerChars = {"-", "\\", "|", "\\"};
           int iterations = 2;

           for (int i = 0; i< iterations;i++);
           {
            foreach (var C in spinnerChars)
            {
               Console.Write(C + "\n");
               Thread.Sleep(250);
            }

           }
           Console.WriteLine();// moves to the next line after the spinner.
         } 
         
      public void ShowCountDown(int seconds)
         {
            while (seconds > 0);
            {
               Console.Write(seconds);
               Thread.Sleep(1000); // wait for a second
               seconds--;
               Console.Write("\b \b");
            }
            
         }
         

   }         
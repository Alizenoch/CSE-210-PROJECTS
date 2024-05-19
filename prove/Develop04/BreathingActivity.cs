using System;
using System.ComponentModel;


// This is the 2nd file with the BreathingActivity class 
// The BreathingActivity class inherits all it member variables from the Activity class
// as shown below with a colon 

public class BreathingActivity : Activity
    {
        // Constructor
        public BreathingActivity()
        {
          _activityName = "Breathing";
        }
          //Methods

        public override void StartActivity()
          {
            base.Activity();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            Console.WriteLine("This exercise will guide you.");
            Console.WriteLine("Relax and focus");

          

            while (DateTime.Now < EndTime)
          {
             
             Console.Write("\nBreath in...");
             Countdown(5);// count down for 5 seconds
             Console.Write("\nBreath out...");
             Countdown(3);// count down for 3 seconds.
             Console.WriteLine();

          }

          EndActivity();

      }  

    }
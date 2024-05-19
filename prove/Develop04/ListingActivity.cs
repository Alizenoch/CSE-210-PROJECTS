using System;

  // This is the third file 
  // I created the ListingActivity class
  // It inherits the member variables from Activity as showw below by the Colon (:)
  public class ListingActivity : Activity
    {
        // The member variables are private
        
        private string[] _listingPrompts =
        {
          "Who are the people that you appreciate?",
          "What are your pensonal strenghts?",
          "Who did  you help this week?",
          "When have you felt the prompting of the holy Spirit?",
          "Who are some of your heros in the Book of Mormon?"
           
        };


        // Constructors-means to put the member variables above into parameters.

        public ListingActivity()
          
        {
          _activityName = "Listing";
        }    

        // Methods- These are the methods that will run the Listing Activity.

         public  override void StartActiviyt()
         {
          base.StartActivity();
          DateTime endTime = DateTime.Now.AddSeconds(_duration);
            Console.WriteLine("This activity will help to clear your mmind");
            Thread.Sleep(3000);

            Random rand = new Random();


            while(DateTime.Now<endTime);
            {
              string prompt = _listingPrompts[rand.Next(_listingPrompts.Length)];
              Console.WriteLine(prompt);
              Console.WriteLine();
              Countdown(3);

              Console.WriteLine(" Start listing your items...");

              int itemCount = 0;
              while (DateTime.Now<endTime)//loop for listing  item within the duration
              {
                 string input = Console.ReadLine();//take user input for an item
                 if(!string.IsNullOrEmpty(input)) // checks if input is not empty
                 {
                   itemCount ++;
                 }   
                 else
                 {
                  Console.WriteLine("Item added. Press enter to add more item or wait for the activity to end");
                  break;
                 }  
              }
              Console.WriteLine("Number of items listed:" + itemCount);
              if (DateTime.Now>=endTime)// check if its  time to exist the main activity loop.
                  break;
            }
            EndActivity();
         }
       
    }
using System;



    // This is the fourth file
    // I created the ReflectingActivity Class
    // It also inherits from the Activity class 
    public class ReflectingActivity: Activity
        {
        // The member variables are private
            private List<string> _prompts = new List<string>
            {
              "Think of a time when you stood for some else.",
              "Think of a time when you did something difficult.",
              " Think of a time when you helped someone in need.",
              " Think of a time when you did somthing selfless.",
              " Think of a time when you failed at something."
            };
            private List<string> _questions = new List<string>
            {
              "Why was experience meaningful to you?",
              " Have you done anything like this before?",
              " How did you get started?",
              " How did you feel when it was complete?",
              "What made this different than other times when you were not as successful?",
              "What is your favorite thing about this experience?",
              "How can you keep this experience in mind in the future?",
              " What was your motivation?"
            };
            private List<string> _useQuestionsList = new List<string>();
            private string _prompt;
            private string _question;
            private string _description = "This activity will help you reflect on times in your life";

        //Constructor - put these member variables of the above class into parameters

        ReflectingActivity(string activityName, int activityTime)
        :base(activityName, activityTime)
        {
        
        } 
        
        // Methods - These methods run the Reflecting Activities.
        public void GetActivityDescription()
        {
             Console.WriteLine("_description");
        }


        private string GetRandomPrompt()
        {
          var random = new Random();
          int index = random.Next(_promptList.Count);
          return _promptList[index];  
        } 

        private string GetRandomQuestion()
        {
          var random = new Random();
          int index = random.Next(_useQuestionsList.Count);
          return _useQuestionsList[index];

        }

        public void DisplayPrompt(int seconds)
        {
          Console.WriteLine(); //insert blank line to start.
          var prompt = GetRandomPrompt();
          Console.WriteLine("\nConsider the following prompt:");
          Console.WriteLine($"\n----{prompt}---");
          Console.WriteLine($"\nwhen you have somthing in mind,press enter to continue");

          var input = Console.ReadKey();

          if(input.Key==ConsoleKey.Enter)
          
          {
            ShowQuestion(seconds);
          } 
        }

        // Method to display questions
        public void GetQuestions(int seconds)
        {
          _useQuestionsList.AddRange(_useQuestionsList); //create a new list that can be destroyed each time
        
          Spinner spinner = new Spinner();
          
            Console.WriteLine($"\nNow ponder on each of the following question that are related to this experience");
            Countdown(8);
            Console.Clear();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            while(timer.Elasped.TotalSeconds < seconds)
            {
              if (_useQuestionsList.Count ! = 0)
              {
                var question = GetRandomQuestion();
                Console.Write($"\n>>{question} ");
                _useQuestionsList.Remove(question);// removes questions from the list so it can be used again.
              }
              spinner.ShowSpinner();
            }
            timer.Stop();
        } 
   
   
   
   
   
   
    }

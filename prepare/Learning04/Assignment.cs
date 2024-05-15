using System;
namespace library_demo
{
     // I created a base class Assignment.
    public class Assignment
    {
        // I added the attributes as private member variables.
         private string _studentName;
        private string _topic;

        // I created a constructor for this class that receives a student name and topic and sets the member variables.

         public Assignment(string studentName, string topic)
         {
            _studentName = studentName;
            _topic = topic;
         }
        // I added a method for GetSummary() to return the student's name and the topic.  

        // But before that,I will set the getters here to access the private member variables 
        public string GetStudentName()
        {
           return _studentName;  
        }
        public string GetTopic()
        {
            return _topic;
        }

        public string GetSummary()
        {
            return _studentName + " - " + _topic; 
        }


    
    }
}    
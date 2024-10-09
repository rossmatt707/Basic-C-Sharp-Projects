using System;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args) // entry point for program
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report."); // Writes initial greetings and title

            Console.WriteLine("What is your name?"); // Writes initial question
            string userName = Console.ReadLine(); // gets user input and stores as variable
            Console.WriteLine("Hello " + userName + " hope you\'re doing well!"); // uses variable to send personalized message back to user.

            Console.WriteLine("What course are you on?"); // Writes initial question
            string courseName = Console.ReadLine(); // gets user input and stores as variable
            Console.WriteLine(courseName + ".. sounds interesting!"); // uses variable to send personalized message back to user.

            Console.WriteLine("What page number?"); // Writes initial question
            int pageNumber = int.Parse(Console.ReadLine()); //Convert input to int for a simple short number
            Console.WriteLine(pageNumber + ", making progress."); // uses variable to send personalized message back to user.

            bool inputValid = false; //varaible to track whether user input is valid.
            bool userHelpBool = false; //declares variable

            while (!inputValid) //This will loop until the variable is true
            {
                Console.WriteLine("Do you need help with anything? (please answer \"true\" or \"false\".)"); // Writes initial question with exit \ for quotes.
                string userHelp = Console.ReadLine(); // gets user input and stores as variable

                if (bool.TryParse(userHelp, out userHelpBool)) // attempts to parse variable as Boolean value and stores as new variable if succesful.
                {
                    inputValid = true; //valid input exits loop.
                }
                else
                {
                    Console.WriteLine("Input is not valid. Please enter  \"true\" or \"false\"."); //invalid input displays this message and restarts loop.
                }
            }
            
            if (userHelpBool == true) // if boolean value is true responds with specific message
            {
                Console.WriteLine("We\'ll get you some help with that.");
            }
            else
            {
                Console.WriteLine("Glad you\'re figuring everything out. \nLet us know if you need help at any point."); // if boolean value is false responds with specific message
            }
          
           
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics."); // Writes initial greetings and title
            string userDetails = Console.ReadLine(); // gets user input and stores as variable
            Console.WriteLine(userDetails + "... thanks for the details!"); // uses variable to send personalized message back to user.

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific."); // Writes initial greetings and title
            string userFeedback = Console.ReadLine(); // gets user input and stores as variable
            Console.WriteLine(userFeedback + "... thanks for the feedback!"); // uses variable to send personalized message back to user.

            Console.WriteLine("How many hours did you study today?"); // Writes initial greetings and title
            int hoursStudied = int.Parse(Console.ReadLine()); //Convert input to int for a simple short number
            Console.WriteLine(hoursStudied + ".. strong work."); // uses converted variable to send personalized message back to user.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); // Ending message for program
        }
    }
}

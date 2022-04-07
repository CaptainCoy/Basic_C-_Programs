using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            string school = "The Tech Academy";  // I made this a string in case I wanted to re-use the school name somewhere.
            Console.WriteLine(school + "\nStudent Daily Report:");  // Using the "School" string in the intro line.  
            //Console.ReadLine(); // I commented this line out because ?I felt it unnessisary to have to hit enter without any input.
                                                                            

            Console.WriteLine("\n\nWhat is your name?");  // This displays the first question. Also added a couple line breaks for better optics 
            string studentName = Console.ReadLine();  // This allows user to enter their name.

            Console.WriteLine("What course are you on?");  // This displays the second question.
            string course = Console.ReadLine();  // Again user input, this time for the course.

            Console.WriteLine("What page number?");  // The next 4 sections are the same question/answer format for the rest of the program
            string page = Console.ReadLine();  // Answer.

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");  // Question.
            string help = Console.ReadLine();  // Answer.

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");  // Question.
            string happy = Console.ReadLine();  // Answer.

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");  // Question.
            string feedBack = Console.ReadLine();  // Answer.

            Console.WriteLine("How many hours did you study today?");  //Question.
            string studyTime = Console.ReadLine();  // Answer.

            Console.WriteLine("\n\nThank you for your answers. An instructor will respond to this shortly. Have a great day\n" + school);  // Here is the message to the user letting them know that the questionaire is over. I added a couple line breaks again for looks, and used the "school" string again.
            Console.ReadLine();  // This keeps everything displayed until the user hits enter again.

        }
    }
}

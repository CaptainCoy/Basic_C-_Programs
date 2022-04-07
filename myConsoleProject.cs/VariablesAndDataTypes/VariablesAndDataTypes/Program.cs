using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.WriteLine("Your favorite number + 5 is: " + total);
            Console.ReadLine();

        }
    }
}

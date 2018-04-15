using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character length count
            String userInputString;
            Console.WriteLine("Please Enter your input String");
            userInputString = Console.ReadLine();
      
            //Incase Empty input is entered.
            if (userInputString.Length == 0 || userInputString == " ")
            {
                Console.WriteLine("Please enter a character");
                
            }
            else
            {
                Console.WriteLine(userInputString + " has " + userInputString.Length + " characters.");
            }
            



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace printingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Quotes
            //Creating variables
            String userQuote;
            String author;
            String output;
            //User Instructions and getting user input
            Console.WriteLine("Please, what is the quote?");
            userQuote = Console.ReadLine();
            Console.WriteLine("Please, who is the author?");
            author = Console.ReadLine();
            // Console.WriteLine(author + says, " + "\" + userQuote + "\"); 
            Console.WriteLine(author + " says, \""+ userQuote +"\"");
            Console.WriteLine($"{author} says, \"{userQuote}\"");
        }
    }
}

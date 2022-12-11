using System;
using Cafe.StateFolder;

namespace Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to a M.A cafe \n");
            Details details = new Details();
            string c = "y";
            while (c == "y"|| c=="Y")
            {
                details.Detail();
                Console.WriteLine(" \nIs there another customer? Y/N");
                c = Console.ReadLine();
            }
            
            
        }
    }
}

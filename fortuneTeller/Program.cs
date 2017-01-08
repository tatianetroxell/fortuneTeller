using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Birth Month (Please enter a number): ");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Favorite ROYGBIV color (Please enter \"HELP\" for a list of the ROYGBIV colors: ");
            string colorAnswer = Console.ReadLine();
            string color;



            if (colorAnswer == "help")
            {
                Console.WriteLine("The ROYGBIV colors are:\n red\n orange\n yellow\n gree\n blue\n indigo\n violet");
                Console.WriteLine("Please enter your favorite: ");
                color = Console.ReadLine();
            }
            else
            {
                color = colorAnswer;
            }

            Console.WriteLine("How many siblings to you have: ");
            int siblings = int.Parse(Console.ReadLine());

        }
    }
}

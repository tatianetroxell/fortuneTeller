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
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int oddOrEven = age % 2;
            int yearsToRetire;
            if (oddOrEven == 0)
            {
                yearsToRetire = 60 - age;
            }
            else
            {
                yearsToRetire = 65 - age;
            }

            Console.WriteLine("Please enter your birth month (Please enter numbers only): ");
            int birthMonth = int.Parse(Console.ReadLine());

            float money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 150000.00f;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 750000.00f;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 80000.00f;
            }
            else
            {
                money = 0.00f;
            }

            Console.WriteLine("Please enter your favorite ROYGBIV color (Please enter \"HELP\" for a list of the ROYGBIV colors): ");
            string colorAnswer = Console.ReadLine();
            colorAnswer = colorAnswer.ToLower();
            string color;

            if (colorAnswer == "help")
            {
                Console.WriteLine("The ROYGBIV colors are:\n red\n orange\n yellow\n green\n blue\n indigo\n violet");
                Console.WriteLine("Please enter your favorite: ");
                color = Console.ReadLine();
            }
            else if (colorAnswer == "red" || colorAnswer == "orange" || colorAnswer == "yellow" || colorAnswer == "green" || colorAnswer == "blue" || colorAnswer == "indigo" || colorAnswer == "violet")
            {
                color = colorAnswer;
            }
            else
            {
                Console.WriteLine("Invalid Color. Please enter one of the following:");
                Console.WriteLine(" red\n orange\n yellow\n green\n blue\n indigo\n violet");
                color = Console.ReadLine();
            }

            color = color.ToLower();

            string transportation;

            if (color == "red")
            {
                transportation = "car";
            }
            else if (color == "orange")
            {
                transportation = "boat";
            }
            else if (color == "yellow")
            {
                transportation = "plane";
            }
            else if (color == "green")
            {
                transportation = "motorcycle";
            }
            else if (color == "blue")
            {
                transportation = "bicycle";
            }
            else if (color == "indigo")
            {
                transportation = "bus";
            }
            else
            {
                transportation = "truck";
            }

            Console.WriteLine("How many siblings to you have: ");
            int siblings = int.Parse(Console.ReadLine());

            string vacationLocation;

            if (siblings < 0)
            {
                vacationLocation = "the dog house";
            }
            else if (siblings == 0)
            {
                vacationLocation = "Florida";
            }
            else if(siblings == 1)
            {
                vacationLocation = "Mexico";
            }
            else if(siblings == 2)
            {
                vacationLocation = "Brazil";
            }
            else if (siblings == 3)
            {
                vacationLocation = "New Zealand";
            }
            else
            {
                vacationLocation = "Australia";
            }

            Console.WriteLine();
            Console.WriteLine("Your Fortune:");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetire + " years, with $" + money + " in the bank, a vacation home in " + vacationLocation + " and a " + transportation + " as mode of transportation.");

        }
    }
}

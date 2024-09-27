using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of Strings
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            Console.WriteLine("Slect a umber between 0 and 9");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("or favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("sorry, that number selection is invalid. Please select a number between 0 and 9.");
                }
                stringSelect = Convert.ToInt32(Console.ReadLine());
            }

            List<string> occupationList = new List<string>()
            {
                "Data Analist",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcost Host",
                "Softwear Developer",
                "QA Tester"
            };
            Console.WriteLine("\n Select another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is  " + occupationList[listSelect]);
                    validList = true;
                }
                catch
                {
                    Console.WriteLine("sorry, that number selection is invalid. Please select a number between 0 and 9.");
                }
                 listSelect = Convert.ToInt32(Console.ReadLine());
            }
            int[] intArray = { 17,22,3,67,5,91,11,42,23,6};
            Console.WriteLine("\n Select a third number between 0 and 9");
            int intSelect=Convert.ToInt32(Console.ReadLine());
            bool valdInt = false;

            while (!valdInt)
            {
                try
                {
                    Console.WriteLine("Your Lucky number is " + intArray[intSelect]); 
                    valdInt = true;
                }
                catch
                {
                    Console.WriteLine("sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();

        }
    }
}
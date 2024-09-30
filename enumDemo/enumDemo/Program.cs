using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ans=false;
            while (!ans) 
            {
                try
                {
                    // Read an input the current day of the week
                    Console.WriteLine("Enter the current day of the week");
                    string userAns=Console.ReadLine();

                    //Assign the value to a varible named day have enum data type
                    daysoftheweek day=(daysoftheweek)Enum.Parse(typeof(daysoftheweek), userAns);
                    Console.WriteLine(day);
                    Console.ReadLine();
                    ans=true;

                }
                catch(ArgumentException e) 
                { 
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }

        }
        // Define an Enum named dayoftheweek
        public enum daysoftheweek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday      
        }
    }
}

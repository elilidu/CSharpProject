using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryandCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read user age as an input , convert into integer and stor the valu in age variable
            Console.WriteLine("Enter your age ");
           var age=Convert.ToInt32(Console.ReadLine());
            // cotrol an error
            try
            {
                //get the current date with time and assigned the valu in date variable
                DateTime date = DateTime.Now;

                //select only year from date variable and assign in bdate
                int bdate= (Convert.ToInt32(date.Year)- age);
                Console.WriteLine(bdate);
                Console.ReadLine();
            }
            // control format error
            catch (FormatException Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }
            // control General error
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                Console.ReadLine();
            }
        }
    }
}

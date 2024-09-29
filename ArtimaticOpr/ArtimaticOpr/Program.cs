using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtimaticOpr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program calculate the Area, volume and peremter of the square");
            Console.WriteLine("Enter the Firest Number");

            //Read the Firest number
            int Fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");

            //Read the second number
            int Snum = Convert.ToInt32(Console.ReadLine());

            // call the addition method and Assigne the result
            int Aresult = CalArtimatic.Artimic(Fnum, Snum);
            Console.WriteLine("The Sum is\t" + Aresult);

            // call the addition method and Assigne the result
            int Sresult = CalArtimatic.Artimic(7.5, 3.2);
            Console.WriteLine("The Diffrence is\t" + Sresult);


            // call the addition method and Assigne the result
            int Sqresult = CalArtimatic.Artimic("4");
            Console.WriteLine("The Square of the number is \t" + Sresult);

            Console.ReadLine();

        }
    }
}

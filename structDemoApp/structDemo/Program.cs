using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structDemo
{
    internal class Program
    {
        // Create a struct named Number
        struct Number
        {
            public double Amount;
           
        };
        static void Main(string[] args)
        {
            // Declare myNum of type Number 
            Number myNum;

            // Assign the numbet value in myNum Object
            myNum.Amount = 78;

            // Display the result
            Console.WriteLine(" myNum Amount is :\t", myNum.Amount);

            Console.ReadKey();

        }
    }
}

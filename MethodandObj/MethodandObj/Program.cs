using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodandObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating an Object Employee with FirstName and lastName
            Empyoee emp = new Empyoee() { FirstName = "Roza", LastName="Mezgebu" };
            // call the Supercalss method on Employee Object
            emp.SayName();
            Console.ReadLine(); 
        }
    }
}

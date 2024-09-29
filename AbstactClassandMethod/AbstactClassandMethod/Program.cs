using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassandMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate Employee Object and pass the value
            Employee employee = new Employee() {FirstName="Vinode",LastName="Zelalem" };
            // Call the SayName Method on employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}

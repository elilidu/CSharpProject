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

            Employee emp1 = new Employee();
            emp1.ID = 1;
            emp1.FirstName = "Mekonen";
            emp1.LastName = "Gecho";

            Employee emp2 = new Employee();
            emp2.ID = 1;
            emp2.FirstName = "Mekonen";
            emp2.LastName = "Gecho";

            // Call the SayName Method on employee object
            employee.SayName();
            employee.Quit();
            employee.Quit("Ploymorphism");

            if (emp1== emp2)
            {
                
                Console.WriteLine("Emp1 and empl2 are Equal");
            }
                
            else
            {
                Console.WriteLine("Emp1 and empl2 are Not Equal");
            }
                

            Console.ReadLine();
        }
    }
}

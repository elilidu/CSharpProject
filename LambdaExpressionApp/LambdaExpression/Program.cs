using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List of 10 employee have the fiest rwo Firest name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "David" },
                new Employee() { Id = 3, FirstName = "Lewose", LastName = "Johne" },
                new Employee() { Id = 4, FirstName = "Mark", LastName = "Petter" },
                new Employee() { Id = 5, FirstName = "Keton", LastName = "Germma" },
                new Employee() { Id = 6, FirstName = "Gorge", LastName = "Broke" },
                new Employee() { Id = 7, FirstName = "Evan", LastName = "Aseffa" },
                new Employee() { Id = 8, FirstName = "Aogesti", LastName = "Gomeze" },
                new Employee() { Id = 9, FirstName = "Troy", LastName = "bekele" },
                new Employee() { Id = 10, FirstName = "Roza", LastName = "wondeson" },
            };

            // Create A new List of employee with the First Name is "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    joes.Add(e);
                    Console.WriteLine(e.FirstName+e.LastName);
                }
            }

            
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            //Lambda expresion make a list of all employee with the Id number greater than 5
            List<Employee> bigId = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("Id number greater than 5");
            //Reade Id number greater than 5 
            foreach (Employee be in bigId)
            {
               
                    Console.WriteLine(be.Id+" "+be.FirstName + " " + be.LastName);
            }
            Console.ReadLine();

        }
    }


}


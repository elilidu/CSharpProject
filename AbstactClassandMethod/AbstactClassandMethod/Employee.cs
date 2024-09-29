using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassandMethod
{
    // create Employee class and inherited with superclass called person
    public class Employee:Person
    {
        public int ID { get; set; }

        // Implement a method in side of the Employee classes  
        public override void SayName()
        {
            Console.WriteLine("Name\t" + FirstName+","+LastName);
        }

    }
}

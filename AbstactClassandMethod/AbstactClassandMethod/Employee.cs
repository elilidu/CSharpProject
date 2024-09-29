using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassandMethod
{
    // create Employee class and inherited with superclass called person
    public class Employee:Person, IQuittable
    {
        public int ID { get; set; }

        // Implement a method in side of the Employee classes  
        public override void SayName()
        {
            Console.WriteLine("Name\t" + FirstName+","+LastName);
        }


        //  Employee class Implements the IQuittable interface
        public void Quit()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("This line is the Impliementation of Interface Demo");
            
        }

       public void Quit(string myData)
        {
            Console.WriteLine("This line is the Impliementation of Interface and \t"+myData);
        }
    }
}

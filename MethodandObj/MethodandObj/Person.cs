using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodandObj
{
    public class Person
    {
        //Create a Person Class has FirstName and astName with String data type 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create a Method called SayNae that hasn't a parameter and does not return any data type.
        public void SayName()
        {
            Console.WriteLine("Name: "+this.FirstName+", "+this.LastName);
        }
    }
}

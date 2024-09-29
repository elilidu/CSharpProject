using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassandMethod
{
    // Create Abstract class with String First name and Last Name properties
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create Abstract SayName Method
        public abstract void SayName();
        
    }
}

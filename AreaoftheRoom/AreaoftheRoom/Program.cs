using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaoftheRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object from Room Area class
            RoomArea myroom =new RoomArea();
            Console.WriteLine("this program calculate the Areaa Given Room");

            //Read the length of the room
            Console.WriteLine("Enter the side lenglth");
            int sideLen = Convert.ToInt32(Console.ReadLine());

            //Read the width of the room
            Console.WriteLine("Enter the side lenglth");
            int sideWid = Convert.ToInt32(Console.ReadLine());

            // call method and pass two Integers  
            int Aresult = RoomArea.Area(12,9);
            Console.WriteLine("The Area of Room is\t" + Aresult);

            // call method and pass two parameters  
            int Presult = RoomArea.Area(sideLen,sideWid);
            Console.WriteLine("The Area of a Given Room is\t" + Presult);

            Console.Read();
        }
    }
}

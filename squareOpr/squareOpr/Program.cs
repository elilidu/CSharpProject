using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOpr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program calculate the Area, volume and peremter of the square");
            Console.WriteLine("Enter the side lenglth");
            int sideLen = Convert.ToInt32(Console.ReadLine());
            int Aresult = calAreaandPer.AreaofSquarh(sideLen);
            Console.WriteLine("The Area of the Square is\t" + Aresult);
            int Presult = calAreaandPer.PermeterofSquarh(sideLen);
            Console.WriteLine("The Peremter of the Square is\t" + Presult);
            int Vresult = calAreaandPer.VolumeofSquarh(sideLen);
             Console.WriteLine("The Area of the Square is\t" + Vresult);
            Console.ReadLine();
        }
    }
}

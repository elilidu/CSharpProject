using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace IOdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter your age ");
            String age =Console.ReadLine();
            File.WriteAllText("C:\\Users\\user\\source\\repos\\loge.txt",age);
            Console.ReadLine(); 

        }
    }
}

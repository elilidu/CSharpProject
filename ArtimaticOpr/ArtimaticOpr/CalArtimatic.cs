using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtimaticOpr
{
    public class CalArtimatic
    {
        public static int Artimic(int num1, int num2)
        {
            int x = num1;
            int y = num2;
            return  x+y;
        }
        public static int Artimic(double num1, double num2)
        {
            int r = Convert.ToInt32(num1 - num2);
            return r;
        }

        public static int Artimic(string z)
        {
            int r = Convert.ToInt32(z);
            return r*r;
        }
    }
}

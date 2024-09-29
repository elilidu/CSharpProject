using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOpr
{
    internal class calAreaandPer
    {
            public static int AreaofSquarh(int len)
            {
                int x = len;
                int y = x * x;
                return y;
            }
            
            public static int PermeterofSquarh(int len)
            {
                return 4 * len;
            }
            public static int VolumeofSquarh(int len)
            {
                return len * len*len;
            }
           
        }
    }


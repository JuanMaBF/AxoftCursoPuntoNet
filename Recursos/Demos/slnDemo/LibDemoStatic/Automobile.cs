using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDemoStatic
{
    public class Automobile
    {
        public static int NumberOfWheels = 4;
        public static int SizeOfGasTank
        {
            get
            {
                return 15;
            }
        }
        public static void Drive() { }
        

        // Other non-static fields and properties...
    }
}

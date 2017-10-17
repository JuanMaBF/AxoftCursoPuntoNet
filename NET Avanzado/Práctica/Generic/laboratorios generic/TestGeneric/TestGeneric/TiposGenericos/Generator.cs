using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric.TiposGenericos
{
    public class Generator<T>
    {

        public static void Show(T value)
        {
            Console.WriteLine("Value: ");
            Console.Write(value);
        }

    }
}

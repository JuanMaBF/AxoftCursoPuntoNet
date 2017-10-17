using System;
using TestGeneric.TiposGenericos;

namespace TestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            /*decimal decimal1 = 1;
            decimal decimal2 = 2;
            Console.WriteLine("Decimal 1 = " + decimal1);
            Console.WriteLine("Decimal 2 = " + decimal2);
            Console.WriteLine("Magia...");
            Operaciones<decimal>.Intercambio(ref decimal1, ref decimal2);
            Console.WriteLine("Decimal 1 = " + decimal1);
            Console.WriteLine("Decimal 2 = " + decimal2);
            Console.ReadKey();

            int int1 = 1;
            int int2 = 2;
            Console.WriteLine("Int 1 = " + int1);
            Console.WriteLine("Int 2 = " + int2);
            Console.WriteLine("Magia...");
            Operaciones<int>.Intercambio(ref int1, ref int2);
            Console.WriteLine("Int 1 = " + int1);
            Console.WriteLine("Int 2 = " + int2);
            Console.ReadKey();*/

            Domain<int> domainInt = new Domain<int>(11);
            Domain<string> stringInt = new Domain<string>("i de");
            Domain<DateTime> dateTimeInt = new Domain<DateTime>(DateTime.Now);
            Domain<Object> objectInt = new Domain<Object>(new object());

        }
    }
}

using System;

namespace Delegate
{
    // Declaration
    public delegate void SimpleDelegate();

    class TestDelegate
    {
        public static void MyFunc()
        {
            Console.WriteLine("I was called by delegate ...");
            Console.ReadLine();
        }

        public static void Main()
        {
            // Instantiation
            SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);

            // Invocation
            simpleDelegate();
        }
    }
}

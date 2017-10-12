using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateCSII
{
    
    delegate void Delegate_Multicast(int x, int y);

class Class2

{
        static void Method1(int x, int y) {
          Console.WriteLine("You r in Method 1");
          Console.ReadLine();
        }
        
        static void Method2(int x, int y) {
          Console.WriteLine("You r in Method 2");
          Console.ReadLine();

        }
        
        public static void Main() 
        {
          Delegate_Multicast func = new Delegate_Multicast(Method1);

          func += new Delegate_Multicast(Method2);
          func(1,2);             // Method1 and Method2 are called
          func -= new Delegate_Multicast(Method1);
          func(2,3);             // Only Method2 is called
        }


        }              


  
}

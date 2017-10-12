using System;
public delegate double Delegate_Prod(int a, int b);

class Class1
{


    static double fn_Prodvalues(int val1, int val2)
    {
        return val1 * val2;
    }


    static void Main(string[] args)
    {


        //Creating the Delegate Instance
        Delegate_Prod delObj = new Delegate_Prod(fn_Prodvalues);


        Console.Write("Please Enter Values");

        int v1 = Int32.Parse(Console.ReadLine());
        int v2 = Int32.Parse(Console.ReadLine());

        //use a delegate for processing

        double res = delObj(v1, v2);
        Console.WriteLine("Result :" + res);
        Console.ReadLine();

    }
}


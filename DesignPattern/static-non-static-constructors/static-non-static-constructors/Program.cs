using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace static_non_static_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Difference between Static Constructors and Non-Static Constructors*/
            //Greek greek = new Greek();
            //Greek _greek = new Greek();


            //Method Overloading
            Ploytest ploytest = new Ploytest();
            Console.WriteLine("Output" + ploytest.add(54564564, 1));
            Console.ReadLine();
        

        }
    }
}
public class Ploytest
{
    public int add(int a,int b)
    {
        return a + b;
    }

    public long add(long a, long b)
    {
        return a + b;
    }
}

public class Greek
{
    static Greek()
    {
        Console.WriteLine("I am static constructor");
    }

    public Greek()
    {
        Console.WriteLine("I am Non-Static constructor");
    }

}

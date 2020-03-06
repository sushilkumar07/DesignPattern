using System;

namespace oopsInterface
{
    class Program : interfaceOne, interfaceTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void PrintDetails()
        {
            Console.WriteLine("Print from implicit inteface");
        }

        void interfaceOne.PrintDetails()
        {
            Console.WriteLine("Print from explicit inteface");
        }

       


    }

}
interface interfaceOne
{
    void PrintDetails();
}
interface interfaceTwo
{
    void PrintDetails();
}
/*
 * Interface type :
 *      1) Implicit interface 
 *      2) Explicit interface
 *      
 * 
 */

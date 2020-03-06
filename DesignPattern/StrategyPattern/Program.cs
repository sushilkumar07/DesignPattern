using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /*
     * Shopping mall passing it customer name bill amount and Strategy which we want to apply
     * has parameters and calculate th final bill.
     * we are passing discount Strategy at runtime.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behaviour type :Strategy pattern example");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("What is Strategy pattern : ");

            // Approch one 
            ShoppingMall objshoppingMall = new ShoppingMall(new LowDiscountStrategy())
            {
                customerName = "Monday Customer",
                billAmount = 1000
            };
            Console.WriteLine("Monday final bill  -" + objshoppingMall.getFinalBill());


            ShoppingMall objshoppingMall1 = new ShoppingMall(new HighDisocuntStrategy())
            {
                customerName = "Friday Customer",
                billAmount = 1000
            };
            Console.WriteLine("Friday final bill  -" + objshoppingMall1.getFinalBill());

            ShoppingMall objshoppingMall2 = new ShoppingMall(new NoDiscountStrategy())
            {
                customerName = "Sunday Customer",
                billAmount = 1000
            };
            Console.WriteLine("Sunday final bill  -" + objshoppingMall2.getFinalBill());

            // Approch Two
            ShoppingMall objshoppingMallGeneric = new ShoppingMall(null)
            {
                customerName = "Monday Customer",
                billAmount = 1000
            };

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    objshoppingMallGeneric.currentStrategy = new LowDiscountStrategy();
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
/*
 * What is Strategy?
 *      Strategy is plan of action to achive a sepcific goal
 *      for example : to reach office 
 *                      Home -- > Bike --> Office --- this is my Strategy1
 *                      Home -- > Bus --> Office ---  this is my Strategy2
 *                      Home -- > Train --> Office ---this is my Strategy3
 *      so Strategy pattern is we have set of Strategy define with us and which can 
 *      be replaced with another any movement of time of initialize.
 *      first i have bike Strategy then when i came to know its getting expensive then
 *      i will change my Strategy to bus and trains and so on...
 *      
 * What is Strategy Pattern?     
 *      Define a family of algorithms, encapsulate each one, and make them 
 *      interchangeable. Strategy lets the algorithm vary independently from 
 *      clients that use it.
 *     
 * Shopping mall example:
 *      Discount Strategy (Discount algorithm)
 *      i.e.
 *          LowDiscountStrategy
 *          HighDisocuntStrategy
 *          NoDiscountStrategy
 *         
 *          
 * 
 *      
 */

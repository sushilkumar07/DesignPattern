using System;

namespace whenshouldweuseanabstractclass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //BaseEmployee bse = new BaseEmployee()
            //{
            //    Id = 1,
            //    firstName = "Base Sushil",
            //    lastName = "Shinde",
                 
            //};

            // Console.WriteLine(bse.GetFullName());
            Console.WriteLine("------------------------");
            //Console.WriteLine(bse.GetMonthlySalary());

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                Id = 1,
                firstName = "sushil",
                lastName = "Shinde",
                annualSalary = 60000
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("------------------------");


            ContractEmployee cte = new ContractEmployee()
            {
                Id = 1,
                firstName = "contract",
                lastName = "Shinde",
                hourlyPay = 100,
                toalHours = 8
            };
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());

            Console.ReadLine();

        }

    }
}
/* 
 * Issue with above code :
   1) Same implementation code in both file
   2) Code maintainbility
   3) if we need to introduce middle name then we have to change in both files.
   4) if we need to introduce new employee type i.e part time employee.we have to create more classes and file as much we need or introduce the types
   5) Time consuming Code maintainbility
   6) hpw to fix common functionality between related the 2 or more classes ?

 */
/*Solution 
 * 1) we can move the common functionality into BASE class.
 * 2) Then we have to Inherit that class
 * 3) Create the concreate class (with non-abstract method) Or abstract class
 * 4) First crate the concreate class  then Use abstract class
 *     1) Move the code into concreate class i.e base class
 *     2) if we need to introduce middle name then we have into BaseFile.
 *     3) Time consuming Code maintainbility  -- less as compare the above 
 *     4) Problme statement : We can create the object/Instances  of both classes and BASE class as well.
 *     5) Probele statement : If we dont want to create the object/Instances  of baseClass i.e basemployee
 *     abstract class
 *      1) if mark base class abstract 
 *      2) It will give error cannot crate instance of the abstract clas of baseemployee
 *      3) It is advantage of creating the object/instances of base class
 *      4) preventing us to createing instances of base employee class
 *      5) for the all derived classes implement to getmonthly salary method.
 *      6) In short we would create an abstract class when we want to move 
 *          Common functionality 2 or more related classes into your base class
 *          and when we do not want that base class to be create the object/Instances
 *          
 *      
 */

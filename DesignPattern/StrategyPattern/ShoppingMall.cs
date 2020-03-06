using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ShoppingMall
    {
        /*In shopping mall class, which is encapsulate customer deatils bill amount 
         * and it iternally exchangesble and uses statergies for applying
         * discount an we can see here that shoping mall class users interface 
         * instance of concrete class and follow the OOP principle 
         * i.e. interface not to implementation 
         */

        public string customerName { get; set; }

        public int billAmount{ get; set; }


        public baseStrategy currentStrategy;
        public ShoppingMall(baseStrategy newStrategy)
        {
            currentStrategy = newStrategy;
        }

        public int getFinalBill()
        {
            return currentStrategy.abstractGetFinalBill(this.billAmount);
        }
    }
}
/*
 * The Strategy Design Pattern is used when we have multiple algorithms (solutions) 
 * for a specific task and the client decides the actual implementation to be used at 
 * runtime.
 */

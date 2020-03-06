using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HighDisocuntStrategy : baseStrategy
    {
        public override int abstractGetFinalBill(int BillAmount)
        {
            return (int)(BillAmount - (BillAmount * 0.5));
        }
        //private override GetFinalBill(int BillAmount)
        //{
        //    return (int)(BillAmount - (BillAmount * 0.5));
        //}
        
        /*
         * we can replace the thing with interface / vice versa we can use  
         */
    }
}

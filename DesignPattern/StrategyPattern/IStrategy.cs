using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface  IStrategy
    {
         int InterfaceGetFinalBill(int BillAmount);
    }
}

/*
 * Instend of interface we can use the Abstract class as well
 * to provide common funcationality and force to implement
 */

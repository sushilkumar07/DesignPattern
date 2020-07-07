using System;
using System.Collections.Generic;
using System.Text;

namespace whenshouldweuseanabstractclass
{
    public class ContractEmployee : BaseEmployee
    {
        //public int Id { get; set; }
        //public string firstName { get; set; }
        //public string lastName { get; set; }
        public int hourlyPay { get; set; }
        public int toalHours { get; set; }

        public override string GetFullName()
        {
            return this.firstName + " " + this.lastName;

        }
        public override int GetMonthlySalary()
        {
            return this.toalHours * this.hourlyPay;
        }
    }
}

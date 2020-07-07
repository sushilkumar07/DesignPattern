using System;
using System.Collections.Generic;
using System.Text;

namespace whenshouldweuseanabstractclass
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual string GetFullName()
        {
            return this.firstName + " " + this.lastName;

        }
        public abstract int GetMonthlySalary();
         

        //public virtual int GetMonthlySalary()
        //{
        //    throw NotImplementedException();
        //}

        //private Exception NotImplementedException()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

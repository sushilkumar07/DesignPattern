namespace whenshouldweuseanabstractclass
{
    public class FullTimeEmployee : BaseEmployee
    {
        //public int Id { get; set;}
        //public string firstName { get; set; }
        //public string lastName { get; set; }
        public int annualSalary { get; set; }

        public override string GetFullName()
        {
            return this.firstName + " " + this.lastName;

        }

        public override int GetMonthlySalary()
        {
            return this.annualSalary / 12;
        }
    }
}

using System;

namespace Employees
{
    public class SalesEmployee : Employee
    {
        public double Bonus {get; set;}
        
        public SalesEmployee(string name, double baseSalary, double bonus)
        : base (name, baseSalary)
        {
            this.Bonus = bonus;
        }
        
        public override double CalculatePay()
        {
            return (this.BaseSalary + this.Bonus);
        }
    }
}

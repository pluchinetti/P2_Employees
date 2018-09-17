using System;

namespace Employees
{
    public class Employee
    {
        public string Name {get; set;}
        public double BaseSalary {get; set;}
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
        }

        public virtual double CalculatePay()    // Método polimórfico
        {
            return this.BaseSalary;
        }
    }
}
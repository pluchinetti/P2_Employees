using System;
using System.Collections.Generic;

namespace Employees
{   
    public class SalesManager : Employee
    {
        public List<Employee> EmployeeList {get; set;}

        public double PercentageSalary {get; set;}
        public SalesManager(string name, double baseSalary, List<Employee> employeeList, double percentageSalary)
        : base(name, baseSalary)
        {
            this.EmployeeList = employeeList;
            this.PercentageSalary = percentageSalary;
        }

        public override double CalculatePay()
        {
            double salarySubTotal = 0;
            foreach(Employee emp in this.EmployeeList)
            {
                salarySubTotal += this.PercentageSalary*emp.CalculatePay();
            }
            return (this.BaseSalary + salarySubTotal);
        }
    }
}
using System;
using Xunit;
using Employees;
using System.Collections.Generic;

namespace Library.Tests
{
    public class EmployeesTests
    {
        [Fact]
        public void TestsCalculatePay()
        {
            double employee1BasePay = 1000;
            double employee1Bonus = 500;
            double employee1Salary = employee1BasePay + employee1Bonus;
            double employee2BasePay = 1200;
            SalesEmployee employee1 = new SalesEmployee("Alice", employee1BasePay, employee1Bonus);
            Employee employee2 = new Employee("Bob", employee2BasePay);
            Assert.Equal(employee1Salary, employee1.CalculatePay());
            Assert.Equal(employee2BasePay, employee2.CalculatePay());
        }

        [Fact]
        public void TestCalculatePaySM()
        {
            double employee1BasePay = 1000;
            double employee1Bonus = 500;
            double employee1Salary = employee1BasePay + employee1Bonus;
            double employee2BasePay = 1200;
            SalesEmployee employee1 = new SalesEmployee("Alice", employee1BasePay, employee1Bonus);
            Employee employee2 = new Employee("Bob", employee2BasePay);
            double employeeSMBaseSalary = 5000;
            double employeeSMSalary = 5405;

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);

            SalesManager employeeSM = new SalesManager("El botón del Guille", employeeSMBaseSalary, employeeList, 0.15);
            Assert.Equal(employeeSMSalary, employeeSM.CalculatePay());
        }
    }
}

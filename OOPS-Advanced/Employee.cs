using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //Child Class/ Derived Class/ Sub Class
    public class Employee : Company, IEmployeeSalary
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public Employee(int employeeId, string employeeName, string address,int salary, int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Address = address;
            Salary = salary;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Name : {EmployeeName}\nAddress : {Address}");
        }

        public void EmployeeCompanyDetails()
        {
            Console.WriteLine($"Employee Name : {EmployeeName}\nCompanyName : {CompanyName}\n" +
                $"Location : {Location}");
        }

        public void SalaryDetails()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}

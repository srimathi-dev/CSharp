using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{

    //Hierarchical inheritance
    public class ExternalEmployee : Company
    {
        public int ExternalEmployeeId { get; set; }
        public string ExternalEmployeeName { get; set; }
        public double Salary { get; set; }

        public ExternalEmployee(int externalEmployeeId, string externalEmployeeName, 
            double salary, int companyId, string companyName, string location) : 
            base(companyId, companyName, location)
        {
            ExternalEmployeeId = externalEmployeeId;
            ExternalEmployeeName = externalEmployeeName;
            Salary = salary;
        }

        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"External Employee Id : {ExternalEmployeeId}\n" +
                $"External Employee Name : {ExternalEmployeeName}\nSalary : {Salary}");
        }
    }
}

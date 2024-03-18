using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    public class Boss : Employee
    {
        //Multilevel inheritance
        public Boss(int employeeId, string employeeName, string address, int salary, 
            int companyId, string companyName, string location) : base (employeeId, employeeName, 
                address, salary, companyId, companyName, location)
        {
            
        }
    }
}

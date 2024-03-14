using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //Parent Class/ Base Class/ Super Class
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

         
        //Parameterized Constructor
        public Company(int id, string name, string location)
        {
            this.CompanyId = id;
            this.CompanyName = name;
            this.Location = location;
        }

        public void DisplayData()
        {
            Console.WriteLine($"ID : {CompanyId}\nName : {CompanyName}");
        }

        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"ID : {CompanyId}\nName : {CompanyName}\nLocation : {Location}");
        }
    }
}

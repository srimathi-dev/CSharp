using OOPS_Advanced;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Employee obj1 = new Employee(1, "SRI", "TAMILNADU", 1001, "ZOHO", "INDIA");
        //Base/Parent/Company class
        obj1.DisplayCompanyDetails();

        //Child/derived/Employee class
        obj1.EmployeeCompanyDetails();
        obj1.EmployeeDetails();
    }
}
using OOPS_Advanced;
using System;
public class Program
{
    static void Main(string[] args)
    {
        //Employee obj1 = new Employee(1, "SRI", "TAMILNADU",50000, 1001, "ZOHO", "INDIA");
        ////Base/Parent/Company class
        //obj1.DisplayCompanyDetails();

        ////Child/derived/Employee class
        //obj1.EmployeeCompanyDetails();
        //obj1.EmployeeDetails();

        ////Interface-Multiple inheritance
        //obj1.SalaryDetails();

        //Console.WriteLine("----------------------------");

        //Boss obj2 = new Boss(2, "MATHI", "TAMILNADU", 100000, 2002, "GOOGLE", "USA");
        ////Base/Parent/Company class
        //obj2.DisplayCompanyDetails();

        ////Child/derived/Employee class
        //obj2.EmployeeCompanyDetails();
        //obj2.EmployeeDetails();

        ////Interface-Multiple inheritance
        //obj2.SalaryDetails();

        //Console.WriteLine("----------------------------");

        //ExternalEmployee obj3 = new ExternalEmployee(3, "SUPRAJA", 30000, 3003, "ABC", "INDIA");
        ////Base/Parent/Company class
        //obj3.DisplayCompanyDetails();

        ////Hierarchical Inheritance
        ////Child/derived/Employee class
        //obj3.ExternalEmployeeDetails();

        //Console.WriteLine("----------------------------");

        //Polymorphism
        Calculator obj4 = new Calculator();
        obj4.Add(10, 20);
        obj4.Add(20, 20, 20);


    }
}
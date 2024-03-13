using OOPS;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Company compObj1 = new Company(1001, "ZOHO", "CHENNAI");
        compObj1.DisplayCompanyDetails();

        Company compObj2 = new Company(2002, "GOOGLE", "USA");
        compObj2.DisplayCompanyDetails();

        Company compObj3 = new Company(3003, "APPLE");
        compObj3.DisplayData();

        Company compObj4 = new Company
        {
            Id = 4004,
            Name = "ATLASSIAN"

        };
        compObj4.DisplayData();

        Console.WriteLine();

        List<Company> companyList = new List<Company>
        {
            new Company
            {
                Id = 1001,
                Name = "ZOHO"
            },

            new Company
            {
                Id = 2002,
                Name = "GOOGLE"
            },

            new Company
            {
                Id = 3003,
                Name = "APPLE"
            },

            new Company
            {
                Id = 4004,
                Name = "ATLASSIAN"
            }
        };

        foreach (var item in companyList)
        {
            Console.WriteLine($"ID: {item.Id}, Name : {item.Name}");
        }
    }
}
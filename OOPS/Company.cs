using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Company
    {
        //private int id = 1001;
        //private string name = "ZOHO";

        //public void SetId(int idNum)
        //{
        //    this.id = idNum;
        //}

        //public int GetId()
        //{
        //    return id;
        //}

        //public void SetName(string nameCmp)
        //{
        //    this.name = nameCmp;
        //}

        //public string GetName()
        //{
        //    return name;
        //}


        //Getter and Setter
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


        //Constructor
        //Default Constructor
        public Company() 
        {

        }
        //Parameterized Constructor
        public Company(int id, string name, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
        }

        public Company(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void DisplayData()
        {
            Console.WriteLine($"ID : {Id}\nName : {Name}");
        }

        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"ID : {Id}\nName : {Name}\nLocation : {Location}");
        }
    }
}

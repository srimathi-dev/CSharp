using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //Method Overriding
    public class Bus
    {
        public int wheels {  get; set; }

        public Bus(int Wheels)
        {
            wheels = Wheels;
        }
        
        public void BusCapacity()
        {
            Console.WriteLine("This bus has 40 seats");
        }


        public virtual void BusDetails() 
        {
            Console.WriteLine($"This Bus has {wheels} wheels!");
        }
    }
}

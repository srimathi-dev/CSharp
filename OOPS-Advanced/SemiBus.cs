using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //Method overriding
    public class SemiBus : Bus
    {
        public SemiBus(int wheels) : base(wheels) 
        {

        }

        public new void BusCapacity()
        {
            Console.WriteLine("This Semi bus has 20 seats");
        }

        public override void BusDetails()
        {
            Console.WriteLine($"This Semi Bus has {wheels} wheels!");
        }

    }
}

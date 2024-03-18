using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //Polymorphism
    public class Calculator
    {
        //Method overloading
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1 + num2}");
        }

        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine($"{num1 + num2 + num3}");
        }
    }
}

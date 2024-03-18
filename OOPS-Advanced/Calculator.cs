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
            Console.WriteLine($"Addition of 2 numbers : {num1 + num2}");
        }

        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine($"Addition of 3 numbers : {num1 + num2 + num3}");
        }

        public void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"Subtraction of 3 numbers : {num1 - num2}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    public class SemiSchoolBus : SemiBus
    {
        public SemiSchoolBus(int wheels) : base(wheels)
        {
            
        }

        public override void BusDetails()
        {
            Console.WriteLine($"This Semi School Bus has {wheels} wheels!");
        }
    }
}

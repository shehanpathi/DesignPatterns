﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ThickCrustPizza : IPizza
    {
        public double cost()
        {
            return 0.22;
        }

        public string getDescription()
        {
            return "Thick Crust Pizza";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class PizzaDecorator : IPizza
    {
        public abstract double cost();

        public abstract string getDescription();
    }
}

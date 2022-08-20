using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Pepper : PizzaDecorator
    {
        private readonly IPizza pizza;

        public Pepper(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public override double cost()
        {
            return pizza.cost() + 1.99;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Pepper";
        }
    }
}

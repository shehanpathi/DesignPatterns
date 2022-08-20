using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Olive : PizzaDecorator
    {
        private readonly IPizza pizza;
        public Olive(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public override double cost()
        {
            return pizza.cost() + 0.99;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Olive";
        }
    }
}

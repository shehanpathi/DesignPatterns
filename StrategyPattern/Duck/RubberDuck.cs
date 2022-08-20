using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class RubberDuck : Duck
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            Console.WriteLine("RUBBER SWIM");
        }

        public new void Quack()
        {
            Console.WriteLine("RUBBER QUACK");
        }
    }
}

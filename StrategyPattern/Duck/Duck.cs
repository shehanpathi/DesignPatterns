using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("QUACK");
        }

        public virtual void Swim()
        {
            Console.WriteLine("SWIM");
        }

        public abstract void Display();

        public void Fly()
        {
            Console.WriteLine("FLY");
        }



    }
}

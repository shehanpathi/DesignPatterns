using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Duck : IDuck
    {
        private readonly IDuck duck;

        public Duck(IDuck duck)
        {
            this.duck = duck;
        }

        public void Fly()
        {
            duck.Fly();
        }

        public void Quack()
        {
            duck.Quack();
        }

        public void Swim()
        {
            duck.Swim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class USCentral : IZone
    {
        public void getName()
        {
            Console.WriteLine("US CENTRAL");
        }

        public string getOffset()
        {
            throw new NotImplementedException();
        }
    }
}

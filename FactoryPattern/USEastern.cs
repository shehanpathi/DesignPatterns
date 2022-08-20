using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class USEastern : IZone
    {
        public void getName()
        {
            Console.WriteLine("US EASTERN");
        }

        public string getOffset()
        {
            throw new NotImplementedException();
        }
    }
}

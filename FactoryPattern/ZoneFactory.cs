using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ZoneFactory
    {
        public IZone createZone(int id)
        {
            if (id == 0)
                return new USCentral();
            else
                return new USEastern();

        }
    }
}

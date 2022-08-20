using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SuperDrone : IDrone
    {
        public void beep()
        {
            Console.WriteLine("Drone BEEP");
        }

        public void spinRotors()
        {
            Console.WriteLine("Drone SPIN ROTORS");
        }

        public void takeOff()
        {
            Console.WriteLine("Drone TAKE OFF");
        }
    }
}

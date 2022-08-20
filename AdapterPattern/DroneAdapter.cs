
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class DroneAdapter : IDuck
    {
        private readonly IDrone drone;

        public DroneAdapter(IDrone drone)
        {
               this.drone = drone;
        }

        public void Fly()
        {
            drone.takeOff();
        }

        public void Quack()
        {
            drone.beep();
        }

        public void Swim()
        {
            drone.spinRotors();
        }
    }
}

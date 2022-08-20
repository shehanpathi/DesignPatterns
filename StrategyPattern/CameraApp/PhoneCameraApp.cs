using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CameraApp
{
    public abstract class PhoneCameraApp
    {
        public ICameraSharable cameraSharable;

        public void Share()
        {
            cameraSharable.Share();
        }
        public void Take()
        {
            Console.WriteLine("TAKE");
        }

        public abstract void Edit();


        public void Save()
        {
            Console.WriteLine("SAVE");
        }
    }
}

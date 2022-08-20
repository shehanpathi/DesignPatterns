using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CameraApp
{
    public class CameraPlusApp : PhoneCameraApp
    {

        public CameraPlusApp()
        {
            cameraSharable = new TextShare();
        }
        public override void Edit()
        {
            Console.WriteLine("CAMERA PLUS APP EDIT");
        }

       

    }
}

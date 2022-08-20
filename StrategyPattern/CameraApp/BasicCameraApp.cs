using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CameraApp
{
    public class BasicCameraApp : PhoneCameraApp
    {

        public BasicCameraApp()
        {
            cameraSharable = new MailShare();
        }
        public override void Edit()
        {
            Console.WriteLine("BASIC CAMERA APP EDIT");
        }

    }
}

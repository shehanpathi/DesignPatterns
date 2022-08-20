using OOP.CameraApp;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneCameraApp basicCameraApp = new BasicCameraApp();
            basicCameraApp.Share();
            basicCameraApp.Edit();

            PhoneCameraApp cameraPlus = new CameraPlusApp();
            cameraPlus.Share(); 
            cameraPlus.Edit(); 
        }
    }
}

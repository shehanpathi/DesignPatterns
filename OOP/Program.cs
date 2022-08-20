using Observer;
using OOP.CameraApp;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PhoneCameraApp basicCameraApp = new BasicCameraApp();
            //basicCameraApp.Share();
            //basicCameraApp.Edit();

            //PhoneCameraApp cameraPlus = new CameraPlusApp();
            //cameraPlus.Share(); 
            //cameraPlus.Edit(); 

            WeatherStation weatherStation = new WeatherStation();

            LoggerObserver logger = new LoggerObserver(weatherStation);
            UserInterfaceObserver userInterfaceObserver =  new UserInterfaceObserver(weatherStation);
            AlertSystemObserver alert = new AlertSystemObserver(weatherStation);

            weatherStation.Pressure = 30;
            weatherStation.Temperature = 15;
            weatherStation.Pressure = 2;
        }
    }
}

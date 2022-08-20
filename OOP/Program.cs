using AdapterPattern;
using DecoratorPattern;
using Observer;
using OOP.CameraApp;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRATEGY

            //PhoneCameraApp basicCameraApp = new BasicCameraApp();
            //basicCameraApp.Share();
            //basicCameraApp.Edit();

            //PhoneCameraApp cameraPlus = new CameraPlusApp();
            //cameraPlus.Share(); 
            //cameraPlus.Edit(); 


            //OBSERVER

            //WeatherStation weatherStation = new WeatherStation();

            //LoggerObserver logger = new LoggerObserver(weatherStation);
            //UserInterfaceObserver userInterfaceObserver =  new UserInterfaceObserver(weatherStation);
            //AlertSystemObserver alert = new AlertSystemObserver(weatherStation);

            //weatherStation.Pressure = 30;
            //weatherStation.Temperature = 15;
            //weatherStation.Pressure = 2;


            ///ADAPTER
            ///
            //SuperDrone superDrone = new SuperDrone();
            //DroneAdapter droneAdapter  = new DroneAdapter(superDrone);
            //Duck duck = new Duck(droneAdapter);
            //duck.Fly();


            //DECORATOR

            IPizza pizza1 = new ThinCrustPizza();
            pizza1 = new Olive(pizza1);
            pizza1 = new Pepper(pizza1);
            Console.WriteLine(pizza1.getDescription() + " " + pizza1.cost());

            IPizza pizza2 = new ThickCrustPizza();
            pizza2 = new Pepper(pizza2);
            Console.WriteLine(pizza2.getDescription() + " " + pizza2.cost());
        }
    }
}

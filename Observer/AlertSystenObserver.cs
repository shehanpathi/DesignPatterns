using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AlertSystemObserver : IObserver
    {
        public AlertSystemObserver(WeatherStation simpleSubject)
        {
            this.simpleSubject = simpleSubject;
            simpleSubject.registerObserver(this);
        }

        public WeatherStation simpleSubject { get; }

        public void Update(WeatherStation value)
        {
            Console.WriteLine("Wind " + value.WindSpeed);
            Console.WriteLine("Pressure " + value.Pressure);
            Console.WriteLine("Temp " + value.Temperature);
        }
    }
}

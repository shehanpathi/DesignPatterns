using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherStation : IWeatherStation
    {
        public List<IObserver> observers;
        private int _pressure;
        private int _wind;
        private int _temp;

        public int Temperature
        {
            get
            {
                return _temp;
            }
            set
            {
                this._temp = value;
                notifyObservers();
            }
        }

        public int WindSpeed
        {
            get
            {
                return _wind;
            }
            set
            {
                this._wind = value;
                notifyObservers();
            }
        }

        
        public int Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                this._pressure = value;
                notifyObservers();
            }
        }

        public WeatherStation()
        {
            observers = new List<IObserver>();  
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        
    }
}

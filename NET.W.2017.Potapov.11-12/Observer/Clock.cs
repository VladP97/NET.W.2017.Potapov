using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    public class Clock : IObservable
    {
        private TimeSpan time;

        private List<IObserver> observers = new List<IObserver>();

        public Clock(TimeSpan time)
        {
            this.time = time;
        }

        public Clock(string time)
        {
            this.time = TimeSpan.Parse(time);
        }

        public string Time
        {
            get { return time.ToString(); }
        }

        public void StartTimer()
        {
            Thread thread = new Thread(Sleep);
            thread.Start();
        }

        public void AddObserver(IObserver obj)
        {
            observers.Add(obj);
        }

        public void RemoveObserver(IObserver obj)
        {
            observers.Remove(obj);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(time);
            }
        }

        private void Sleep()
        {
            Thread.Sleep(time);
            NotifyObservers();
        }
    }
}

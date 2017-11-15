using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;

namespace ObserverDemo
{
    class TimeObserver : IObserver
    {
        private int seconds;
        private string observerName;

        public TimeObserver(string observerName)
        {
            this.observerName = observerName;
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
        }

        public void Update(params dynamic[] obj)
        {
            seconds = obj[0].Seconds;
            Console.WriteLine($"Time passed: {seconds}, observer name {observerName}");
        }


    }
}

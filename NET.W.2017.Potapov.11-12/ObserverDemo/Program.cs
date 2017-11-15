using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;

namespace ObserverDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Clock clock = new Clock(new TimeSpan(0, 0, 5));
			TimeObserver tw1 = new TimeObserver("tw1");
			TimeObserver tw2 = new TimeObserver("tw2");
			TimeObserver tw3 = new TimeObserver("tw3");
			clock.AddObserver(tw1);
			clock.AddObserver(tw2);
			clock.AddObserver(tw3);
			clock.StartTimer();
			clock.RemoveObserver(tw2);
			Console.ReadLine();
		}
	}
}

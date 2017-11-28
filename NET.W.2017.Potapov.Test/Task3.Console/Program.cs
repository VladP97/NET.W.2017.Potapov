using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Broker broker = new Broker("Jordan Belfort");
            Bank bank = new Bank("Industrial and Commercial Bank of China (ICBC)");
            stock.RateChanged += broker.Update;
            stock.RateChanged += bank.Update;
            stock.ChangeRate();
            System.Console.ReadLine();
        }
    }
}

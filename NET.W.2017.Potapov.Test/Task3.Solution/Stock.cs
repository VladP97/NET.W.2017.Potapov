using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler RateChanged;

        public int USD;
        public int Euro;

        public void ChangeRate()
        {
            Random rnd = new Random();
            USD = rnd.Next(20, 40);
            Euro = rnd.Next(30, 50);
            RateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

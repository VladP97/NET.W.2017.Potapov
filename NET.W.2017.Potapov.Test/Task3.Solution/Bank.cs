using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank
    {
        private string name;

        public Bank(string name)
        {
            this.name = name;
        }

        public void Update(object sender, EventArgs args)
        {
            Stock obj = (Stock)sender;
            if (obj.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", name, obj.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", name, obj.Euro);
        }
    }
}

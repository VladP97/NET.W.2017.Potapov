using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker
    {
        private string name;

        public Broker(string name)
        {
            this.name = name;
        }

        public void Update(object sender, EventArgs args)
        {
            Stock obj = (Stock)sender;
            if (obj.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", name, obj.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", name, obj.USD);
        }
    }
}

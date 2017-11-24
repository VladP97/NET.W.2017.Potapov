using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class Base : AccountType
    {
        public Base()
        {
            bonusIncerease = 10;
            bonusDecerease = 10;
            name = "Base";
        }
    }
}

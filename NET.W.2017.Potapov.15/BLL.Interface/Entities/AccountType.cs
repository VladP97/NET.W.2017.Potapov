using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class AccountType
    {
        public int bonusIncerease;
        public int bonusDecerease;
        protected string name;

        public override string ToString()
        {
            return name;
        }
    }
}

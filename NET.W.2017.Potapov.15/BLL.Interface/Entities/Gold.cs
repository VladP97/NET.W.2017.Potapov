using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class Gold : AccountType
    {
        public Gold()
        {
            bonusIncerease = 15;
            bonusDecerease = 5;
            name = "Gold";
        }
    }
}

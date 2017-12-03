using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class AccountTypeDTO
    {
        public string Name { get; set; }
        public int BonusIncrease { get; set; }
        public int BonusDecrease { get; set; }
    }
}

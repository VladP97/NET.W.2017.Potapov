using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    [Serializable]
    public class AccountDTO
    {
        public int accountNumber;
        public string owenerName;
        public decimal balance = 0;
        public int bonus = 0;
        public object accountType;
    }
}

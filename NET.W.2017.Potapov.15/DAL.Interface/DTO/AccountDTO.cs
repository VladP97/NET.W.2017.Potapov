using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.Interface.DTO
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public AccountType TypeId { get; set; }
        public string AccountOwner { get; set; }
        public int Bonus { get; set; }
        public decimal Balance { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;

namespace BLL.Interface.Entities
{
    public class AccountNumberCreator : IAccountNumberCreateService
    {
        public int GenerateAccountNumber(IEnumerable<Account> accountList)
        {
            if (accountList.Count() == 0)
            {
                return 1;
            }
            return accountList.Max(account => account.AccountNumber) + 1;
        }
    }
}

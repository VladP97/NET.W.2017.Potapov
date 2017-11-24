using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;

namespace BLL.Interface.Interfaces
{
    public interface IAccountService
    {
        void OpenAccount(string accountOwener, AccountType type, IAccountNumberCreateService creator);

        void DepositAccount(int accountNumber, decimal sum);

        void WithdrawAccount(int accountNumber, decimal sum);

        IEnumerable<Account> GetAllAccounts();
    }
}

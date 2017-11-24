using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;
using BLL.Interface.Entities;

namespace BLL.ServiceImplementation
{
    public class AccountService : IAccountService
    {
        private List<Account> accountList = new List<Account>();
        private IBonusAlgorithm bonusAlgorithm;

        public AccountService(IBonusAlgorithm bonusAlgorithm)
        {
            this.bonusAlgorithm = bonusAlgorithm;
        }

        public void OpenAccount(string accountOwener, AccountType type, IAccountNumberCreateService creator)
        {
            accountList.Add(new Account(creator.GenerateAccountNumber(accountList), accountOwener, type));
        }

        public void DepositAccount(int accountNumber, decimal sum)
        {
            Account acc = accountList.Find(account => account.AccountNumber == accountNumber);
            acc.Balance += sum;
            acc.Bonus += bonusAlgorithm.GetBonus(sum, acc.BonusIncrease);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return accountList;
        }

        public void WithdrawAccount(int accountNumber, decimal sum)
        {
            Account acc = accountList.Find(account => account.AccountNumber == accountNumber);
            acc.Balance -= sum;
            acc.Bonus -= bonusAlgorithm.GetBonus(sum, acc.BonusDecrease);
        }
    }
}

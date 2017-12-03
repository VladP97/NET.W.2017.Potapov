using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;
using DAL.Interface.DTO;
using DAL.Model;

namespace BLL.ServiceImplementation
{
    public class AccountService : IAccountService
    {
        public IUnitOfWork DB { get; set; }

        public AccountService(IUnitOfWork db)
        {
            DB = db;
        }

        public void OpenAccount(AccountDTO dto)
        {
            Account newAcc = new Account { AccountOwner = dto.AccountOwner, Balance = dto.Balance, Bonus = dto.Bonus, AccountType = dto.TypeId };
            DB.Accounts.Create(newAcc);
            DB.Save();
        }

        public void CloseAccount(int id)
        {         
            DB.Accounts.Delete(id);
            DB.Save();
        }

        public void Deposit(int id, decimal sum)
        {
            List<Account> accounts = DB.Accounts.GetAll().ToList();
            foreach (var account in accounts)
            {
                if (account.AccountId == id)
                {
                    account.Balance += sum;
                    account.Bonus += account.AccountType.BonusIncrease;
                }
            }
            DB.Save();
        }

        public void Withdraw(int id, decimal sum)
        {
            List<Account> accounts = DB.Accounts.GetAll().ToList();
            foreach (var account in accounts)
            {
                if (account.AccountId == id)
                {
                    account.Balance -= sum;
                    account.Bonus -= account.AccountType.BonusDecrease;
                }
            }
            DB.Save();
        }
    }
}

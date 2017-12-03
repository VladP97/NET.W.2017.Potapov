using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Interfaces;
using DAL.Model;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private BankContext db;
        private AccountRepository accountRepository;
        private AccountTypeRepository accountTypeRepository;

        public UnitOfWork()
        {
            db = new BankContext();
        }

        public IRepository<Account> Accounts
        {
            get
            {
                if (accountRepository == null)
                {
                    accountRepository = new AccountRepository(db);
                }
                return accountRepository;
            }
        }

        public IRepository<AccountType> AccountTypes
        {
            get
            {
                if (accountTypeRepository == null)
                {
                    accountTypeRepository = new AccountTypeRepository(db);
                }
                return accountTypeRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

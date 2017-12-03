using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Interfaces;
using DAL.Model;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class AccountTypeRepository : IRepository<AccountType>
    {
        private BankContext db;

        public AccountTypeRepository(BankContext context)
        {
            db = context;
        }

        public AccountType Get(int id)
        {
            return db.AccountTypes.Find(id);
        }

        public void Create(AccountType accountType)
        {
            db.AccountTypes.Add(accountType);
        }

        public void Update(AccountType accountType)
        {
            db.Entry(accountType).State = EntityState.Modified;
        }

        public IEnumerable<AccountType> GetAll()
        {
            return db.AccountTypes;
        }

        public void Delete(int id)
        {
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType != null)
                db.AccountTypes.Remove(accountType);
        }
    }
}

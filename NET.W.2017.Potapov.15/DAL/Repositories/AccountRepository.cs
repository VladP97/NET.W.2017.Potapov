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
    public class AccountRepository : IRepository<Account>
    {
        private BankContext db;

        public AccountRepository(BankContext context)
        {
            db = context;
        }

        public Account Get(int id)
        {
            return db.Accounts.Find(id);
        }

        public void Create(Account account)
        {
            db.Accounts.Add(account);
            Console.WriteLine(account.AccountId);
            db.SaveChanges();
        }

        public void Update(Account account)
        {
            db.Entry(account).State = EntityState.Modified;
        }

        public IEnumerable<Account> GetAll()
        {
            return db.Accounts;
        }

        public void Delete(int id)
        {
            Account account = db.Accounts.Find(id);
            if (account != null)
                db.Accounts.Remove(account);
        }
    }
}

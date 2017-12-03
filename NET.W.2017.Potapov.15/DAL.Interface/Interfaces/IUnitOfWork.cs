using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.Interface.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Account> Accounts { get; }
        IRepository<AccountType> AccountTypes { get; }

        void Save();
    }
}

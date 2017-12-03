using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace BLL.Interface.Interfaces
{
    public interface IAccountService
    {
        void OpenAccount(AccountDTO account);

        void CloseAccount(int account);

        void Deposit(int id, decimal sum);

        void Withdraw(int id, decimal sum);
    }
}

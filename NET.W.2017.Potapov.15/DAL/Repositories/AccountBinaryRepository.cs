using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using DAL.Interface.DTO;
using DAL.Interface.Interfaces;
using BLL.Interface.Interfaces;

namespace DAL.Repositories
{
    public class AccountBinaryRepository : IRepository<IAccountService>
    {
        private string path;

        public AccountBinaryRepository(string path)
        {
            this.path = path;
        }

        public void SaveToFile(IAccountService element)
        {
            var accounts = element.GetAllAccounts();
            BinaryFormatter bf = new BinaryFormatter();
            AccountDTO dto = new AccountDTO();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                foreach (var account in accounts)
                {
                    dto.accountNumber = account.AccountNumber;
                    dto.accountType = account.AccountType;
                    dto.balance = account.Balance;
                    dto.bonus = account.Bonus;
                    dto.owenerName = account.OwenerName;
                    bf.Serialize(fs, dto);
                }
            }
        }

        public IEnumerable<object> LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            AccountDTO dto = new AccountDTO();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (List<AccountDTO>)bf.Deserialize(fs);
            }
        }
    }
}
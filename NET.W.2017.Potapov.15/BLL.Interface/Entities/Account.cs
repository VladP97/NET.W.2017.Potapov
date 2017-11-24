using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class Account
    {
        private int accountNumber;
        private string owenerName;
        private decimal balance = 0;
        private int bonus = 0;
        private AccountType accountType;

        public Account(int accountNumber, string owenerName, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.owenerName = owenerName;
            this.accountType = accountType;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public string OwenerName
        {
            get { return owenerName; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
        }

        public int BonusIncrease
        {
            get { return accountType.bonusIncerease; }
        }

        public int BonusDecrease
        {
            get { return accountType.bonusDecerease; }
        }

        public override string ToString()
        {
            return owenerName + ": " + accountNumber + " balance = " + balance + " bonus = " + bonus + " account type " + accountType;
        }
    }
}

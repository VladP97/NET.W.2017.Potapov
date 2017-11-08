using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bank
{
	[Serializable]
	public class Account: IEquatable<Account>
	{
		private int accountNumber;
		private string firstname;
		private string lastname;
		private decimal balance;
		private int bonus;
		private IAccountType accountType;
		private BonusAlgorithm bonusAlgorithm = new StandartBonusAlgorithm();

		public int AccountNumber
		{
			get
			{
				return accountNumber;
			}
		}

		public string Firstname
		{
			get
			{
				return firstname;
			}
		}

		public string Lastname
		{
			get
			{
				return lastname;
			}
		}

		public decimal Balance
		{
			get
			{
				return balance;
			}
			private set
			{
				balance = value;			
			}

		} 

		public int Bonus
		{
			get
			{
				return bonus;
			}
			private set
			{
				bonus = value;
			}
		}

		public string AccountType
		{
			get
			{
				return accountType.ToString();
			}
		}

		public BonusAlgorithm BonusAlgorithm
		{
			set
			{
				bonusAlgorithm = value;
			}
		}

		public Account(int accountNumber, string firstname, string lastname, decimal balance, IAccountType accountType, int bonus = 0)
		{
			this.accountNumber = accountNumber;
			this.firstname = firstname;
			this.lastname = lastname;
			this.balance = balance;
			this.accountType = accountType;
			this.bonus = bonus;
		}

		public Account(int accountNumber, string firstname, string lastname, decimal balance, IAccountType accountType, BonusAlgorithm bonusAlgorithm, int bonus = 0)
		{
			this.accountNumber = accountNumber;
			this.firstname = firstname;
			this.lastname = lastname;
			this.balance = balance;
			this.accountType = accountType;
			this.bonus = bonus;
			this.bonusAlgorithm = bonusAlgorithm;
		}

		/// <summary>
		/// Replenish balance.
		/// </summary>
		/// <param name="sum">Sum to replenish balance</param>
		public void ReplenishBalance(decimal sum)
		{
			balance += sum;
			bonus += bonusAlgorithm.IncreaseBonus(accountType.BonusIncrease, sum);
		}

		/// <summary>
		/// Withdraw money from balance.
		/// </summary>
		/// <param name="sum">Sum to withdraw from balance</param>
		public void WithdrawMoney(decimal sum)
		{
			balance -= sum;
			bonus -= bonusAlgorithm.DecreaseBonus(accountType.BonusDecrease, sum);
		}

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString()
		{
			return AccountNumber.ToString() + " " + Firstname + " " + Lastname + " " + Balance.ToString() + " " + accountType.ToString() + " " + Bonus.ToString();
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public bool Equals(Account obj)
		{
			return GetHashCode() == obj.GetHashCode();
		}

		/// <summary>
		/// Serves as the default hash function.
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return (AccountNumber + firstname.GetHashCode() + lastname.GetHashCode() + balance.GetHashCode() + bonus.GetHashCode()) * -1;
		}
	}
}
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
		private string path;

		public string Path
		{
			get
			{
				return path;
			}
		}

		public BankAccount(string path)
		{
			this.path = path ?? throw new NullReferenceException();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			fs.Close();
		}

		public BankAccount(string path, List<Account> accountList)
		{
			this.path = path ?? throw new NullReferenceException();
			BinaryFormatter bf = new BinaryFormatter();
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				foreach (var account in accountList)
				{
					bf.Serialize(fs, account);
				}
			}
		}

		/// <summary>
		/// Adds account to storage.
		/// </summary>
		/// <param name="account">Account to add.</param>
		public void CreateNewAccount(Account account)
		{
			BinaryFormatter bf = new BinaryFormatter();
			List<Account> accountList;
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				if (fs.Length != 0)
				{
					accountList = (List<Account>)bf.Deserialize(fs);
				}
				else
				{
					accountList = new List<Account>();
				}
				if (accountList.Contains(account))
				{
					throw new ArgumentException();
				}
				accountList.Add(account);
			}
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				bf.Serialize(fs, accountList);
			}
		}

		/// <summary>
		/// Close account in storage.
		/// </summary>
		/// <param name="account">Account to close.</param>
		public void CloseAccount(Account account)
		{
			BinaryFormatter bf = new BinaryFormatter();
			List<Account> accountList;
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				if (fs.Length != 0)
				{
					accountList = (List<Account>)bf.Deserialize(fs);
				}
				else
				{
					accountList = new List<Account>();
				}
				if (!accountList.Contains(account))
				{
					throw new ArgumentException();
				}
				accountList.Remove(account);
			}
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				bf.Serialize(fs, accountList);
			}
		}

		/// <summary>
		/// Returns a List of Account that represents the current binary flie.
		/// </summary>
		/// <returns>Return List of Account.</returns>
		public List<Account> GetAccountList()
		{
			BinaryFormatter bf = new BinaryFormatter();
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				return (List<Account>)bf.Deserialize(fs);
			}

		}

		/// <summary>
		/// Returns Account by account number.
		/// </summary>
		/// <param name="number">Account number.</param>
		/// <returns>Account by number.</returns>
		public Account GetAccountByNumber(int number)
		{
			List<Account> accountList = GetAccountList();
			foreach (var account in accountList)
			{
				if (account.AccountNumber == number)
				{
					return account;
				}
			}
			return null;
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Tests
{
	[TestClass()]
	public class BankAccountTests
	{
		[TestMethod()]
		public void CreateNewAccountTest()
		{
			//BankAccount ba = new BankAccount("BankTest1.bin");
			Account acc = new Account(123456, "name2", "lastname2", 0, new BaseAccount(new StandartAlgorithm()));
			//List<Account> accList = ba.GetAccountList();
			//foreach (var item in accList)
			//{
			//	item.ReplenishBalance(10);
			//	Console.WriteLine(item.Bonus); 
			//}
			
			acc.ReplenishBalance(100);
			acc.WithdrawMoney(10);
			Console.WriteLine(acc.Bonus);
		}

		[TestMethod()]
		public void CloseAccountTest()
		{
			//BankAccount ba = new BankAccount("BankTest2.bin");
			//List<Account> expectedResult = new List<Account>
			//{
			//	new Account(123456, "name1", "lastname1", 0, new BaseAccount()),
			//	new Account(123458, "name3", "lastname3", 0, new BaseAccount())
			//};

			//ba.CreateNewAccount(new Account(123456, "name1", "lastname1", 0, new BaseAccount()));
			//ba.CreateNewAccount(new Account(123457, "name2", "lastname2", 0, new BaseAccount()));
			//ba.CreateNewAccount(new Account(123458, "name3", "lastname3", 0, new BaseAccount()));
			//ba.CloseAccount(new Account(123457, "name2", "lastname2", 0, new BaseAccount()));
			//List<Account> accList = ba.GetAccountList();

		}

		[TestMethod()]
		public void BonusTest()
		{
			//BankAccount ba = new BankAccount("BankTest3.bin");

			//ba.CreateNewAccount(new Account(123456, "name1", "lastname1", 0, new BaseAccount()));
			//ba.CreateNewAccount(new Account(123457, "name2", "lastname2", 0, new GoldAccount()));
			//ba.CreateNewAccount(new Account(123458, "name3", "lastname3", 0, new PlatinumAccount()));

			//foreach (var account in ba.GetAccountList())
			//{
			//	account.ReplenishBalance(10);
			//	Console.WriteLine(account.Bonus);
			//}
		}
	}
}
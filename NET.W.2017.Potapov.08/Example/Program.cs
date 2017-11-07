using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace Example
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount bankAccount = new BankAccount("BankExample.bin");
			bankAccount.CreateNewAccount(new Account(123456, "name1", "lastname1", 0, new BaseAccount()));
			bankAccount.CreateNewAccount(new Account(123457, "name2", "lastname2", 0, new GoldAccount()));
			bankAccount.CreateNewAccount(new Account(123458, "name3", "lastname3", 0, new PlatinumAccount()));
			foreach (var accountFromList in bankAccount.GetAccountList())
			{
				Console.WriteLine(accountFromList);
			}
			Console.WriteLine();
			Console.WriteLine("Replenish balance");
			Account account = bankAccount.GetAccountByNumber(123457);
			account.ReplenishBalance(100);
			Console.WriteLine($"Account number {account.AccountNumber}, account balance {account.Balance}, account bonus {account.Bonus}");
			Console.WriteLine("Withdraw money");
			account.WithdrawMoney(10);
			Console.WriteLine($"Account number {account.AccountNumber}, account balance {account.Balance}, account bonus {account.Bonus}");
			Console.ReadLine();
		}
	}
}

using System;
using System.Linq;
using BLL.Interface.Interfaces;
using DependencyResolver;
using Ninject;
using DAL.Model;
using DAL.Interface.DTO;

namespace ConsolePL
{
    class Program
    {
        private static readonly IKernel resolver;

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }

        static void Main(string[] args)
        {
            AccountType baseAccount = new AccountType { BonusDecrease = 10, BonusIncrease = 10, Name = "Base" };
            IAccountService accountService = resolver.Get<IAccountService>();
            accountService.OpenAccount(new AccountDTO { AccountId = 1, AccountOwner = "Owener 1", Balance = 0, Bonus = 0, TypeId = baseAccount });
            accountService.OpenAccount(new AccountDTO { AccountId = 2, AccountOwner = "Owener 2", Balance = 0, Bonus = 0, TypeId = baseAccount });
            accountService.Deposit(1, 100);
            accountService.Deposit(2, 100);
        }
    }
}

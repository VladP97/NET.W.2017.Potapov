using System;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using DependencyResolver;
using Ninject;

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
            IAccountService service = resolver.Get<IAccountService>();

            IAccountNumberCreateService creator = resolver.Get<IAccountNumberCreateService>();

            AccountType baseAccount = resolver.Get<Base>();
            AccountType goldAccount = resolver.Get<Gold>();

            service.OpenAccount("Account owner 1", baseAccount, creator);
            service.OpenAccount("Account owner 2", baseAccount, creator);
            service.OpenAccount("Account owner 3", goldAccount, creator);
            service.OpenAccount("Account owner 4", baseAccount, creator);

            var creditNumbers = service.GetAllAccounts().Select(acc => acc.AccountNumber).ToArray();

            foreach (var t in creditNumbers)
            {
                service.DepositAccount(t, 100);
            }

            foreach (var item in service.GetAllAccounts())
            {
                Console.WriteLine(item);
            }

            foreach (var t in creditNumbers)
            {
                service.WithdrawAccount(t, 10);
            }

            foreach (var item in service.GetAllAccounts())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

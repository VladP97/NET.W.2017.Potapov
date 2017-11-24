using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using BLL.ServiceImplementation;
using DAL.Fake.Repositories;
using DAL.Interface.Interfaces;
using DAL.Repositories;
using Ninject;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IBonusAlgorithm>().To<StandartBonusAlgorithm>().InSingletonScope();
            kernel.Bind<IAccountService>().To<AccountService>().WithConstructorArgument("bonusAlgorithm", StandartBonusAlgorithm.GetInstance());
            kernel.Bind<AccountType>().To<Base>().InSingletonScope();
            kernel.Bind<AccountType>().To<Gold>().InSingletonScope();
            kernel.Bind<IRepository<IAccountService>>().To<FakeRepository>();
            kernel.Bind<IRepository<IAccountService>>().To<AccountBinaryRepository>().WithConstructorArgument("test.bin");
            kernel.Bind<IAccountNumberCreateService>().To<AccountNumberCreator>().InSingletonScope();
            //kernel.Bind<IApplicationSettings>().To<ApplicationSettings>();
        }
    }
}

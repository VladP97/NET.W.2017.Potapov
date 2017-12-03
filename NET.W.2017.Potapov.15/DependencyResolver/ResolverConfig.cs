using BLL.Interface.Interfaces;
using BLL.ServiceImplementation;
using DAL.Interface.Interfaces;
using DAL.Repositories;
using Ninject;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IAccountService>().To<AccountService>().WithConstructorArgument(kernel.Get<IUnitOfWork>());
            //kernel.Bind<IRepository>().To<FakeRepository>();
            //kernel.Bind<IRepository>().To<AccountBinaryRepository>().WithConstructorArgument("test.bin");
            //kernel.Bind<IAccountNumberCreateService>().To<AccountNumberCreator>().InSingletonScope();
            //kernel.Bind<IApplicationSettings>().To<ApplicationSettings>();
        }
    }
}

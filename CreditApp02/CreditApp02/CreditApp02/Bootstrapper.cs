using Autofac;
using CreditApp02.Core.ViewModels;
using CreditApp02.Infrastructure.Data;
using CreditApp02.Infrastructure.Data.Repositories;
using CreditApp02.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp02
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private readonly ContainerBuilder _builder;
        private ILifetimeScope _currentScope;

        private Bootstrapper()
        {
            _builder = new ContainerBuilder();
        }

        public static Bootstrapper Instance => _instance ?? (_instance = new Bootstrapper());

        public static IContainer Container { get; set; } 

        public void Initialize()
        {
            //SingleInstance
            _builder.RegisterType<DatabaseRepository>().As<IDatabaseRepository>().SingleInstance();
            _builder.RegisterType<DatabaseManager>().As<IDatabaseManager>().SingleInstance();

            //screen viewmodels
             _builder.RegisterType<HomeViewModel>().InstancePerLifetimeScope();

            Container = _builder.Build();
        }
    }
}

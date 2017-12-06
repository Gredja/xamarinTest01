using Autofac;
using CreditApp02.Infrastructure.Data.Repositories;
using CreditApp02.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp02
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private readonly ContainerBuilder _builder;
        private readonly ILifetimeScope _currentScope;

        private Bootstrapper()
        {
            _builder = new ContainerBuilder();
            _currentScope = _builder.Build();
        }

        public static Bootstrapper Instance => _instance ?? (_instance = new Bootstrapper());

        public T Resolve<T>()
        {
            return _currentScope.Resolve<T>();
        }

        public void Initialize()
        {
            //SingleInstance
            _builder.RegisterType<DatabaseRepository>().As<IDatabaseRepository>().SingleInstance();

            //screen viewmodels
            // _builder.RegisterType<HomeViewModel>().InstancePerLifetimeScope();
        }
    }
}

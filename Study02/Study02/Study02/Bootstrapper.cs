using Autofac;

namespace Study02
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private readonly ILifetimeScope _currentScope;

        private Bootstrapper()
        {
            var builder = new ContainerBuilder();
            _currentScope = builder.Build();
            Initialize(builder);
        }

        public static Bootstrapper Instance => _instance ?? (_instance = new Bootstrapper());

        public T Resolve<T>()
        {
            return _currentScope.Resolve<T>();
        }

        private void Initialize(ContainerBuilder builder)
        {
            //SingleInstance
          //  builder.RegisterType<DatabaseRepository>().As<IDatabaseRepository>().SingleInstance();
        }
    }
}

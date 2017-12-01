using System;
using Autofac;
using Autofac.Core;

namespace Study02
{
    public abstract class Bootstrapper
    {
        private ContainerBuilder _builder;
        private ILifetimeScope _currentScope;
        private ILifetimeScope _rootScope;
        public static Bootstrapper Instance { get; private set; }

        public static bool TryInit(Bootstrapper instance)
        {
            if (Instance != null)
            {
                return false;
            }

            Instance = instance;
            Instance.Initialize();
            return true;
        }

        public void StartScope()
        {
            _rootScope = _builder.Build();
            _currentScope = _rootScope.BeginLifetimeScope();
        }

        public void RestartScope()
        {
            _currentScope.Dispose();
            StartScope();
        }

        public T Resolve<T>(params Parameter[] par)
        {
            return _currentScope.Resolve<T>(par);
        }

        public T Resolve<T>()
        {
            return _currentScope.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _currentScope.Resolve(type);
        }

        public object Resolve(Type type, params Parameter[] par)
        {
            return _currentScope.Resolve(type, par);
        }

        public Lazy<T> LazyResolve<T>()
        {
            return new Lazy<T>(() => Resolve<T>());
        }

        public Lazy<T> LazyResolve<T>(params Parameter[] par)
        {
            return new Lazy<T>(() => Resolve<T>(par));
        }

        protected abstract void PlatformInitialize(ContainerBuilder builder);

        private void Initialize()
        {
            _builder = new ContainerBuilder();
            PlatformInitialize(_builder);
            Initialize(_builder);
        }

        private void Initialize(ContainerBuilder builder)
        {
            //SingleInstance
            //builder.RegisterType<LocalSettings>().As<ILocalSettings>().SingleInstance();

            //screen viewmodels
           // builder.RegisterType<MainPageViewModel>().InstancePerLifetimeScope();

        }
    }
}

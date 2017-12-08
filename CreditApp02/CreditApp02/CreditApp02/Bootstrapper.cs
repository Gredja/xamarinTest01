﻿using Autofac;
using CreditApp02.Core.UWP;
using CreditApp02.Core.ViewModels;
using CreditApp02.Infrastructure.Data;
using CreditApp02.Infrastructure.Data.Converters;
using CreditApp02.Infrastructure.Data.Converters.Interfaces;
using Ninject;
using Ninject.Parameters;

namespace CreditApp02.Core
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private readonly StandardKernel _kernel;
        private ILifetimeScope _currentScope;

        private Bootstrapper()
        {
            _kernel = new StandardKernel();

            _kernel.Bind<IAppFolderToStringConverter>().To<AppFolderToStringConverter>().InSingletonScope();
            _kernel.Bind<ISqLiteConnection>().To<SqLiteConnection>().InSingletonScope();

            _kernel.Bind<HomeViewModel>().ToSelf().InSingletonScope();
        }

        public static Bootstrapper Instance => _instance ?? (_instance = new Bootstrapper());

        public T Create<T>()
        {
            return _kernel.Get<T>();
        }

        public T Create<T>(string propertyName, object value)
        {
            return _kernel.Get<T>(new ConstructorArgument(propertyName, value));
        }

        public T Create<T>(string propertyName1, object value1, string propertyName2, object value2)
        {
            return _kernel.Get<T>(new ConstructorArgument(propertyName1, value1), new ConstructorArgument(propertyName2, value2));
        }

        public void Initialize()
        {
            //SingleInstance
          //  _kernel.Build().AppFolderToStringConverter>().As<IAppFolderToStringConverter>().InstancePerLifetimeScope();

        
            //_kernel.<SqLiteConnection>().As<ISqLiteConnection>().InstancePerLifetimeScope();
            //_kernel.<DatabaseRepository>().As<IDatabaseRepository>().SingleInstance();
            //_kernel.<DatabaseManager>().As<IDatabaseManager>().SingleInstance();



            //screen viewmodels
         

        }
    }
}

using Autofac;
using Cenito.iSnip.ViewModels;
using Cenito.iSnip.ViewModels.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenito.iSnip.IoC
{
    public class ServiceLocator
    {
        private static IContainer _container;

        static ServiceLocator()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewModel>().As<IMainViewModel>();

            _container = builder.Build();
        }

        public static IMainViewModel MainViewModel => _container.Resolve<IMainViewModel>();
    }
}

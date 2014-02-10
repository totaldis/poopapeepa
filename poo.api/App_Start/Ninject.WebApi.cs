using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject.Modules;
using Ninject;
using System.Web.Http;
using poo.api.Repositorys.Contracts;
using poo.api.Repositorys;

namespace poo.api.ninject
{
    public class NinjectHttpResolver : IDependencyResolver, IDependencyScope
    {
        public IKernel Kernel { get; private set; }
        public NinjectHttpResolver(params NinjectModule[] modules)
        {
            Kernel = new StandardKernel(modules);
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }

        public void Dispose()
        { 
            // ndada 
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }

    public class NinjectHttpModules
    {
        public static NinjectModule[] Modules
        {
            get
            {
                return new[] { new MainModule() };
            }
        }

        public class MainModule : NinjectModule
        {
            public override void Load()
            {
                // Bind your repositories here
                Bind<IEntitiesRepository>().To<EntitiesRepository>();
            }
        }
    }

    // Register modules and resolve dependencies
    public class NinjectHttpContainer
    {
        private static NinjectHttpResolver _resolver;

        public static void RegisterModules(NinjectModule[] modules)
        {
            _resolver = new NinjectHttpResolver(modules);
            GlobalConfiguration.Configuration.DependencyResolver = _resolver;
        }

        public static T Resolve<T>()
        {
            return _resolver.Kernel.Get<T>();
        }
    }
}
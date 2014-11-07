using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace MVC3Ninject
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _container;

        public UnityDependencyResolver(IUnityContainer cont)
        {
            _container = cont;
        }

        public object GetService(Type serviceType)
        {
            if(!_container.IsRegistered(serviceType))
            {
                return null;
            }
            else
            {
                return _container.Resolve(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if(!_container.IsRegistered(serviceType))
            {
                return new List<object>();
            }
            else
            {
                return _container.ResolveAll(serviceType);
            }
        }
    }
    
}
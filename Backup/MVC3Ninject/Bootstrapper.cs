using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using MVC3Ninject.Controllers;
using MVC3Ninject.Models;

namespace MVC3Ninject
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer container = null;

        private static IUnityContainer BuildUnityContainer()
        {
            container = new UnityContainer();

            container.RegisterType<HomeController>();
            container.RegisterType<IRepository, FakeCarRepository>(new ContainerControlledLifetimeManager());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }
    }
}
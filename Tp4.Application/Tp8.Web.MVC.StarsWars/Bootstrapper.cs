using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Tp4.AccesData.Queries;
using Tp4.AccesData.Queries.Repository;
using Tp7.Service;
using Unity.Mvc3;

namespace Tp8.Web.MVC.StarsWars
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IStarWarsService, StarWarsService>();
            container.RegisterType<IStarWarsQuery, StarWarsQuery>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}
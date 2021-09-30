using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Tp4.AccesData.Command;
using Tp4.AccesData.Command.Repository;
using Tp4.AccesData.Queries;
using Tp4.AccesData.Queries.Repository;
using Tp7.Service;
using Unity.Mvc3;

namespace Tp7.Web.UI.MVC
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

            container.RegisterType<IShippersService, ShippersService>();
            container.RegisterType<IGenericRepository, GenericRepository>();
            container.RegisterType<ICompaniasEnviosQuery, CompaniasEnviosQuery>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}
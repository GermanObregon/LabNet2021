using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tp4.AccesData.Command;
using Tp4.AccesData.Command.Repository;
using Tp4.AccesData.Queries;
using Tp4.AccesData.Queries.Repository;
using Tp7.Service;
using Tp8.Web.Api.App_Start;

namespace Tp8.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            
            var container = new UnityContainer();
            container.RegisterType<IShippersService, ShippersService>();
            container.RegisterType<IGenericRepository, GenericRepository>();
            container.RegisterType<ICompaniasEnviosQuery, CompaniasEnviosQuery>();
            config.DependencyResolver = new UnityResolver(container);
            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

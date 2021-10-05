using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Tp4.Domain.DTO_S;
using Tp7.Service;
using Tp8.Web.MVC.StarsWars.Models;

namespace Tp8.Web.MVC.StarsWars.Controllers
{
    public class StarWarsController : Controller
    {
        private readonly IStarWarsService Service;
        public StarWarsController(IStarWarsService service)
        {
            this.Service = service;
        }
        

        
        public ActionResult Index()
        {
            
            return View();
        }

       
        public  async Task<JsonResult> GetPersonajes()
        {
            var response = await Service.GetPersonajes();
            var lista = response.Select(R => new PersonajeViewModel
            {
                Nombre = R.Nombre,
                Altura = R.Altura,
                ColorPelo = R.ColorPelo,
                ColorOjos = R.ColorOjos,
                Genero = R.Genero

            }).ToList();
           
           return Json(new {lista = lista }, JsonRequestBehavior.AllowGet);

        }
       

       

        
      
    }
}

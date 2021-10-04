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
        

        // GET: StarWars
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: StarWars/Details/5


        // GET: StarWars/Create
        public  async Task<JsonResult> GetPersonajes()
        {
            var response = await Service.GetPersonajes();
            var lista = response.Select(R => new PersonajeViewModel
            {
                Nombre = R.Nombre,
                Altura = R.Altura,
                ColorOjos = R.ColorOjos,
                ColorPelo = R.ColorPelo,
                Genero = R.Genero

            }).ToList();
           
           return Json(new {lista = lista }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: StarWars/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StarWars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StarWars/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StarWars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StarWars/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

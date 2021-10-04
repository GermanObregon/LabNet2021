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
        

        // GET: StarWars
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: StarWars/Details/5


        // GET: StarWars/Create
        public async Task<JsonResult> GetPersonajes()
        {
            HttpClient cliente = new HttpClient();
            var json = await cliente.GetStringAsync("https://swapi.dev/api/people/");
            var personajes = JsonConvert.DeserializeObject<StarWarsApiViewModel>(json);
            var personaje = personajes.Results.Select(P => new PersonajeViewModel
            {
                Nombre = P.name,
                Altura = P.Height,
                ColorOjos = P.Eye_Color,
                ColorPelo = P.Hair_Color,
                Genero = P.Gender

            }).Take(5);
            return Json(new { lista = personaje }, JsonRequestBehavior.AllowGet);

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

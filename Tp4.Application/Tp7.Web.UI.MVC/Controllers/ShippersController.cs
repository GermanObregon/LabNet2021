using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tp4.Domain.Models;
using Tp7.Service;
using Tp7.Web.UI.MVC.Models;

namespace Tp7.Web.UI.MVC.Controllers
{
    public class ShippersController : Controller
    {
        private readonly IShippersService Service;
        public ShippersController(IShippersService service)
        {
            this.Service = service;
        }
        // GET: Shippers
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            List<Shippers> shippers = new List<Shippers>();
            shippers = Service.GetAllShippers();
            var shippersList = shippers.Select(S => new ShippersViewModel
            {
                IdShipper = S.ShipperID,
                NombreCompania = S.CompanyName,
                Telefono = S.Phone

            });
            return Json(new { lista = shippersList }, JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetShipper(int id)
        {
            Shippers shipperAux = Service.GetById(id);
            var shipper = new ShippersViewModel
            {
                IdShipper = shipperAux.ShipperID,
                NombreCompania = shipperAux.CompanyName,
                Telefono = shipperAux.Phone

            };

            return Json(shipper, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddEditShipper(Shippers shipper)
        {
            bool response = true;
            try
            {
                if (shipper.ShipperID == 0)
                {
                    Service.AddShipper(shipper);
                }
                else
                {
                    Service.UpdateShipper(shipper);
                }

            }
            catch 
            {
                
                response = false;
            }
            return Json(new { response = response }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteShipper(int id)
        {
            bool response = true;
            try
            {
                Service.DeleteShipper(id);

            }
            catch (Exception e)
            {
                ViewBag.DeleteError = e.Message; 
                response = false;
            }
            return Json(new { response = response }, JsonRequestBehavior.AllowGet);
        }
    }
}
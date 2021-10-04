using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Tp4.AccesData.Command;
using Tp4.AccesData.Command.Repository;
using Tp4.AccesData.Queries;
using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.Models;
using Tp7.Service;

using Newtonsoft.Json;
using Tp8.Web.Api.Models.Response;
using Tp8.Web.Api.Models.Request;

namespace Tp8.Web.Api.Controllers
{
    public class ShippersController : ApiController
    {
        private readonly IShippersService Service;
        
        public ShippersController(IShippersService service)
        {
            
            this.Service = service;
        }
       
        public List<ShipperResponse> GetShippers()
        {
            var shippersList = Service.GetAllShippers().Select(S => new ShipperResponse
            {
                IdShipper = S.ShipperID,
                NombreCompania = S.CompanyName,
                Telefono = S.Phone

            }).ToList();
            return shippersList;

        }

       
        public IHttpActionResult GetShipper(int id)
        {
            try
            {
                Shippers shipper = Service.GetById(id);
                var shipperResponse = new ShipperResponse
                {
                    IdShipper = shipper.ShipperID,
                    NombreCompania = shipper.CompanyName,
                    Telefono = shipper.Phone
                };
                return Ok(shipperResponse);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }

            
         
        }

       
        public IHttpActionResult CreateShipper([FromBody] ShipperRequest shipperRequest)
        {
            try
            {
                var shipper = new Shippers
                {
                    CompanyName = shipperRequest.NombreCompania,
                    Phone = shipperRequest.Telefono
                };

                Service.AddShipper(shipper);

                return Content(HttpStatusCode.Created, shipper);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.BadRequest, e.Message);
            }
            
        }

        
        public IHttpActionResult UpdateShipper(int id, [FromBody] ShipperRequest shipperRequest)
        {
            try
            {
                var shipper = new Shippers
                {
                    ShipperID = id,
                    CompanyName = shipperRequest.NombreCompania,
                    Phone = shipperRequest.Telefono
                };

                Service.UpdateShipper(shipper);

                return Content(HttpStatusCode.OK , shipper);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Service.DeleteShipper(id);
                return Ok();
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }

        }
    }
}

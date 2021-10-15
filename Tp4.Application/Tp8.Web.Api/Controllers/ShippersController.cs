using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;

using Tp4.Domain.Models;
using Tp7.Service;


using Tp8.Web.Api.Models.Response;
using Tp8.Web.Api.Models.Request;
using System.Web.Http.Cors;

namespace Tp8.Web.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods:"*")]
    public class ShippersController : ApiController
    {
        private readonly IShippersService Service;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        public ShippersController(IShippersService service)
        {
            
            this.Service = service;
        }
       // GET: api/Shippers
       /// <summary>
       /// Listado de Shippers
       /// </summary>
       /// <returns></returns>
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

        // GET: api/Shippers/{id}
        /// <summary>
        /// Obtener Shipper por Id
        /// </summary>
        /// <param name="id">Id del Elemento por Route Param</param>
        /// <returns></returns>
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

        //POST: api/Shippers
        /// <summary>
        /// Crear un Shipper
        /// </summary>
        /// <param name="shipperRequest">Json From body</param>
        /// <returns></returns>
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

        //PUT: api/Shippers/{id}
        /// <summary>
        /// Editar un Shipper
        /// </summary>
        /// <param name="id">Id del Elemento por Route Param</param>
        /// <param name="shipperRequest">Json From body</param>
        /// <returns></returns>
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

                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }
        // DELETE: api/Shippers/{id}
        /// <summary>
        /// Borrar un Shipper por Id
        /// </summary>
        /// <param name="id">Id del Elemento por Route Param</param>
        /// <returns></returns>

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

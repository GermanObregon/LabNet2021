
using System.Collections.Generic;
using System.Linq;
using System;
using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.Models;

namespace Tp4.AccesData.Queries
{
    public class CompaniasEnviosQuery : ICompaniasEnviosQuery
    {
        private readonly NorthwindContext Contexto;
        public CompaniasEnviosQuery()
        {
            this.Contexto = new NorthwindContext();
        }

        public Shippers GetShipperById(int id)
        {
            try
            {
                return Contexto.Shippers.Find(id);
            }
            catch (Exception)
            {

                throw new Exception("Hubo un error al buscar el id");
            }
            
        }

        public List<Shippers> GetShippers()
        {
            try
            {
                return Contexto.Shippers.ToList();
            }
            catch (Exception )
            {

                throw new Exception("Hubo un error al intentar buscar el listado de compañias");
            }
            
        }
    }
}

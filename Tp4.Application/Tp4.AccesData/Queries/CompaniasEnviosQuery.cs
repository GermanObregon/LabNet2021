
using System.Collections.Generic;
using System.Linq;

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
            return Contexto.Shippers.Find(id);
        }

        public List<Shippers> GetShippers()
        {
            return Contexto.Shippers.ToList();
        }
    }
}

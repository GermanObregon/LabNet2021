
using System.Collections.Generic;
using System.Linq;

using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.Models;

namespace Tp4.AccesData.Queries
{
    public class CompaniasEnvios : ICompaniasEnvios
    {
        private readonly NorthwindContext Contexto;
        public CompaniasEnvios()
        {
            this.Contexto = new NorthwindContext();
        }
        public List<Shippers> GetShippers()
        {
            return Contexto.Shippers.ToList();
        }
    }
}

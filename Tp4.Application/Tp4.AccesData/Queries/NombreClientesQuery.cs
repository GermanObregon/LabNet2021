
using System.Collections.Generic;
using System.Linq;

using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.DTO_S;

namespace Tp4.AccesData.Queries
{
    public class NombreClientesQuery : INombreClienteQuery
    {
        private readonly NorthwindContext Contexto;

        public NombreClientesQuery()
        {
            this.Contexto = new NorthwindContext();
        }

        public List<ClienteDto> GetAllClients()
        {
            using (Contexto)
            {
                var query = (from C in Contexto.Customers
                             select new ClienteDto
                             {
                                 NombreCliente = C.CompanyName
                             }).ToList();

                return query;
            }
        }
    }
}

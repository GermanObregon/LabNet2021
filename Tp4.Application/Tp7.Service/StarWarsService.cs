using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.DTO_S;

namespace Tp7.Service
{
    public interface IStarWarsService
    {
        Task<List<PersonajeDto>> GetPersonajes();
    }
    public class StarWarsService : IStarWarsService
    {
        private readonly IStarWarsQuery Query;
        public StarWarsService(IStarWarsQuery query)
        {
            this.Query = query;
        }
        public async Task<List<PersonajeDto>> GetPersonajes()
        {
            return await Query.GetPersonajesStarWars();
        }
    }
}

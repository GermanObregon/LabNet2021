using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Tp4.Domain.DTO_S;

namespace Tp4.AccesData.Queries.Repository
{
    public interface IStarWarsQuery
    {
        Task<List<PersonajeDto>> GetPersonajesStarWars();
    }
}

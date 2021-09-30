
using System.Collections.Generic;

using Tp4.Domain.Models;

namespace Tp4.AccesData.Queries.Repository
{
    public interface ICompaniasEnviosQuery
    {
        List<Shippers> GetShippers();
        Shippers GetShipperById(int id);
    }
}

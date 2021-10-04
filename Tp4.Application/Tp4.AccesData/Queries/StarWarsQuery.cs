using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.DTO_S;

namespace Tp4.AccesData.Queries
{
    public class StarWarsQuery : IStarWarsQuery
    {
        public async Task<List<PersonajeDto>> GetPersonajesStarWars()
        {
            HttpClient cliente = new HttpClient();
            var json = await cliente.GetStringAsync("https://swapi.dev/api/people/");
            var personajes = JsonConvert.DeserializeObject<StarWarsApiDto>(json);
            var personajesList = personajes.Results.Select(P => new PersonajeDto
            {
                Nombre = P.name,
                Altura = P.Height,
                ColorOjos = P.Eye_Color,
                ColorPelo = P.Hair_Color,
                Genero = P.Gender

            }).Take(5).ToList();
            
            return personajesList; 
        }
    }
}

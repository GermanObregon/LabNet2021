using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.Domain.DTO_S
{
    public class StarWarsPersonajes
    {
        public string name { get; set; }
        public string Height { get; set; }
        public string Hair_Color { get; set; }
        public string Eye_Color { get; set; }
        public string Gender { get; set; }
        public string Mass { get; set; }
        public string SkinColor { get; set; }
        public string Birth_year { get; set; }
        public string Homeworld { get; set; }
        public ICollection<string> Films { get; set; }
        public ICollection<string> Species { get; set; }
        public ICollection<string> Vehicles { get; set; }
        public ICollection<string> Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }

    }
}

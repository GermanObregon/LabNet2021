using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.Domain.DTO_S
{
    public class StarWarsApiDto
    {
        public string Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public ICollection<StarWarsPersonajes> Results { get; set; }

    }
}

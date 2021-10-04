using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp8.Web.MVC.StarsWars.Models
{
    public class StarWarsApiViewModel
    {
        public string Count { get;set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public ICollection<StarWarsPersonajesViewModel> Results { get; set; }

    }
}
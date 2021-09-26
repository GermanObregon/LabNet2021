using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_S
{
    public class CustomerDto
    {
        public string NombreCompania { get; set; }
        public string NombreContacto { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Pais { get; set; }
    }    
}

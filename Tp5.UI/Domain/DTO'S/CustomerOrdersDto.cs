using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_S
{
    public class CustomerOrdersDto
    {
        public string NombreCompania { get; set; }
        public string NombreContacto { get; set; }
        public string Region { get; set; }
        public int OrdenId { get; set; }
        public DateTime FechaOrden { get; set; }
    }
}

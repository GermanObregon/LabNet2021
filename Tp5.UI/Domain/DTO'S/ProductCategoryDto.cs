using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_S
{
    public class ProductCategoryDto
    {
        public int? ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public Decimal? PrecioUnitario { get; set; }
        public short? Stock { get; set; }
        public string Categoria { get; set; }
    }
}

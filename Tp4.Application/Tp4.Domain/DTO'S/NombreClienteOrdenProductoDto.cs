using System;


namespace Tp4.Domain.DTO_S
{
    public class NombreClienteOrdenProductoDto
    {
        public string NombreCliente { get; set; }
        public int IdOrden { get; set; }
        public string NombreProducto { get; set; }
        public Decimal PrecioUnitario { get; set; }
    }
}

﻿
using System.Collections.Generic;

using Tp4.Domain.DTO_S;

namespace Tp4.AccesData.Queries.Repository
{
    public interface INombreClienteOrdenProducto
    {
        List<NombreClienteOrdenProductoDto> GetClientOrderProducts();
    }
}

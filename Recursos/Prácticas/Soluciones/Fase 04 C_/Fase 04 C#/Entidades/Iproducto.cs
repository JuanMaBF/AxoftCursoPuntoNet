using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    interface IProducto
    {
        Categoria Categoria { get; set; }
        string Descripcion { get; set; }
        double Margen { get; set; }
        string Nombre { get; set; }
        decimal PrecioBruto { get; }
        decimal PrecioCosto { get; set; }
        decimal PrecioVenta { get; }
        Empresa Proveedor { get; set; }
        Categoria SubCategoria { get; set; }
        DateTime FechaExpiracion { get; set; }
    }
}

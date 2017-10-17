using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface IAdminProducto : IAdminABM<Producto, int>
    {
        List<Producto> Listar(int pCategoria, int pSubcategoria);
    }
}

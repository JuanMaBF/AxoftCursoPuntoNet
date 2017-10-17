using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public interface IAdminProveedores : IAdminABM<Empresa, int>
    {
        void Eliminar(Empresa pProveedor);
    }
}

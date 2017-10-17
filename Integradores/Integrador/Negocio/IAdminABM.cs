using System.Collections.Generic;

namespace Negocio
{
    public interface IAdminABM <T, K>
    {
        List<T> Listar();
        T Listar(K value);
        void Agregar(T obj);
        void Modificar(T obj);
        void Eliminar(K value);
    }
}

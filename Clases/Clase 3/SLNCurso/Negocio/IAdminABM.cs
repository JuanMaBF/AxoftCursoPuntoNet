using System.Collections.Generic;

namespace Negocio
{
    public interface IAdminABM<T, I>
    {
        void Agregar(T profesor);
        void Modificar(T profesor);
        void Eliminar(T profesor);
        List<T> TraerTodos();
        List<T> TraerTodos(I especialidad);
    }
}

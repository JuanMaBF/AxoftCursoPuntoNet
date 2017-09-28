using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDemoInterface
{
    public interface IAdministrar
    {
        void agregar();
        void modificar();
        void eliminar();

        string Nombre { get; set; }
    }
}

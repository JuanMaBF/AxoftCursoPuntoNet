using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoFluentApi
{
    public class Cliente
    {
        public int CliId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Comentario { get; set; }
        public List<Factura> Facturas { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoFluentApi.Modelo
{
    public  class Factura
    {
        public int FactId { get; set; }
        public int CliId { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }

    }
}

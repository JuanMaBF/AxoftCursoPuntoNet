using System;

namespace WindowsDemoFluentApi
{
    public class Factura
    {
        public int FacId { get; set; }
        public int CliId { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
    }
}
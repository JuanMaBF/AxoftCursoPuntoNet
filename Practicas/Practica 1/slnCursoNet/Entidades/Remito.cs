using System;

namespace Entidades
{
    public class Remito : DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIva,
            string condicionVenta, string detalle, decimal total, DateTime fechaEntrega) 
            :base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }
    }
}

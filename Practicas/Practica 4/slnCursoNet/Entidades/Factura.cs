using System;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public string Tipo { get; set; }

        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIva,
            string condicionVenta, string detalle, decimal total, string tipo)
            : base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }
    }
}

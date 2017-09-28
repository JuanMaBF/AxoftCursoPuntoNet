using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Remito
    {
        public Remito(string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, string pDetalle, decimal pTotal, DateTime pFechaEntrega)
        {
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
            this.Total = pTotal;
            this.FechaEntrega = pFechaEntrega;
        }

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Remito: DocumentoComercial
    {
        public Remito(string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, List<Item> pDetalle, DateTime pFechaEntrega)
        {
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
            this.FechaEntrega = pFechaEntrega;
        }

        public DateTime FechaEntrega { get; set; }
    }
}

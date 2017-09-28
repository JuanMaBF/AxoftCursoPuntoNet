using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Remito: DocumentoComercial
    {
        public Remito(string pNumero, DateTime pFecha, string pCliente, string pDireccion, 
                        string pCondicionIVA, string pCondicionVenta, 
                        List<Item> pDetalle, 
                        decimal pTotal, DateTime pFechaEntrega)
            :base(pNumero,pFecha,pCliente,pDireccion,pCondicionIVA,pCondicionVenta,pDetalle,pTotal)
        {
            //this.Numero = pNumero;
            //this.Fecha = pFecha;
            //this.Cliente = pCliente;
            //this.Direccion = pDireccion;
            //this.CondicionIVA = pCondicionIVA;
            //this.CondicionVenta = pCondicionVenta;
            //this.Detalle = pDetalle;
            //this.Total = pTotal;
            this.FechaEntrega = pFechaEntrega;
        }

        public DateTime FechaEntrega { get; set; }
    }
}

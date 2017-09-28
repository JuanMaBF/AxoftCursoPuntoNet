using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public Factura(string pTipo, string pNumero, DateTime pFecha, string pCliente, string pDireccion,
            string pCondicionIVA, string pCondicionVenta, 
            //string pDetalle
           List<Item> pDetalle, 
            decimal pTotal)
        {
            this.Tipo = pTipo;
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
            this.Total = pTotal;
        }

        public string Tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class DocumentoComercial
    {
        public DocumentoComercial() { ;}
        public DocumentoComercial(string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, List<Item> pDetalle)
        {
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
        }

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total
        {
            get
            {
                decimal _Total = 0;
                foreach (Item obj in Detalle)
                {
                    _Total = _Total + obj.Importe;
                }
                return _Total;
            }
        }
    }
}
